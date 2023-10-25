namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Requests
{
    using Newtonsoft.Json;
    using Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Results;

    /// <summary>
    /// Represents the request to remove an Ethernet Group in the NetInsight Nimbra device.
    /// </summary>
    public class RemoveEthGroup : BaseRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveEthGroup"/> class.
        /// </summary>
        public RemoveEthGroup()
        {
            RequestType = RequestType.RemoveEthGroup;
        }

        /// <summary>
        /// Gets or sets the key associated with the Ethernet Group to be removed.
        /// </summary>
        [JsonProperty("Group Key")]
        public string GroupKey { get; set; }

        /// <summary>
        /// Generates the result object for the RemoveEthGroup request.
        /// </summary>
        /// <param name="success">A boolean indicating the success status of the request.</param>
        /// <param name="errorMessage">An optional error message, if any, associated with the request.</param>
        /// <returns>An instance of the <see cref="RemoveEthGroupResult"/> representing the result of the request.</returns>
        public IResult GetResult(bool success, string errorMessage = null)
        {
            return new RemoveEthGroupResult(Id, success, errorMessage);
        }
    }

}