namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Results
{
    using Newtonsoft.Json;
    using System;

    /// <summary>
    /// Represents the result of an Add Forwarding Function request sent to the NetInsight Nimbra device.
    /// </summary>
    public class AddForwardingFunctionResult : BaseResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddForwardingFunctionResult"/> class.
        /// </summary>
        /// <param name="id">The unique identifier for the result.</param>
        /// <param name="ffid">The Forwarding Function ID associated with the result.</param>
        /// <param name="tableKey">The Table Key associated with the result.</param>
        /// <param name="success">A flag indicating the success of the operation.</param>
        /// <param name="error">An optional error message if the operation was not successful.</param>
        public AddForwardingFunctionResult(Guid id, int ffid, string tableKey, bool success, string error = null)
        {
            this.Id = id;
            this.FfId = ffid;
            this.TableKey = tableKey;
            this.Success = success;
            this.Error = error;
            this.RequestType = Requests.RequestType.AddForwardingFunction;
        }

        /// <summary>
        /// Gets or sets the Forwarding Function ID associated with the result.
        /// </summary>
        [JsonProperty("FF ID")]
        public int FfId { get; set; }

        /// <summary>
        /// Gets or sets the Table Key associated with the result.
        /// </summary>
        [JsonProperty("Table Key")]
        public string TableKey { get; set; }
    }

}