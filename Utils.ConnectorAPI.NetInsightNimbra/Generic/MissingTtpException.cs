namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Represents an exception that is thrown when an ETS or ITS TTP (Terminal Termination Point) from the Nimbra device is missing.
    /// </summary>
    [Serializable]
    public class MissingTtpException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MissingTtpException"/> class with a custom message.
        /// </summary>
        /// <param name="message">The custom exception message describing the missing TTP.</param>
        public MissingTtpException(string message) : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MissingTtpException"/> class with a custom message and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message">The custom exception message describing the missing TTP.</param>
        /// <param name="ex">The inner exception reference.</param>
        public MissingTtpException(string message, Exception ex) : base(message, ex)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MissingTtpException"/> class with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="SerializationInfo"/> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="StreamingContext"/> that contains contextual information about the source or destination.</param>
        protected MissingTtpException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}