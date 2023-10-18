namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Requests
{
    using Newtonsoft.Json;
    using Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Results;

    public class AddItsDestination : BaseRequest
    {
        public AddItsDestination()
        {
            RequestType = RequestType.AddItsDestination;
            AdminState = AdminState.Up;
            IfProtection = ProtectionType.None;
            ExpectedIfProtection = ProtectionTypeExpected.None;
            TtpProtection = TruthValue.False;
        }

        [JsonProperty("IfKey")]
        public string InterfaceKey { get; set; }

        [JsonProperty("CustomerId")]
        public int CustomerId { get; set; }

        [JsonProperty("Purpose")]
        public string Purpose { get; set; }

        [JsonProperty("Suppress Alarm")]
        public SuppressAlarm SuppressAlarm { get; set; }

        [JsonProperty("TTP Protection")]
        public TruthValue TtpProtection { get; set; }

        [JsonProperty("Protection")]
        public ProtectionType IfProtection { get; set; }

        [JsonProperty("Expected Protection")]
        public ProtectionTypeExpected ExpectedIfProtection { get; set; }

        [JsonProperty("Admin State")]
        public AdminState AdminState { get; set; }

        public IResult GetResult(string ttpKey, int dsti, bool success, string errorMessage = null)
        {
            return new AddItsDestinationResult(Id, ttpKey, dsti, success, errorMessage);
        }
    }
}