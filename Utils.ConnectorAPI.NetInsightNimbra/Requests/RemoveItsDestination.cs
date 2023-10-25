namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Requests
{
    using Newtonsoft.Json;
    using Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Results;

    /// <summary>
    /// Represents the request to remove an TTP from the NetInsight Nimbra destination device.
    /// </summary>
    public class RemoveItsDestination : BaseRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveItsDestination"/> class.
        /// </summary>
        public RemoveItsDestination()
        {
            RequestType = RequestType.RemoveItsDestination;
        }

        /// <summary>
        /// Gets or sets the key associated TTP to be removed.
        /// </summary>
        [JsonProperty("TTP")]
        public string TtpKey { get; set; }

        /// <summary>
        /// Generates the result object for the RemoveItsDestination request.
        /// </summary>
        /// <param name="success">A boolean indicating the success status of the request.</param>
        /// <param name="errorMessage">An optional error message, if any, associated with the request.</param>
        /// <returns>An instance of the <see cref="RemoveItsDestinationResult"/> representing the result of the request.</returns>
        public IResult GetResult(bool success, string errorMessage = null)
        {
            return new RemoveItsDestinationResult(Id, success, errorMessage);
        }
    }

}