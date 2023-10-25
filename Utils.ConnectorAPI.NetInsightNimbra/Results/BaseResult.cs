namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Results
{
    using Newtonsoft.Json;
    using Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Requests;
    using System;

    /// <summary>
    /// Represents the base result of a request sent to the NetInsight Nimbra device.
    /// </summary>
    public class BaseResult : IResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BaseResult"/> class.
        /// </summary>
        protected BaseResult()
        {
        }

        /// <summary>
        /// Gets or sets the ID of the request.
        /// </summary>
        [JsonProperty("ID")]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the request was successful.
        /// </summary>
        [JsonProperty("Success")]
        public bool Success { get; set; }

        /// <summary>
        /// Gets or sets an error message if the request was not successful.
        /// </summary>
        [JsonProperty("Error", NullValueHandling = NullValueHandling.Ignore)]
        public string Error { get; set; }

        /// <summary>
        /// Gets or sets the type of command associated with this result.
        /// </summary>
        [JsonProperty("Request Type")]
        public RequestType RequestType { get; protected set; }
    }

}