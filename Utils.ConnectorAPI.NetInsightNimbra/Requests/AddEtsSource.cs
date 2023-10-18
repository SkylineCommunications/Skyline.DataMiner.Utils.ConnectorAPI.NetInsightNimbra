namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Requests
{
    using Newtonsoft.Json;
    using Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Results;

    public class AddEtsSource : BaseRequest
    {
        public AddEtsSource()
        {
            RequestType = RequestType.AddEtsSource;
            AdminState = AdminState.Up;
        }

        [JsonProperty("Eth Key")]
        public string EthDeviceKey { get; set; }

        [JsonProperty("DSTI")]
        public int? Dsti { get; set; }

        [JsonProperty("Mode")]
        public DestinationMode Mode { get; set; }

        [JsonProperty("Customer ID")]
        public int CustomerId { get; set; }

        [JsonProperty("Purpose")]
        public string Purpose { get; set; }

        [JsonProperty("Admin State")]
        public AdminState AdminState { get; set; }

        [JsonProperty("Snk Deg Thr")]
        public uint SnkDegThreshold { get; set; }

        [JsonProperty("Snk Minor BR Hi Thr")]
        public uint SnkMinorReducedBitrateHighThreshold { get; set; }

        [JsonProperty("Snk Minor BR Thr")]
        public uint SnkMinorReducedBitrateThreshold { get; set; }

        [JsonProperty("Snk BR Ais")]
        public TruthValue SnkReducedBitrateAis { get; set; }

        [JsonProperty("Snk BR Hi Thr")]
        public uint SnkReducedBitrateHighThreshold { get; set; }

        [JsonProperty("Snk BR Thr")]
        public uint SnkReducedBitrateThreshold { get; set; }

        [JsonProperty("Src Deg Period")]
        public uint SrcDegPeriod { get; set; }

        [JsonProperty("Src Deg Thr")]
        public uint SrcDegThreshold { get; set; }

        [JsonProperty("Src Minor BR Hi Thr")]
        public uint SrcMinorReducedBitrateHighThreshold { get; set; }

        [JsonProperty("Src Minor BR Thr")]
        public uint SrcMinorReducedBitrateThreshold { get; set; }

        [JsonProperty("Src Minor BR Ais")]
        public TruthValue SrcReducedBitrateAis { get; set; }

        [JsonProperty("Src BR Hi Thr")]
        public uint SrcReducedBitrateHighThreshold { get; set; }

        [JsonProperty("Src BR Thr")]
        public uint SrcReducedBitrateThreshold { get; set; }

        [JsonProperty("Snk Deg Period")]
        public uint SnkDegPeriod { get; set; }

        [JsonProperty("Snk Deg Ais")]
        public TruthValue SnkDegAis { get; set; }

        [JsonProperty("VLAN")]
        public int Vlan { get; set; }

        [JsonProperty("Prio Mode")]
        public PriorityMode PriorityMode { get; set; }

        [JsonProperty("Accept Frame")]
        public AcceptableFrameType AcceptableFrameType { get; set; }

        [JsonProperty("Default Eth Prio")]
        public int DefaultEthPriority { get; set; }

        [JsonProperty("Tx Frame")]
        public TxFrameType TxFrameType { get; set; }

        [JsonProperty("Default Traffic")]
        public int DefaultTrafficClass { get; set; }

        [JsonProperty("Expected Ch")]
        public TruthValue ExpectedChannel { get; set; }

        [JsonProperty("Flow Group")]
        public string FlowGroupMap { get; set; }

        [JsonProperty("FF ID")]
        public int ForwardFunctionId { get; set; }

        [JsonProperty("IF Group")]
        public int InterfaceGroup { get; set; }

        [JsonProperty("Learning")]
        public TruthValue Learning { get; set; }

        [JsonProperty("Settings", NullValueHandling = NullValueHandling.Ignore)]
        public TtpConnectionSettings Settings { get; set; }

        public IResult GetResult(string ttpKey, int dsti, bool success, string errorMessage = null)
        {
            return new AddEtsSourceResult(Id, ttpKey, dsti, success, errorMessage);
        }
    }
}