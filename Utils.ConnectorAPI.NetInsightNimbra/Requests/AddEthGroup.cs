namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Requests
{
    using Newtonsoft.Json;
    using Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Results;

    public class AddEthGroup : BaseRequest
    {
        public AddEthGroup()
        {
            RequestType = RequestType.AddEthGroup;
        }

        [JsonProperty("Device ID")]
        public string EthDeviceKey { get; set; }

        [JsonProperty("Protection")]
        public ProtectionType HitlessProtection { get; set; }

        [JsonProperty("Expected Protection")]
        public ProtectionTypeExpected ExpectedProtection { get; set; }

        [JsonProperty("Expected Channel")]
        public ExpectChannelStatusOptions ExpectedChannelStatus { get; set; }

        [JsonProperty("Admin State")]
        public AdminState AdminState { get; set; }

        public IResult GetResult(string groupKey, string groupId, bool success, string errorMessage = null)
        {
            return new AddEthGroupResult(Id, groupKey, groupId, success, errorMessage);
        }
    }
}