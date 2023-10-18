namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra
{
    using Skyline.DataMiner.Core.DataMinerSystem.Common;
    using System;
    using System.Runtime.Serialization;

    [Serializable]
    public class MissingResponseException : Exception
    {
        public MissingResponseException() : base("Failed to find response on manager.")
        {
        }

        public MissingResponseException(Guid requestId) : base($"Failed to find response on manager for {requestId}.")
        {
        }

        public MissingResponseException(DmsElementId manager, Guid requestId) : base($"Failed to find response on manager {manager.Value} for {requestId}.")
        {
        }

        public MissingResponseException(DmsElementId manager, DmsElementId node, Guid requestId) : base($"Failed to find response on manager {manager.Value} from {node.Value} for {requestId}.")
        {
        }

        public MissingResponseException(string message) : base(message)
        {
        }

        public MissingResponseException(string message, Exception ex) : base(message, ex)
        {
        }

        protected MissingResponseException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}