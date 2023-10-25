namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Requests
{
    using Newtonsoft.Json;
    using Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Results;

    /// <summary>
    /// Represents the request to remove a destination node in the NetInsight Nimbra device.
    /// </summary>
    public class RemoveDestination : BaseRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveDestination"/> class.
        /// </summary>
        public RemoveDestination()
        {
            RequestType = RequestType.RemoveDestination;
        }

        /// <summary>
        /// Gets or sets the key associated with the destination node to be removed.
        /// </summary>
        [JsonProperty("Key")]
        public string DestinationKey { get; set; }

        /// <summary>
        /// Generates the result object for the RemoveDestination request.
        /// </summary>
        /// <param name="success">A boolean indicating the success status of the request.</param>
        /// <param name="errorMessage">An optional error message, if any, associated with the request.</param>
        /// <returns>An instance of the <see cref="RemoveDestinationResult"/> representing the result of the request.</returns>
        public IResult GetResult(bool success, string errorMessage = null)
        {
            return new RemoveDestinationResult(Id, success, errorMessage);
        }
    }

}