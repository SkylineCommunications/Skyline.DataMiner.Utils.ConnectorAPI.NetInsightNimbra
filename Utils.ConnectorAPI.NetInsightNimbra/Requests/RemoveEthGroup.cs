namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Requests
{
    using Newtonsoft.Json;
    using Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Results;

    public class RemoveEthGroup : BaseRequest
    {
        public RemoveEthGroup()
        {
            RequestType = RequestType.RemoveEthGroup;
        }

        [JsonProperty("Group Key")]
        public string GroupKey { get; set; }

        public IResult GetResult(bool success, string errorMessage = null)
        {
            return new RemoveEthGroupResult(Id, success, errorMessage);
        }
    }
}