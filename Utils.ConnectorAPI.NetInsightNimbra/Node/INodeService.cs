namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra
{
    using System.Collections.Generic;

    /// <summary>
    /// Represent the service in the NetInsight Nimbra Node.
    /// </summary>
    public interface INodeService
    {
        /// <summary>
        /// Get the key of the service.
        /// </summary>
        string ServiceKey { get; }

        /// <summary>
        /// Get the customer of the service.
        /// </summary>
        int CustomerId { get; }

        /// <summary>
        /// Get the source DSTI of the service.
        /// </summary>
        string SrcDsti { get; }

        /// <summary>
        /// Get the purpose of the source TTP.
        /// </summary>
        string TtpPurpose { get; }

        /// <summary>
        /// Get the name of the source node.
        /// </summary>
        string SrcNodeName { get; }

        /// <summary>
        /// Get the service type of the service.
        /// </summary>
        ServiceTypes ServiceType { get; }

        /// <summary>
        /// Get the operational status of the service.
        /// </summary>
        ServiceOperationStatusNode OperStatus { get; }

        /// <summary>
        /// Get the destinations of the service.
        /// </summary>
        IEnumerable<IServiceDestination> Destinations { get; }

        /// <summary>
        /// Get the source ITS TTP.
        /// </summary>
        ISrcItsTtp SrcItsTtp { get; }

        /// <summary>
        /// Get the source ETS TTP.
        /// </summary>
        IEtsTtp SrcEtsTtp { get; }
    }
}