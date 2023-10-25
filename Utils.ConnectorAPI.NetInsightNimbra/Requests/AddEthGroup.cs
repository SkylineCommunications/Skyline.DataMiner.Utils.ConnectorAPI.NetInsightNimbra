namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Requests
{
    using Newtonsoft.Json;
    using Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Results;

    /// <summary>
    /// Represents a request to add an Ethernet Group to the NetInsight Nimbra device.
    /// </summary>
    public class AddEthGroup : BaseRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddEthGroup"/> class.
        /// </summary>
        public AddEthGroup()
        {
            RequestType = RequestType.AddEthGroup;
        }

        /// <summary>
        /// Gets or sets the device key associated with the Ethernet Group.
        /// </summary>
        [JsonProperty("Device ID")]
        public string EthDeviceKey { get; set; }

        /// <summary>
        /// Gets or sets the hitless protection type for the Ethernet Group.
        /// </summary>
        [JsonProperty("Protection")]
        public ProtectionType HitlessProtection { get; set; }

        /// <summary>
        /// Gets or sets the expected protection type for the Ethernet Group.
        /// </summary>
        [JsonProperty("Expected Protection")]
        public ProtectionTypeExpected ExpectedProtection { get; set; }

        /// <summary>
        /// Gets or sets the expected channel status options for the Ethernet Group.
        /// </summary>
        [JsonProperty("Expected Channel")]
        public ExpectChannelStatusOptions ExpectedChannelStatus { get; set; }

        /// <summary>
        /// Gets or sets the administrative state of the Ethernet Group.
        /// </summary>
        [JsonProperty("Admin State")]
        public AdminState AdminState { get; set; }

        /// <summary>
        /// Gets the result of the request.
        /// </summary>
        /// <param name="groupKey">The key associated with the Ethernet Group.</param>
        /// <param name="groupId">The ID associated with the Ethernet Group.</param>
        /// <param name="success">A flag indicating the success of the request.</param>
        /// <param name="errorMessage">An optional error message if the request was not successful.</param>
        /// <returns>An instance of <see cref="IResult"/> representing the result of the request.</returns>
        public IResult GetResult(string groupKey, string groupId, bool success, string errorMessage = null)
        {
            return new AddEthGroupResult(Id, groupKey, groupId, success, errorMessage);
        }
    }

}