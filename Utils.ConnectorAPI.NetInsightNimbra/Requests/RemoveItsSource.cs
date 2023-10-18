namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Requests
{
    using Newtonsoft.Json;
    using Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Results;

    public class RemoveItsSource : BaseRequest
    {
        public RemoveItsSource()
        {
            RequestType = RequestType.RemoveItsSource;
        }

        [JsonProperty("TTP")]
        public string TtpKey { get; set; }

        public IResult GetResult(bool success, string errorMessage = null)
        {
            return new RemoveItsSourceResult(Id, success, errorMessage);
        }
    }
}