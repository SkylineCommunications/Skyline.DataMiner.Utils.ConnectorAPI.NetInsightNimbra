namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Requests
{
    using Newtonsoft.Json;
    using Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Results;

    /// <summary>
    /// Represents the request to remove TTP from the NetInsight Nimbra source device.
    /// </summary>
    public class RemoveItsSource : BaseRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveItsSource"/> class.
        /// </summary>
        public RemoveItsSource()
        {
            RequestType = RequestType.RemoveItsSource;
        }

        /// <summary>
        /// Gets or sets th key associated with the TTP to be removed.
        /// </summary>
        [JsonProperty("TTP")]
        public string TtpKey { get; set; }

        /// <summary>
        /// Generates the result object for the RemoveItsSource request.
        /// </summary>
        /// <param name="success">A boolean indicating the success status of the request.</param>
        /// <param name="errorMessage">An optional error message, if any, associated with the request.</param>
        /// <returns>An instance of the <see cref="RemoveItsSourceResult"/> representing the result of the request.</returns>
        public IResult GetResult(bool success, string errorMessage = null)
        {
            return new RemoveItsSourceResult(Id, success, errorMessage);
        }
    }

}