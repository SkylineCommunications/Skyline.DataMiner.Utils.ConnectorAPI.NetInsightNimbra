namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra
{
    using Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Node;
    using Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Requests;
    using Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Results;
    using Skyline.DataMiner.Core.DataMinerSystem.Common;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;

    internal class NimbraNode : INimbraNode
    {
        internal const string ProtocolName = "NetInsight Nimbra";
        private bool caching;
        private IEnumerable<Channel> _channels;
        private IEnumerable<DtmInterface> _dtmInterfaces;
        private IEnumerable<DtmLink> _dtmLinks;
        private IEnumerable<NodeService> _servicesByKey;
        private IEnumerable<EthInterface> _ethInterfaces;
        private IEnumerable<EthDevice> _ethDevices;
        private IReadOnlyDictionary<string, IEnumerable<IServiceDestination>> _destinationsByServiceKey;
        private IReadOnlyDictionary<string, ISrcItsTtp> _srcItsTtps;
        private IReadOnlyDictionary<string, IDstItsTtp> _dstItsTtps;
        private IReadOnlyDictionary<string, IEtsTtp> _etsTtps;
        private string _systemName;
        private string _localMacAddress;
        private string _localDtmAddress;

        public static IEnumerable<NimbraNode> GetNodesFromDms(IDms dms, string version = "Production")
        {
            return dms.GetElements().Where(e => e.Protocol.Name.Equals(ProtocolName) && e.Protocol.Version.Equals(version)).Select(e => new NimbraNode(e));
        }

        public NimbraNode(IDmsElement element, bool caching = true)
        {
            this.Element = element;
            this.caching = caching;
        }

        public IDmsElement Element { get; private set; }

        public IEnumerable<IChannel> Channels
        {
            get
            {
                if (!caching)
                {
                    return GetChannels();
                }

                if (_channels == null)
                {
                    _channels = GetChannels();
                }

                return _channels;
            }
        }

        public IEnumerable<IDtmInterface> DtmInterfaces
        {
            get
            {
                if (!caching)
                {
                    return GetDtmInterfaces();
                }

                if (_dtmInterfaces == null)
                {
                    _dtmInterfaces = GetDtmInterfaces();
                }

                return _dtmInterfaces;
            }
        }

        public IEnumerable<IDtmLink> DtmLinks
        {
            get
            {
                if (!caching)
                {
                    return GetDtmLinks();
                }

                if (_dtmLinks == null)
                {
                    _dtmLinks = GetDtmLinks();
                }

                return _dtmLinks;
            }
        }

        public IEnumerable<INodeService> Services
        {
            get
            {
                if (!caching)
                {
                    return GetServices();
                }

                if (_servicesByKey == null)
                {
                    _servicesByKey = GetServices();
                }

                return _servicesByKey;
            }
        }

        public IReadOnlyDictionary<string, ISrcItsTtp> SrcItsTtps
        {
            get
            {
                if (!caching)
                {
                    return GetSrcItsTtps();
                }

                if (_srcItsTtps == null)
                {
                    _srcItsTtps = GetSrcItsTtps();
                }

                return _srcItsTtps;
            }
        }

        public IReadOnlyDictionary<string, IDstItsTtp> DstItsTtps
        {
            get
            {
                if (!caching)
                {
                    return GetDstItsTtps();
                }

                if (_dstItsTtps == null)
                {
                    _dstItsTtps = GetDstItsTtps();
                }

                return _dstItsTtps;
            }
        }

        public IReadOnlyDictionary<string, IEtsTtp> EtsTtps
        {
            get
            {
                if (!caching)
                {
                    return GetEtsTtps();
                }

                if (_etsTtps == null)
                {
                    _etsTtps = GetEtsTtps();
                }

                return _etsTtps;
            }
        }

        public IEnumerable<IEthInterface> EthInterfaces
        {
            get
            {
                if (!caching)
                {
                    return GetEthInterfaces();
                }

                if (_ethInterfaces == null)
                {
                    _ethInterfaces = GetEthInterfaces();
                }

                return _ethInterfaces;
            }
        }

        public IEnumerable<IEthDevice> EthDevices
        {
            get
            {
                if (!caching)
                {
                    return GetEthDevices();
                }

                if (_ethDevices == null)
                {
                    _ethDevices = GetEthDevices();
                }

                return _ethDevices;
            }
        }

        public IReadOnlyDictionary<string, IEnumerable<IServiceDestination>> ServiceDestinations
        {
            get
            {
                if (!caching)
                {
                    return GetServiceDestinations();
                }

                if (_destinationsByServiceKey == null)
                {
                    _destinationsByServiceKey = GetServiceDestinations();
                }

                return _destinationsByServiceKey;
            }
        }

        public string SystemName
        {
            get
            {
                if (!caching)
                {
                    return Element.GetStandaloneParameter<string>(15).GetValue();
                }

                if (_systemName == null)
                {
                    _systemName = Element.GetStandaloneParameter<string>(15).GetValue();
                }

                return _systemName;
            }
        }

        public string LocalMacAddress
        {
            get
            {
                if (!caching)
                {
                    return Element.GetStandaloneParameter<string>(22).GetValue();
                }

                if (_localMacAddress == null)
                {
                    _localMacAddress = Element.GetStandaloneParameter<string>(22).GetValue();
                }

                return _localMacAddress;
            }
        }

        public string LocalDtmAddress
        {
            get
            {
                if (!caching)
                {
                    return Element.GetStandaloneParameter<string>(25).GetValue();
                }

                if (_localDtmAddress == null)
                {
                    _localDtmAddress = Element.GetStandaloneParameter<string>(25).GetValue();
                }

                return _localDtmAddress;
            }
        }

        public void SendRequestToNode(IRequest request)
        {
            Element.GetStandaloneParameter<string>(60).SetValue(request.Serialize());
        }

        public IResult SendRequestAndGetResultFromManager(IDms dms, IRequest request, int timeoutInMilliSeconds = 60000, int pauseInMilliSeconds = 200)
        {
            Element.GetStandaloneParameter<string>(60).SetValue(request.Serialize());
            if (!request.Manager.HasValue)
            {
                throw new MissingManagerException();
            }

            var table = dms.GetElement(request.Manager.Value).GetTable(21900);
            var key = request.Id.ToString();
            var rowExists = SpinWait.SpinUntil(
                () =>
            {
                if (!table.RowExists(key))
                {
                    Thread.Sleep(pauseInMilliSeconds);
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

        private IEnumerable<Channel> GetChannels()
        {
            List<Channel> channels = new List<Channel>();

            // Get Service Table
            object[][] channelTableRows = Element.GetTable(600).GetRows();
            foreach (var row in channelTableRows)
            {
                channels.Add(new Channel(row));
            }

            return channels;
        }

        private IEnumerable<DtmInterface> GetDtmInterfaces()
        {
            List<DtmInterface> dtmInterfaces = new List<DtmInterface>();

            // Get Service Table
            object[][] dtmIfRows = Element.GetTable(100).GetRows();
            foreach (var row in dtmIfRows)
            {
                dtmInterfaces.Add(new DtmInterface(row));
            }

            return dtmInterfaces;
        }

        private IEnumerable<DtmLink> GetDtmLinks()
        {
            List<DtmLink> dtmLinks = new List<DtmLink>();

            // Get Service Table
            object[][] dtmLinkRows = Element.GetTable(150).GetRows();
            foreach (var row in dtmLinkRows)
            {
                var dtmLink = new DtmLink(row);
                if (dtmLink.RowState == DataMinerSnmpRowStatus.Deleted)
                {
                    continue;
                }

                dtmLinks.Add(dtmLink);
            }

            return dtmLinks;
        }

        private IEnumerable<NodeService> GetServices()
        {
            List<NodeService> services = new List<NodeService>();

            // Get Service Table
            object[][] serviceRows = Element.GetTable(5100).GetRows();
            foreach (var row in serviceRows)
            {
                var newService = new NodeService(this, row);
                services.Add(newService);
            }

            return services;
        }

        private IEnumerable<EthDevice> GetEthDevices()
        {
            List<EthDevice> ethDevices = new List<EthDevice>();

            object[][] ethDevicesRows = Element.GetTable(3200).GetRows();
            foreach (var row in ethDevicesRows)
            {
                ethDevices.Add(new EthDevice(row));
            }

            return ethDevices;
        }

        private IReadOnlyDictionary<string, IEnumerable<IServiceDestination>> GetServiceDestinations()
        {
            Dictionary<string, List<ServiceDestination>> destinations = new Dictionary<string, List<ServiceDestination>>();
            Dictionary<string, ServiceChannel> channels = new Dictionary<string, ServiceChannel>();

            // Get Destinations Table
            object[][] destinationRows = Element.GetTable(5200).GetRows();

            // Get Channels Table
            object[][] channelRows = Element.GetTable(5000).GetRows();

            foreach (var row in channelRows)
            {
                var newServiceChannel = new ServiceChannel(row);
                channels[newServiceChannel.Key] = newServiceChannel;
            }

            foreach (var row in destinationRows)
            {
                var newServiceDestination = new ServiceDestination(row, channels);
                if (!destinations.ContainsKey(newServiceDestination.ServiceKey))
                {
                    destinations[newServiceDestination.ServiceKey] = new List<ServiceDestination>();
                }

                destinations[newServiceDestination.ServiceKey].Add(newServiceDestination);
            }

            return destinations.ToDictionary(kv => kv.Key, kv => kv.Value as IEnumerable<IServiceDestination>);
        }

        private IReadOnlyDictionary<string, ISrcItsTtp> GetSrcItsTtps()
        {
            Dictionary<string, ISrcItsTtp> ttps = new Dictionary<string, ISrcItsTtp>();

            // Get Service Table
            object[][] ttpRows = Element.GetTable(200).GetRows();
            foreach (var row in ttpRows)
            {
                var newTtp = new SrcItsTtp(row);
                ttps[newTtp.Dsti] = newTtp;
            }

            return ttps;
        }

        private IReadOnlyDictionary<string, IDstItsTtp> GetDstItsTtps()
        {
            Dictionary<string, IDstItsTtp> ttps = new Dictionary<string, IDstItsTtp>();

            // Get Service Table
            object[][] ttpRows = Element.GetTable(250).GetRows();
            foreach (var row in ttpRows)
            {
                var newTtp = new DstItsTtp(row);
                ttps[newTtp.Dsti] = newTtp;
            }

            return ttps;
        }

        private IReadOnlyDictionary<string, IEtsTtp> GetEtsTtps()
        {
            Dictionary<string, IEtsTtp> ttps = new Dictionary<string, IEtsTtp>();

            // Get Service Table
            object[][] ttpRows = Element.GetTable(4300).GetRows();
            foreach (var row in ttpRows)
            {
                var newTtp = new EtsTtp(this, row);
                ttps[newTtp.Dsti] = newTtp;
            }

            return ttps;
        }

        private IEnumerable<EthInterface> GetEthInterfaces()
        {
            List<EthInterface> interfaces = new List<EthInterface>();

            // Get Service Table
            object[][] rows = Element.GetTable(4100).GetRows();
            foreach (var row in rows)
            {
                var newInterface = new EthInterface(row);
                interfaces.Add(newInterface);
            }

            return interfaces;
        }
    }
}