namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Requests
{
    using Newtonsoft.Json;
    using Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Results;

    /// <summary>
    /// Represents the request to remove a routing configuration (route) from the NetInsight Nimbra device.
    /// </summary>
    public class RemoveRoute : BaseRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveRoute"/> class.
        /// </summary>
        public RemoveRoute()
        {
            RequestType = RequestType.RemoveRoute;
        }

        /// <summary>
        /// Gets or sets the key identifying the route to be removed.
        /// </summary>
        [JsonProperty("Route")]
        public string RouteKey { get; set; }

        /// <summary>
        /// Generates the result object for the RemoveRoute request.
        /// </summary>
        /// <param name="success">A boolean indicating the success status of the request.</param>
        /// <param name="errorMessage">An optional error message, if any, associated with the request.</param>
        /// <returns>An instance of the <see cref="RemoveRouteResult"/> representing the result of the request.</returns>
        public IResult GetResult(bool success, string errorMessage = null)
        {
            return new RemoveRouteResult(Id, success, errorMessage);
        }
    }

}