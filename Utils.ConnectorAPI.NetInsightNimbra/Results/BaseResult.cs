namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Results
{
    using Newtonsoft.Json;
    using Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Requests;
    using System;

    public class BaseResult : IResult
    {
        protected BaseResult()
        {
        }

        /// <summary>
        /// Gets or sets the ID of the request.
        /// </summary>
        [JsonProperty("ID")]
        public Guid Id { get; set; }

        [JsonProperty("Success")]
        public bool Success { get; set; }

        [JsonProperty("Error", NullValueHandling = NullValueHandling.Ignore)]
        public string Error { get; set; }

        /// <summary>
        /// Gets or sets the type of command.
        /// </summary>
        [JsonProperty("Request Type")]
        public RequestType RequestType { get; protected set; }
    }
}