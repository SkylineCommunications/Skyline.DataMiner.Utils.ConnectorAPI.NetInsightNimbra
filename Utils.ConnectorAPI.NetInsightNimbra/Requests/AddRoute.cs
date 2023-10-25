namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Requests
{
    using Newtonsoft.Json;
    using Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Results;

    /// <summary>
    /// Represents the request to add a route in the NetInsight Nimbra device.
    /// </summary>
    public class AddRoute : BaseRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddRoute"/> class.
        /// </summary>
        public AddRoute()
        {
            RequestType = RequestType.AddRoute;
        }

        /// <summary>
        /// Gets or sets the destination key for the route.
        /// </summary>
        [JsonProperty("Dst Key")]
        public string DestinationKey { get; set; }

        /// <summary>
        /// Gets or sets the route number.
        /// </summary>
        [JsonProperty("Route Nbr")]
        public RouteNbrs RouteNbr { get; set; }

        /// <summary>
        /// Gets or sets the type of the route.
        /// </summary>
        [JsonProperty("Type")]
        public RouteType Type { get; set; }

        /// <summary>
        /// Gets or sets the name of the route.
        /// </summary>
        [JsonProperty("Name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the board ID of the interface.
        /// </summary>
        [JsonProperty("If Board")]
        public int IfBoardId { get; set; }

        /// <summary>
        /// Gets or sets the port ID of the interface.
        /// </summary>
        [JsonProperty("If Port")]
        public int IfPortId { get; set; }

        /// <summary>
        /// Gets or sets the channel of the route.
        /// </summary>
        [JsonProperty("Channel")]
        public int Channel { get; set; }

        /// <summary>
        /// Gets or sets an array of route hops.
        /// </summary>
        [JsonProperty("Hops")]
        public RouteHop[] Hops { get; set; }

        /// <summary>
        /// Generates the result object for the AddRoute request.
        /// </summary>
        /// <param name="success">A boolean indicating the success status of the request.</param>
        /// <param name="errorMessage">An optional error message, if any, associated with the request.</param>
        /// <returns>An instance of the <see cref="AddRouteResult"/> representing the result of the request.</returns>
        public IResult GetResult(bool success, string errorMessage = null)
        {
            return new AddRouteResult(Id, success, errorMessage);
        }

        /// <summary>
        /// Represents a route hop in the AddRoute request.
        /// </summary>
        public class RouteHop
        {
            /// <summary>
            /// Gets or sets the identity of the board where the DTM interface is located that shall be used for leaving the node.
            /// A value of zero (0) means that any board may be used.
            /// </summary>
            [JsonProperty("If Board")]
            public int NextHopInterfaceBoardId { get; set; }

            /// <summary>
            /// Gets or sets the identity of the port on the board specified in chmgrSourceRouteFirstIfCard that shall be used for leaving the node.
            /// A value of zero (0) means that any port may be used.
            /// </summary>
            [JsonProperty("If Port")]
            public int NextHopInterfacePortId { get; set; }

            /// <summary>
            /// Gets or sets the name of the Node that will be used in the next hop.
            /// </summary>
            [JsonProperty("Name")]
            public string NextHopNodeName { get; set; }
        }
    }

}