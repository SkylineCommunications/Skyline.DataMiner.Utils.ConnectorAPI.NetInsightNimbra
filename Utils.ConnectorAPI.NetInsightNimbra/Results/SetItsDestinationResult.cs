namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Results
{
    using Newtonsoft.Json;
    using System;

    /// <summary>
    /// Represents the result of a Set ITS (Intelligent Transport System) Destination request sent to the NetInsight Nimbra device.
    /// </summary>
    public class SetItsDestinationResult : BaseResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SetItsDestinationResult"/> class.
        /// </summary>
        /// <param name="id">The unique identifier for the result.</param>
        /// <param name="destinationKey">The destination key associated with the result.</param>
        /// <param name="success">A flag indicating the success of the operation.</param>
        /// <param name="error">An optional error message if the operation was not successful.</param>
        public SetItsDestinationResult(Guid id, string destinationKey, bool success, string error = null)
        {
            this.Id = id;
            this.Success = success;
            this.Error = error;
            this.DestinationKey = destinationKey;
            this.RequestType = Requests.RequestType.SetItsDestination;
        }

        /// <summary>
        /// Gets or sets the destination key associated with the result.
        /// </summary>
        [JsonProperty("Dst Key")]
        public string DestinationKey { get; set; }
    }

}