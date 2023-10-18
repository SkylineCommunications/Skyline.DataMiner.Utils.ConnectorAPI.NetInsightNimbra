namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Requests
{
    using Newtonsoft.Json;
    using Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Results;

    public class AddRoute : BaseRequest
    {
        public AddRoute()
        {
            RequestType = RequestType.AddRoute;
        }

        [JsonProperty("Dst Key")]
        public string DestinationKey { get; set; }

        [JsonProperty("Route Nbr")]
        public RouteNbrs RouteNbr { get; set; }

        [JsonProperty("Type")]
        public RouteType Type { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("If Board")]
        public int IfBoardId { get; set; }

        [JsonProperty("If Port")]
        public int IfPortId { get; set; }

        [JsonProperty("Channel")]
        public int Channel { get; set; }

        [JsonProperty("Hops")]
        public RouteHop[] Hops { get; set; }

        public IResult GetResult(bool success, string errorMessage = null)
        {
            return new AddRouteResult(Id, success, errorMessage);
        }

        public class RouteHop
        {
            /// <summary>
            /// Gets or sets the identity of the board where the DTM interface is located that shall be used for leaving the node.
            /// A value of zero(0) means that any board may be used.
            /// </summary>
            [JsonProperty("If Board")]
            public int NextHopInterfaceBoardId { get; set; }

            /// <summary>
            /// Gets or sets the identity of the port on the board specified in chmgrSourceRouteFirstIfCard that shall be used for leaving the node.
            /// A value of zero(0) means that any port may be used.
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