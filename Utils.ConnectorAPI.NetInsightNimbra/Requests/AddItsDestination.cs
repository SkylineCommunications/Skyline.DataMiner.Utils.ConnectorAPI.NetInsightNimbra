namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Requests
{
    using Newtonsoft.Json;
    using Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Results;

    /// <summary>
    /// Represents the request to add an ITS to the destination NetInsight Nimbra device.
    /// </summary>
    public class AddItsDestination : BaseRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddItsDestination"/> class.
        /// </summary>
        public AddItsDestination()
        {
            RequestType = RequestType.AddItsDestination;
            AdminState = AdminState.Up;
            IfProtection = ProtectionType.None;
            ExpectedIfProtection = ProtectionTypeExpected.None;
            TtpProtection = TruthValue.False;
        }

        /// <summary>
        /// Gets or sets the interface key associated with the ITS destination.
        /// </summary>
        [JsonProperty("IfKey")]
        public string InterfaceKey { get; set; }

        /// <summary>
        /// Gets or sets the customer ID associated with the ITS destination.
        /// </summary>
        [JsonProperty("CustomerId")]
        public int CustomerId { get; set; }

        /// <summary>
        /// Gets or sets the purpose of the ITS destination.
        /// </summary>
        [JsonProperty("Purpose")]
        public string Purpose { get; set; }

        /// <summary>
        /// Gets or sets the suppression of alarms for the ITS destination.
        /// </summary>
        [JsonProperty("Suppress Alarm")]
        public SuppressAlarm SuppressAlarm { get; set; }

        /// <summary>
        /// Gets or sets the TTP (Time-Triggered Protocol) protection status for the ITS destination.
        /// </summary>
        [JsonProperty("TTP Protection")]
        public TruthValue TtpProtection { get; set; }

        /// <summary>
        /// Gets or sets the protection type for the ITS destination interface.
        /// </summary>
        [JsonProperty("Protection")]
        public ProtectionType IfProtection { get; set; }

        /// <summary>
        /// Gets or sets the expected protection type for the ITS destination interface.
        /// </summary>
        [JsonProperty("Expected Protection")]
        public ProtectionTypeExpected ExpectedIfProtection { get; set; }

        /// <summary>
        /// Gets or sets the administrative state of the ITS destination.
        /// </summary>
        [JsonProperty("Admin State")]
        public AdminState AdminState { get; set; }

        /// <summary>
        /// Generates the result object for the AddItsDestination request.
        /// </summary>
        /// <param name="ttpKey">The TTP (Time-Triggered Protocol) key associated with the destination.</param>
        /// <param name="dsti">The Destination Set Identifier (DSTI) for the destination.</param>
        /// <param name="success">A boolean indicating the success status of the request.</param>
        /// <param name="errorMessage">An optional error message, if any, associated with the request.</param>
        /// <returns>An instance of the <see cref="AddItsDestinationResult"/> representing the result of the request.</returns>
        public IResult GetResult(string ttpKey, int dsti, bool success, string errorMessage = null)
        {
            return new AddItsDestinationResult(Id, ttpKey, dsti, success, errorMessage);
        }
    }

}