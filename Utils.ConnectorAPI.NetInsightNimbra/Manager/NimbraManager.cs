namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra
{
    using Skyline.DataMiner.Core.DataMinerSystem.Common;
    using Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Requests;
    using Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Results;
    using System;
    using System.Collections.Generic;
    using System.Threading;

    internal class NimbraManager : INimbraManager
    {
        internal const string ProtocolName = "NetInsight Nimbra Application Manager";
        private IEnumerable<ManagerService> _services;
        private IEnumerable<Customer> _customers;
        private IReadOnlyDictionary<DmsElementId, IManagerNode> _nodes;
        private IReadOnlyDictionary<string, DmsElementId> _nodeIdByDtm;

        public NimbraManager(IDmsElement element, bool caching = true)
        {
            this.Caching = caching;
            this.Element = element;
        }

        public bool Caching { get; set; }

        public IDmsElement Element { get; private set; }

        public IEnumerable<IManagerService> Services
        {
            get
            {
                if (!Caching)
                {
                    return GetServices();
                }

                if (_services == null)
                {
                    _services = GetServices();
                }

                return _services;
            }
        }

        public IEnumerable<ICustomer> Customers
        {
            get
            {
                if (!Caching)
                {
                    return GetCustomers();
                }

                if (_customers == null)
                {
                    _customers = GetCustomers();
                }

                return _customers;
            }
        }

        public IReadOnlyDictionary<DmsElementId, IManagerNode> Nodes
        {
            get
            {
                if (_nodes == null || !Caching)
                {
                    GetNodes();
                }

                return _nodes;
            }
        }

        public IReadOnlyDictionary<string, DmsElementId> NodeIdByDtm
        {
            get
            {
                if (_nodes == null || !Caching)
                {
                    GetNodes();
                }

                return _nodeIdByDtm;
            }
        }

        public bool TryGetNodeForDtm(string dtmAddress, out IManagerNode node)
        {
            node = null;
            if (!NodeIdByDtm.ContainsKey(dtmAddress))
            {
                return false;
            }

            node = Nodes[NodeIdByDtm[dtmAddress]];
            return true;
        }

        public void SendRequestToManager(IRequest request)
        {
            Element.GetStandaloneParameter<string>(60).SetValue(request.Serialize());
        }

        public void SendResponseToManager(IResult response)
        {
            Element.GetStandaloneParameter<string>(61).SetValue(response.Serialize());
        }

        public IResult SendRequestToNodeAndGetResultFromManager(IDms dms, IRequest request, int timeoutInMilliSeconds = 60000, int pauzeInMilliSeconds = 200)
        {
            if (!request.Node.HasValue)
            {
                throw new MissingNodeException();
            }

            if (!request.Manager.HasValue)
            {
                throw new MissingManagerException();
            }

            if (request.Manager.Value != Element.DmsElementId)
            {
                throw new MissingManagerException("Manager in request does not match this manager.");
            }

            var node = dms.GetElement(request.Node.Value);
            node.GetStandaloneParameter<string>(60).SetValue(request.Serialize());
            var table = Element.GetTable(21900);
            var key = request.Id.ToString();
            var rowExists = SpinWait.SpinUntil(
                () =>
                {
                    if (!table.RowExists(key))
                    {
                        Thread.Sleep(pauzeInMilliSeconds);
                        return false;
                    }

                    return true;
                },
            timeoutInMilliSeconds);
            if (!rowExists)
            {
                throw new MissingResponseException(request.Manager.Value, request.Node.Value, request.Id);
            }

            var sResponse = Convert.ToString(table.GetRow(key)[2]);
            return sResponse.DeserializeResult();
        }

        private IEnumerable<ManagerService> GetServices()
        {
            List<ManagerService> services = new List<ManagerService>();

            // Get Service Table
            object[][] serviceTableRows = Element.GetTable(1100).GetRows();
            foreach (var row in serviceTableRows)
            {
                services.Add(new ManagerService(this, row));
            }

            return services;
        }

        private IEnumerable<Customer> GetCustomers()
        {
            List<Customer> customers = new List<Customer>();

            // Get Service Table
            object[][] customerTableRow = Element.GetTable(5200).GetRows();
            foreach (var row in customerTableRow)
            {
                customers.Add(new Customer(row));
            }

            return customers;
        }

        private void GetNodes()
        {
            Dictionary<DmsElementId, IManagerNode> nodes = new Dictionary<DmsElementId, IManagerNode>();
            Dictionary<string, DmsElementId> nodeIdByDtm = new Dictionary<string, DmsElementId>();

            // Get Service Table
            object[][] nodeTableRows = Element.GetTable(1000).GetRows();
            foreach (var row in nodeTableRows)
            {
                var newNode = new ManagerNode(row);
                nodes[newNode.ElementId] = newNode;
                nodeIdByDtm[newNode.DtmAddress] = newNode.ElementId;
            }

            _nodeIdByDtm = nodeIdByDtm;
            _nodes = nodes;
        }
    }
}