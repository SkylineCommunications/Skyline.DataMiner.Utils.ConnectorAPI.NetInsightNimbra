namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Requests
{
    using Newtonsoft.Json;
    using Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Results;

    public class SetForwardingFunction : BaseRequest
    {
        public SetForwardingFunction()
        {
            RequestType = RequestType.SetForwardingFunction;
        }

        [JsonProperty("Eth IF Key")]
        public string EthIfKey { get; set; }

        [JsonProperty("FF Key")]
        public int ForwardingFunctionKey { get; set; }

        [JsonProperty("Purpose")]
        public string Purpose { get; set; }

        public IResult GetResult(bool success, string errorMessage = null)
        {
            return new SetForwardingFunctionResult(Id, success, errorMessage);
        }
    }
}