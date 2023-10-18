namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra
{
    using System;
    using System.Runtime.Serialization;

    [Serializable]
    public class MissingTtpException : Exception
    {
        public MissingTtpException(string message) : base(message)
        {
        }

        public MissingTtpException(string message, Exception ex) : base(message, ex)
        {
        }

        protected MissingTtpException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}