namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Requests
{
    using Newtonsoft.Json;
    using Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Results;

    /// <summary>
    /// Represents the request to remove a forwarding function in the NetInsight Nimbra device.
    /// </summary>
    public class RemoveForwardingFunction : BaseRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveForwardingFunction"/> class.
        /// </summary>
        public RemoveForwardingFunction()
        {
            RequestType = RequestType.RemoveForwardingFunction;
        }

        /// <summary>
        /// Gets or sets the key associated with the forwarding function to be removed.
        /// </summary>
        [JsonProperty("FF Key")]
        public string ForwardingFunctionKey { get; set; }

        /// <summary>
        /// Gets or sets the removal options for the forwarding function.
        /// </summary>
        [JsonProperty("Del Option")]
        public RemoveOptions RemoveOption { get; set; }

        /// <summary>
        /// Generates the result object for the RemoveForwardingFunction request.
        /// </summary>
        /// <param name="success">A boolean indicating the success status of the request.</param>
        /// <param name="errorMessage">An optional error message, if any, associated with the request.</param>
        /// <returns>An instance of the <see cref="RemoveForwardingFunctionResult"/> representing the result of the request.</returns>
        public IResult GetResult(bool success, string errorMessage = null)
        {
            return new RemoveForwardingFunctionResult(Id, success, errorMessage);
        }
    }


}