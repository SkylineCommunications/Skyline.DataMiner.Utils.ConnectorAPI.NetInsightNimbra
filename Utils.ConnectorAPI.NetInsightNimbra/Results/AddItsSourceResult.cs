namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Results
{
    using Newtonsoft.Json;
    using System;

    /// <summary>
    /// Represents the result of an Add ITS Source (to source node) request sent to the NetInsight Nimbra device.
    /// </summary>
    public class AddItsSourceResult : BaseResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddItsSourceResult"/> class.
        /// </summary>
        /// <param name="id">The unique identifier for the result.</param>
        /// <param name="ttpKey">The TTP Key associated with the result.</param>
        /// <param name="success">A flag indicating the success of the operation.</param>
        /// <param name="error">An optional error message if the operation was not successful.</param>
        public AddItsSourceResult(Guid id, string ttpKey, bool success, string error = null)
        {
            this.Id = id;
            this.Success = success;
            this.Error = error;
            this.TtpKey = ttpKey;
            this.RequestType = Requests.RequestType.AddItsSource;
        }

        /// <summary>
        /// Gets or sets the TTP Key associated with the result.
        /// </summary>
        [JsonProperty("TTP Key")]
        public string TtpKey { get; set; }
    }

}