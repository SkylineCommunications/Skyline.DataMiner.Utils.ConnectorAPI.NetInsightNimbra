namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Requests
{
    using Newtonsoft.Json;
    using Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Results;

    public class RemoveDestination : BaseRequest
    {
        public RemoveDestination()
        {
            RequestType = RequestType.RemoveDestination;
        }

        [JsonProperty("Key")]
        public string DestinationKey { get; set; }

        public IResult GetResult(bool success, string errorMessage = null)
        {
            return new RemoveDestinationResult(Id, success, errorMessage);
        }
    }
}