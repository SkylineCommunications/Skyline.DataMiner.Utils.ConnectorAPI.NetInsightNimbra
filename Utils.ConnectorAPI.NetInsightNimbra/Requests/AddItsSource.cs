namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Requests
{
    using Newtonsoft.Json;
    using Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Results;

    public class AddItsSource : BaseRequest
    {
        public AddItsSource()
        {
            RequestType = RequestType.AddItsSource;
            AdminState = AdminState.Up;
            HitlessProtection = ProtectionType.None;
            ExpectedProtection = ProtectionTypeExpected.None;
        }

        [JsonProperty("IfKey")]
        public string InterfaceKey { get; set; }

        [JsonProperty("CustomerId")]
        public int CustomerId { get; set; }

        [JsonProperty("Purpose")]
        public string Purpose { get; set; }

        [JsonProperty("Mode")]
        public DestinationMode Mode { get; set; }

        [JsonProperty("Protection")]
        public ProtectionType HitlessProtection { get; set; }

        [JsonProperty("Expected Protection")]
        public ProtectionTypeExpected ExpectedProtection { get; set; }

        [JsonProperty("Admin State")]
        public AdminState AdminState { get; set; }

        [JsonProperty("Settings", NullValueHandling = NullValueHandling.Ignore)]
        public TtpConnectionSettings Settings { get; set; }

        public IResult GetResult(string ttpKey, bool success, string errorMessage = null)
        {
            return new AddItsSourceResult(Id, ttpKey, success, errorMessage);
        }
    }
}