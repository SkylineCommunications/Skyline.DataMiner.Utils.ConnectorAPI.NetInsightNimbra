namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Requests
{
    using Skyline.DataMiner.Core.DataMinerSystem.Common;
    using System;

    public interface IRequest
    {
        /// <summary>
        /// Gets the ID of the request.
        /// </summary>
        Guid Id { get; }

        /// <summary>
        /// Gets the type of the command.
        /// </summary>
        RequestType RequestType { get; }

        /// <summary>
        /// Gets the node for which the command is intended.
        /// </summary>
        DmsElementId? Node { get; }

        /// <summary>
        /// Gets the manager that is the coordinator for this request.
        /// </summary>
        DmsElementId? Manager { get; }
    }
}