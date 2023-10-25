namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Requests
{
    using Newtonsoft.Json;
    using Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Results;

    /// <summary>
    /// Represents the request to remove an ETS source in the NetInsight Nimbra device.
    /// </summary>
    public class RemoveEtsSource : BaseRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveEtsSource"/> class.
        /// </summary>
        public RemoveEtsSource()
        {
            RequestType = RequestType.RemoveEtsSource;
        }

        /// <summary>
        /// Gets or sets the TTP key associated with the ETS source to be removed.
        /// </summary>
        [JsonProperty("TTP")]
        public string TtpKey { get; set; }

        /// <summary>
        /// Generates the result object for the RemoveEtsSource request.
        /// </summary>
        /// <param name="success">A boolean indicating the success status of the request.</param>
        /// <param name="errorMessage">An optional error message, if any, associated with the request.</param>
        /// <returns>An instance of the <see cref="RemoveEtsSourceResult"/> representing the result of the request.</returns>
        public IResult GetResult(bool success, string errorMessage = null)
        {
            return new RemoveEtsSourceResult(Id, success, errorMessage);
        }
    }

}