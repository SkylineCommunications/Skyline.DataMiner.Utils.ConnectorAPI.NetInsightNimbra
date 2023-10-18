namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Results
{
    using Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Requests;
    using System;

    public interface IResult
    {
        /// <summary>
        /// Gets the Id of the request.
        /// </summary>
        Guid Id { get; }

        /// <summary>
        /// Gets the type of the command.
        /// </summary>
        RequestType RequestType { get; }

        /// <summary>
        /// Gets a value indicating whether the request was handled successfully.
        /// </summary>
        bool Success { get; }

        /// <summary>
        /// Gets the error message in case of a failure.
        /// </summary>
        string Error { get; }
    }
}