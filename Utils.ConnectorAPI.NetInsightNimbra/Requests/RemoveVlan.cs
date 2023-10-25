namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Requests
{
    using Newtonsoft.Json;
    using Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Results;

    /// <summary>
    /// Represents the request to remove VLAN configurations from the NetInsight Nimbra device.
    /// </summary>
    public class RemoveVlan : BaseRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveVlan"/> class.
        /// </summary>
        public RemoveVlan()
        {
            RequestType = RequestType.RemoveVlan;
        }

        /// <summary>
        /// Gets or sets the keys identifying the VLAN configurations to be removed.
        /// </summary>
        [JsonProperty("VLAN Key")]
        public string[] VlanKeys { get; set; }

        /// <summary>
        /// Generates the result object for the RemoveVlan request.
        /// </summary>
        /// <param name="success">A boolean indicating the success status of the request.</param>
        /// <param name="errorMessage">An optional error message, if any, associated with the request.</param>
        /// <returns>An instance of the <see cref="RemoveVlanResult"/> representing the result of the request.</returns>
        public IResult GetResult(bool success, string errorMessage = null)
        {
            return new RemoveVlanResult(Id, success, errorMessage);
        }
    }

}