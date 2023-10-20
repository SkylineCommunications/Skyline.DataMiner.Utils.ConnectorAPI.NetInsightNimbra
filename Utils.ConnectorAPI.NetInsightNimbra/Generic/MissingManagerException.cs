namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra
{
    using System;
    using System.Runtime.Serialization;


    /// <summary>
    /// Represents an exception that is thrown when a Nimbra manager is missing in the current DataMiner System (DMS).
    /// </summary>
    [Serializable]
    public class MissingManagerException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MissingManagerException"/> class, indicating that a node should be configured in the request.
        /// </summary>
        public MissingManagerException() : base("Configure the manager in the request.")
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MissingManagerException"/> class with a custom message.
        /// </summary>
        /// <param name="message">The custom exception message describing the missing node.</param>
        public MissingManagerException(string message) : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MissingManagerException"/> class with a custom message and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message">The custom exception message describing the missing node.</param>
        /// <param name="ex">The inner exception reference.</param>
        public MissingManagerException(string message, Exception ex) : base (message, ex)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MissingManagerException"/> class with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="SerializationInfo"/> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="StreamingContext"/> that contains contextual information about the source or destination.</param>
        protected MissingManagerException(SerializationInfo info, StreamingContext context) : base (info, context)
        {
        }
    }
}