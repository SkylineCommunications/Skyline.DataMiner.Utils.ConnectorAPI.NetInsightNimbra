namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Requests
{
    using Newtonsoft.Json;
    using Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Results;

    /// <summary>
    /// Represents a request to add Ethernet Traffic Shaping (ETS) to a source on the NetInsight Nimbra node.
    /// </summary>
    public class AddEtsSource : BaseRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddEtsSource"/> class.
        /// </summary>
        public AddEtsSource()
        {
            RequestType = RequestType.AddEtsSource;
            AdminState = AdminState.Up;
        }

        /// <summary>
        /// Gets or sets the Ethernet device key associated with the source.
        /// </summary>
        [JsonProperty("Eth Key")]
        public string EthDeviceKey { get; set; }

        /// <summary>
        /// Gets or sets the Destination Set Identifier (DSTI) for the source.
        /// </summary>
        [JsonProperty("DSTI")]
        public int? Dsti { get; set; }

        /// <summary>
        /// Gets or sets the destination mode for the source.
        /// </summary>
        [JsonProperty("Mode")]
        public DestinationMode Mode { get; set; }

        /// <summary>
        /// Gets or sets the customer ID associated with the source.
        /// </summary>
        [JsonProperty("Customer ID")]
        public int CustomerId { get; set; }

        /// <summary>
        /// Gets or sets the purpose of the source.
        /// </summary>
        [JsonProperty("Purpose")]
        public string Purpose { get; set; }

        /// <summary>
        /// Gets or sets the administrative state of the source.
        /// </summary>
        [JsonProperty("Admin State")]
        public AdminState AdminState { get; set; }

        /// <summary>
        /// Gets or sets the threshold for sink degradation for the source.
        /// </summary>
        [JsonProperty("Snk Deg Thr")]
        public uint SnkDegThreshold { get; set; }

        /// <summary>
        /// Gets or sets the high threshold for sink minor reduced bitrate for the source.
        /// </summary>
        [JsonProperty("Snk Minor BR Hi Thr")]
        public uint SnkMinorReducedBitrateHighThreshold { get; set; }

        /// <summary>
        /// Gets or sets the threshold for sink minor reduced bitrate for the source.
        /// </summary>
        [JsonProperty("Snk Minor BR Thr")]
        public uint SnkMinorReducedBitrateThreshold { get; set; }

        /// <summary>
        /// Gets or sets the AIS (Alarm Indication Signal) status for sink reduced bitrate for the source.
        /// </summary>
        [JsonProperty("Snk BR Ais")]
        public TruthValue SnkReducedBitrateAis { get; set; }

        /// <summary>
        /// Gets or sets the high threshold for sink reduced bitrate for the source.
        /// </summary>
        [JsonProperty("Snk BR Hi Thr")]
        public uint SnkReducedBitrateHighThreshold { get; set; }

        /// <summary>
        /// Gets or sets the threshold for sink reduced bitrate for the source.
        /// </summary>
        [JsonProperty("Snk BR Thr")]
        public uint SnkReducedBitrateThreshold { get; set; }

        /// <summary>
        /// Gets or sets the degradation period for source.
        /// </summary>
        [JsonProperty("Src Deg Period")]
        public uint SrcDegPeriod { get; set; }

        /// <summary>
        /// Gets or sets the threshold for source degradation.
        /// </summary>
        [JsonProperty("Src Deg Thr")]
        public uint SrcDegThreshold { get; set; }

        /// <summary>
        /// Gets or sets the high threshold for source minor reduced bitrate.
        /// </summary>
        [JsonProperty("Src Minor BR Hi Thr")]
        public uint SrcMinorReducedBitrateHighThreshold { get; set; }

        /// <summary>
        /// Gets or sets the threshold for source minor reduced bitrate.
        /// </summary>
        [JsonProperty("Src Minor BR Thr")]
        public uint SrcMinorReducedBitrateThreshold { get; set; }

        /// <summary>
        /// Gets or sets the AIS (Alarm Indication Signal) status for source reduced bitrate.
        /// </summary>
        [JsonProperty("Src Minor BR Ais")]
        public TruthValue SrcReducedBitrateAis { get; set; }

        /// <summary>
        /// Gets or sets the high threshold for source reduced bitrate.
        /// </summary>
        [JsonProperty("Src BR Hi Thr")]
        public uint SrcReducedBitrateHighThreshold { get; set; }

        /// <summary>
        /// Gets or sets the threshold for source reduced bitrate.
        /// </summary>
        [JsonProperty("Src BR Thr")]
        public uint SrcReducedBitrateThreshold { get; set; }

        /// <summary>
        /// Gets or sets the degradation period for sink.
        /// </summary>
        [JsonProperty("Snk Deg Period")]
        public uint SnkDegPeriod { get; set; }

        /// <summary>
        /// Gets or sets the AIS (Alarm Indication Signal) status for sink degradation.
        /// </summary>
        [JsonProperty("Snk Deg Ais")]
        public TruthValue SnkDegAis { get; set; }

        /// <summary>
        /// Gets or sets the VLAN (Virtual LAN) associated with the source.
        /// </summary>
        [JsonProperty("VLAN")]
        public int Vlan { get; set; }

        /// <summary>
        /// Gets or sets the priority mode for the source.
        /// </summary>
        [JsonProperty("Prio Mode")]
        public PriorityMode PriorityMode { get; set; }

        /// <summary>
        /// Gets or sets the acceptable frame type for the source.
        /// </summary>
        [JsonProperty("Accept Frame")]
        public AcceptableFrameType AcceptableFrameType { get; set; }

        /// <summary>
        /// Gets or sets the default Ethernet priority for the source.
        /// </summary>
        [JsonProperty("Default Eth Prio")]
        public int DefaultEthPriority { get; set; }

        /// <summary>
        /// Gets or sets the transmission frame type for the source.
        /// </summary>
        [JsonProperty("Tx Frame")]
        public TxFrameType TxFrameType { get; set; }

        /// <summary>
        /// Gets or sets the default traffic class for the source.
        /// </summary>
        [JsonProperty("Default Traffic")]
        public int DefaultTrafficClass { get; set; }

        /// <summary>
        /// Gets or sets the expected channel status for the source.
        /// </summary>
        [JsonProperty("Expected Ch")]
        public TruthValue ExpectedChannel { get; set; }

        /// <summary>
        /// Gets or sets the flow group mapping for the source.
        /// </summary>
        [JsonProperty("Flow Group")]
        public string FlowGroupMap { get; set; }

        /// <summary>
        /// Gets or sets the Forward Function ID (FF ID) associated with the source.
        /// </summary>
        [JsonProperty("FF ID")]
        public int ForwardFunctionId { get; set; }

        /// <summary>
        /// Gets or sets the interface group for the source.
        /// </summary>
        [JsonProperty("IF Group")]
        public int InterfaceGroup { get; set; }

        /// <summary>
        /// Gets or sets the learning status for the source.
        /// </summary>
        [JsonProperty("Learning")]
        public TruthValue Learning { get; set; }

        /// <summary>
        /// Gets or sets the TtpConnectionSettings for the source. (Nullable, and will be ignored if null.)
        /// </summary>
        [JsonProperty("Settings", NullValueHandling = NullValueHandling.Ignore)]
        public TtpConnectionSettings Settings { get; set; }

        /// <summary>
        /// Generates the result object for the AddEtsSource request.
        /// </summary>
        /// <param name="ttpKey">The TTP (Time-Triggered Protocol) key associated with the source.</param>
        /// <param name="dsti">The Destination Set Identifier (DSTI) for the source.</param>
        /// <param name="success">A boolean indicating the success status of the request.</param>
        /// <param name="errorMessage">An optional error message, if any, associated with the request.</param>
        /// <returns>An instance of the <see cref="AddEtsSourceResult"/> representing the result of the request.</returns>
        public IResult GetResult(string ttpKey, int dsti, bool success, string errorMessage = null)
        {
            return new AddEtsSourceResult(Id, ttpKey, dsti, success, errorMessage);
        }
    }
}