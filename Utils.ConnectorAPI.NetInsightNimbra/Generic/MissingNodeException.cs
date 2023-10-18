namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra
{
    using System;
    using System.Runtime.Serialization;

    [Serializable]
    public class MissingNodeException : Exception
    {
        public MissingNodeException() : base("Configure the node in the request.")
        {
        }

        public MissingNodeException(string message) : base(message)
        {
        }

        public MissingNodeException(string message, Exception ex) : base(message, ex)
        {
        }

        protected MissingNodeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}