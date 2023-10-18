namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Requests
{
    using Newtonsoft.Json;
    using Skyline.DataMiner.Core.DataMinerSystem.Common;
    using System;

    public class BaseRequest : IRequest
    {
        protected BaseRequest()
        {
            Id = Guid.NewGuid();
        }

        /// <summary>
        /// Gets or sets the ID of the request.
        /// </summary>
        [JsonProperty("ID")]
        public Guid Id { get; protected set; }

        /// <summary>
        /// Gets or sets the type of command.
        /// </summary>
        [JsonProperty("Request Type")]
        public RequestType RequestType { get; protected set; }

        [JsonIgnore]
        public DmsElementId? Node { get; set; }

        [JsonIgnore]
        public DmsElementId? Manager { get; set; }

        [JsonProperty("Node")]
        internal string NodeId
        {
            get
            {
                return Node?.Value;
            }

            set
            {
                Node = new DmsElementId(value);
            }
        }

        [JsonProperty("Manager")]
        internal string ManagerId
        {
            get
            {
                return Manager?.Value;
            }

            set
            {
                Manager = new DmsElementId(value);
            }
        }
    }
}