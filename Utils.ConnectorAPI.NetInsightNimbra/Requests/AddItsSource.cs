namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Requests
{
    using Newtonsoft.Json;
    using Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Results;

    /// <summary>
    /// Represents the request to add an ITS to the NetInsight Nimbra source device.
    /// </summary>
    public class AddItsSource : BaseRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddItsSource"/> class.
        /// </summary>
        public AddItsSource()
        {
            RequestType = RequestType.AddItsSource;
            AdminState = AdminState.Up;
            HitlessProtection = ProtectionType.None;
            ExpectedProtection = ProtectionTypeExpected.None;
        }

        /// <summary>
        /// Gets or sets the interface key associated with the ITS source.
        /// </summary>
        [JsonProperty("IfKey")]
        public string InterfaceKey { get; set; }

        /// <summary>
        /// Gets or sets the customer ID associated with the ITS source.
        /// </summary>
        [JsonProperty("CustomerId")]
        public int CustomerId { get; set; }

        /// <summary>
        /// Gets or sets the purpose of the ITS source.
        /// </summary>
        [JsonProperty("Purpose")]
        public string Purpose { get; set; }

        /// <summary>
        /// Gets or sets the destination mode for the ITS source.
        /// </summary>
        [JsonProperty("Mode")]
        public DestinationMode Mode { get; set; }

        /// <summary>
        /// Gets or sets the hitless protection type for the ITS source.
        /// </summary>
        [JsonProperty("Protection")]
        public ProtectionType HitlessProtection { get; set; }

        /// <summary>
        /// Gets or sets the expected protection type for the ITS source.
        /// </summary>
        [JsonProperty("Expected Protection")]
        public ProtectionTypeExpected ExpectedProtection { get; set; }

        /// <summary>
        /// Gets or sets the administrative state of the ITS source.
        /// </summary>
        [JsonProperty("Admin State")]
        public AdminState AdminState { get; set; }

        /// <summary>
        /// Gets or sets the TTP (Time-Triggered Protocol) connection settings for the ITS source.
        /// </summary>
        [JsonProperty("Settings", NullValueHandling = NullValueHandling.Ignore)]
        public TtpConnectionSettings Settings { get; set; }

        /// <summary>
        /// Generates the result object for the AddItsSource request.
        /// </summary>
        /// <param name="ttpKey">The TTP (Time-Triggered Protocol) key associated with the source.</param>
        /// <param name="success">A boolean indicating the success status of the request.</param>
        /// <param name="errorMessage">An optional error message, if any, associated with the request.</param>
        /// <returns>An instance of the <see cref="AddItsSourceResult"/> representing the result of the request.</returns>
        public IResult GetResult(string ttpKey, bool success, string errorMessage = null)
        {
            return new AddItsSourceResult(Id, ttpKey, success, errorMessage);
        }
    }

}