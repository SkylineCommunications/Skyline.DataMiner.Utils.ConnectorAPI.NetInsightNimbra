namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Requests
{
    using Newtonsoft.Json;
    using Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Results;

    /// <summary>
    /// Represents the request to set forwarding function settings on the NetInsight Nimbra device.
    /// </summary>
    public class SetForwardingFunction : BaseRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SetForwardingFunction"/> class.
        /// </summary>
        public SetForwardingFunction()
        {
            RequestType = RequestType.SetForwardingFunction;
        }

        /// <summary>
        /// Gets or sets the Ethernet interface key associated with the forwarding function.
        /// </summary>
        [JsonProperty("Eth IF Key")]
        public string EthIfKey { get; set; }

        /// <summary>
        /// Gets or sets the key identifying the forwarding function.
        /// </summary>
        [JsonProperty("FF Key")]
        public int ForwardingFunctionKey { get; set; }

        /// <summary>
        /// Gets or sets the purpose of the forwarding function.
        /// </summary>
        [JsonProperty("Purpose")]
        public string Purpose { get; set; }

        /// <summary>
        /// Generates the result object for the SetForwardingFunction request.
        /// </summary>
        /// <param name="success">A boolean indicating the success status of the request.</param>
        /// <param name="errorMessage">An optional error message, if any, associated with the request.</param>
        /// <returns>An instance of the <see cref="SetForwardingFunctionResult"/> representing the result of the request.</returns>
        public IResult GetResult(bool success, string errorMessage = null)
        {
            return new SetForwardingFunctionResult(Id, success, errorMessage);
        }
    }

}