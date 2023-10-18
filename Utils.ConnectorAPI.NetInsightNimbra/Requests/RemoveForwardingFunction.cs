namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Requests
{
    using Newtonsoft.Json;
    using Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Results;

    public class RemoveForwardingFunction : BaseRequest
    {
        public RemoveForwardingFunction()
        {
            RequestType = RequestType.RemoveForwardingFunction;
        }

        [JsonProperty("FF Key")]
        public string ForwardingFunctionKey { get; set; }

        [JsonProperty("Del Option")]
        public RemoveOptions RemoveOption { get; set; }

        public IResult GetResult(bool success, string errorMessage = null)
        {
            return new RemoveForwardingFunctionResult(Id, success, errorMessage);
        }
    }
}