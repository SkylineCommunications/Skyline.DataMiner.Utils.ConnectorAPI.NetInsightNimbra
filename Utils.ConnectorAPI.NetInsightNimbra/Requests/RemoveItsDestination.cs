namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Requests
{
    using Newtonsoft.Json;
    using Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Results;

    public class RemoveItsDestination : BaseRequest
    {
        public RemoveItsDestination()
        {
            RequestType = RequestType.RemoveItsDestination;
        }

        [JsonProperty("TTP")]
        public string TtpKey { get; set; }

        public IResult GetResult(bool success, string errorMessage = null)
        {
            return new RemoveItsDestinationResult(Id, success, errorMessage);
        }
    }
}