namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Requests
{
    using Newtonsoft.Json;
    using Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Results;

    public class RemoveRoute : BaseRequest
    {
        public RemoveRoute()
        {
            RequestType = RequestType.RemoveRoute;
        }

        [JsonProperty("Route")]
        public string RouteKey { get; set; }

        public IResult GetResult(bool success, string errorMessage = null)
        {
            return new RemoveRouteResult(Id, success, errorMessage);
        }
    }
}