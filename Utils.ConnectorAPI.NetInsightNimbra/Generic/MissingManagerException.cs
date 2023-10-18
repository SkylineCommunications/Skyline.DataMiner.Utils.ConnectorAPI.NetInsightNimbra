namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra
{
    using System;
    using System.Runtime.Serialization;

    [Serializable]
    public class MissingManagerException : Exception
    {
        public MissingManagerException() : base("Configure the manager in the request.")
        {
        }

        public MissingManagerException(string message) : base(message)
        {
        }

        public MissingManagerException(string message, Exception ex) : base(message, ex)
        {
        }

        protected MissingManagerException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}