namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Requests
{
    using Newtonsoft.Json;
    using Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Results;

    public class RemoveEtsSource : BaseRequest
    {
        public RemoveEtsSource()
        {
            RequestType = RequestType.RemoveEtsSource;
        }

        [JsonProperty("TTP")]
        public string TtpKey { get; set; }

        public IResult GetResult(bool success, string errorMessage = null)
        {
            return new RemoveEtsSourceResult(Id, success, errorMessage);
        }
    }
}