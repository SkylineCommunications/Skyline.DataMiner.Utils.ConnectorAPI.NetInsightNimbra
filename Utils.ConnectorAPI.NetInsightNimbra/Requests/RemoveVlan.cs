namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Requests
{
    using Newtonsoft.Json;
    using Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Results;

    public class RemoveVlan : BaseRequest
    {
        public RemoveVlan()
        {
            RequestType = RequestType.RemoveVlan;
        }

        [JsonProperty("VLAN Key")]
        public string[] VlanKeys { get; set; }

        public IResult GetResult(bool success, string errorMessage = null)
        {
            return new RemoveVlanResult(Id, success, errorMessage);
        }
    }
}