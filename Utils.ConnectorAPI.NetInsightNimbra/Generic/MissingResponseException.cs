namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra
{
    using Skyline.DataMiner.Core.DataMinerSystem.Common;
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Represents an exception that is thrown when a response from the Nimbra device is missing.
    /// </summary>
    [Serializable]
    public class MissingResponseException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MissingResponseException"/> class with a default message.
        /// </summary>
        public MissingResponseException() : base("Failed to find response on manager.")
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MissingResponseException"/> class with the specified request ID.
        /// </summary>
        /// <param name="requestId">The request identifier that did not receive a response.</param>
        public MissingResponseException(Guid requestId) : base($"Failed to find response on manager for {requestId}.")
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MissingResponseException"/> class with the specified manager and request ID.
        /// </summary>
        /// <param name="manager">The manager that failed to provide a response.</param>
        /// <param name="requestId">The request identifier that did not receive a response.</param>
        public MissingResponseException(DmsElementId manager, Guid requestId) : base($"Failed to find response on manager {manager.Value} for {requestId}.")
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MissingResponseException"/> class with the specified manager, node, and request ID.
        /// </summary>
        /// <param name="manager">The manager that failed to provide a response.</param>
        /// <param name="node">The node that was expected to respond.</param>
        /// <param name="requestId">The request identifier that did not receive a response.</param>
        public MissingResponseException(DmsElementId manager, DmsElementId node, Guid requestId) : base($"Failed to find response on manager {manager.Value} from {node.Value} for {requestId}.")
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MissingResponseException"/> class with a custom message.
        /// </summary>
        /// <param name="message">The custom exception message.</param>
        public MissingResponseException(string message) : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MissingResponseException"/> class with a custom message and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message">The custom exception message.</param>
        /// <param name="ex">The inner exception reference.</param>
        public MissingResponseException(string message, Exception ex) : base(message, ex)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MissingResponseException"/> class with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="SerializationInfo"/> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="StreamingContext"/> that contains contextual information about the source or destination.</param>
        protected MissingResponseException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}