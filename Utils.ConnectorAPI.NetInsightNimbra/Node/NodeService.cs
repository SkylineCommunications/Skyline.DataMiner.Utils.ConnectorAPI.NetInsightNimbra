namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra
{
    using System;
    using System.Collections.Generic;

    internal class NodeService : INodeService
    {
        private readonly NimbraNode node;

        internal NodeService(NimbraNode node, object[] serviceRow)
        {
            if (serviceRow.Length < 33)
            {
                throw new ArgumentException($"ERROR|Service row does not contain 33 columns: '" + string.Join("', '", serviceRow) + "'", "serviceRow");
            }

            this.node = node;
            ServiceKey = Convert.ToString(serviceRow[0]);
            ServiceType = (ServiceTypes)Convert.ToInt32(serviceRow[15]);
            CustomerId = Convert.ToInt32(serviceRow[1]);
            SrcDsti = Convert.ToString(serviceRow[9]);
            SrcNodeName = node.Element.Name;
            TtpPurpose = Convert.ToString(serviceRow[14]);
            OperStatus = (ServiceOperationStatusNode)Convert.ToInt32(serviceRow[26]);
        }

        public string ServiceKey { get; private set; }

        public int CustomerId { get; private set; }

        public string TtpPurpose { get; private set; }

        public string SrcDsti { get; private set; }

        public string SrcNodeName { get; private set; }

        public ServiceTypes ServiceType { get; private set; }

        public ServiceOperationStatusNode OperStatus { get; private set; }

        public IEnumerable<IServiceDestination> Destinations
        {
            get
            {
                if (!node.ServiceDestinations.ContainsKey(ServiceKey))
                {
                    return new IServiceDestination[0];
                }

                return node.ServiceDestinations[ServiceKey];
            }
        }

        public ISrcItsTtp SrcItsTtp
        {
            get
            {
                if (ServiceType != ServiceTypes.ITS)
                {
                    throw new MissingTtpException($"This service is not a ITS service");
                }

                if (!node.SrcItsTtps.ContainsKey(SrcDsti))
                {
                    throw new MissingTtpException($"Unable to find ITS Source TTP with DSTI {SrcDsti}");
                }

                return node.SrcItsTtps[SrcDsti];
            }
        }

        public IEtsTtp SrcEtsTtp
        {
            get
            {
                if (ServiceType != ServiceTypes.ETS)
                {
                    throw new MissingTtpException($"This service is not a ETS service");
                }

                if (!node.EtsTtps.ContainsKey(SrcDsti))
                {
                    throw new MissingTtpException($"Unable to find ETS TTP with DSTI {SrcDsti}");
                }

                return node.EtsTtps[SrcDsti];
            }
        }
    }
}