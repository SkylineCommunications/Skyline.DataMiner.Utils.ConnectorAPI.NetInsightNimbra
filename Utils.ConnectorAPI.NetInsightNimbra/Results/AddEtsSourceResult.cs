namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Results
{
    using Newtonsoft.Json;
    using System;

    /// <summary>
    /// Represents the result of an Add ETS source (to source node)  request sent to the NetInsight Nimbra device.
    /// </summary>
    public class AddEtsSourceResult : BaseResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddEtsSourceResult"/> class.
        /// </summary>
        /// <param name="id">The unique identifier for the result.</param>
        /// <param name="ttpKey">The TTP Key associated with the result.</param>
        /// <param name="dsti">The DSTI (Destination Identifier) associated with the result.</param>
        /// <param name="success">A flag indicating the success of the operation.</param>
        /// <param name="error">An optional error message if the operation was not successful.</param>
        public AddEtsSourceResult(Guid id, string ttpKey, int dsti, bool success, string error = null)
        {
            this.Id = id;
            this.Success = success;
            this.Dsti = dsti;
            this.Error = error;
            this.TtpKey = ttpKey;
            this.RequestType = Requests.RequestType.AddEtsSource;
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