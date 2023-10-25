namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Requests
{
    using Newtonsoft.Json;
    using Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Results;
    using System;

    /// <summary>
    /// Represents the request to add a Forwarding Function to the NetInsight Nimbra device.
    /// </summary>
    public class AddForwardingFunction : BaseRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddForwardingFunction"/> class.
        /// </summary>
        public AddForwardingFunction()
        {
            RequestType = RequestType.AddForwardingFunction;
        }

        /// <summary>
        /// Gets or sets the aging time for the Forwarding Function.
        /// </summary>
        [JsonProperty("Aging Time")]
        public TimeSpan AgingTime { get; set; }

        /// <summary>
        /// Gets or sets the customer ID associated with the Forwarding Function.
        /// </summary>
        [JsonProperty("CustomerId")]
        public int CustomerId { get; set; }

        /// <summary>
        /// Gets or sets the Ethernet device key for the Forwarding Function.
        /// </summary>
        [JsonProperty("Eth Key")]
        public string EthDeviceKey { get; set; }

        /// <summary>
        /// Gets or sets the VLAN (Virtual LAN) mode for the Forwarding Function.
        /// </summary>
        [JsonProperty("VLAN Mode")]
        public VlanMode VlanMode { get; set; }

        /// <summary>
        /// Gets or sets the Spanning Tree mode for the Forwarding Function.
        /// </summary>
        [JsonProperty("Spanning Tree")]
        public SpanningTree SpanningTree { get; set; }

        /// <summary>
        /// Gets or sets the purpose of the Forwarding Function.
        /// </summary>
        [JsonProperty("Purpose")]
        public string Purpose { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether faults should be propagated by the Forwarding Function.
        /// </summary>
        [JsonProperty("Propagate Faults")]
        public TruthValue PropagateFaults { get; set; }

        /// <summary>
        /// Gets or sets the MAC (Media Access Control) mode for the Forwarding Function.
        /// </summary>
        [JsonProperty("MAC Mode")]
        public MacMode MacMode { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether Jumbo Frames are supported by the Forwarding Function.
        /// </summary>
        [JsonProperty("Jumbo Frames")]
        public TruthValue JumboFrames { get; set; }

        /// <summary>
        /// Generates the result object for the AddForwardingFunction request.
        /// </summary>
        /// <param name="ffid">The Forwarding Function ID (FF ID) associated with the request.</param>
        /// <param name="tableKey">The table key associated with the Forwarding Function.</param>
        /// <param name="success">A boolean indicating the success status of the request.</param>
        /// <param name="errorMessage">An optional error message, if any, associated with the request.</param>
        /// <returns>An instance of the <see cref="AddForwardingFunctionResult"/> representing the result of the request.</returns>
        public IResult GetResult(int ffid, string tableKey, bool success, string errorMessage = null)
        {
            return new AddForwardingFunctionResult(Id, ffid, tableKey, success, errorMessage);
        }
    }

}