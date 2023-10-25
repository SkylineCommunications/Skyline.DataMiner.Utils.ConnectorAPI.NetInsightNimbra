namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Results
{
    using Newtonsoft.Json;
    using System;

    /// <summary>
    /// Represents the result of an Add ITS Destination (to destination node) request sent to the NetInsight Nimbra device.
    /// </summary>
    public class AddItsDestinationResult : BaseResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddItsDestinationResult"/> class.
        /// </summary>
        /// <param name="id">The unique identifier for the result.</param>
        /// <param name="ttpKey">The TTP Key associated with the result.</param>
        /// <param name="dsti">The DSTI (Destination Identifier) associated with the result.</param>
        /// <param name="success">A flag indicating the success of the operation.</param>
        /// <param name="error">An optional error message if the operation was not successful.</param>
        public AddItsDestinationResult(Guid id, string ttpKey, int dsti, bool success, string error = null)
        {
            this.Id = id;
            this.Success = success;
            this.Error = error;
            this.TtpKey = ttpKey;
            this.Dsti = dsti;
            this.RequestType = Requests.RequestType.AddItsDestination;
        }

        /// <summary>
        /// Gets or sets the TTP Key associated with the result.
        /// </summary>
        [JsonProperty("TTP Key")]
        public string TtpKey { get; set; }

        /// <summary>
        /// Gets or sets the DSTI (Destination Identifier) associated with the result.
        /// </summary>
        [JsonProperty("DSTI")]
        public int Dsti { get; set; }
    }

}