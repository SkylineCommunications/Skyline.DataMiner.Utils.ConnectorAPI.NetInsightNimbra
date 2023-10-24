namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra
{
    using Skyline.DataMiner.Core.DataMinerSystem.Common;
    using Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Manager;
    using System.Collections.Generic;

    /// <summary>
    /// Nimbra Manager services table properties.
    /// </summary>
    public interface IManagerService
    {
        /// <summary>
        /// Get the key of the service.
        /// </summary>
        string Key { get; }

        /// <summary>
        /// Get the name of the service.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Get the ID of the service if it exists.
        /// </summary>
        DmsServiceId? DmsServiceId { get; }

        /// <summary>
        /// Get the ID of the source element.
        /// </summary>
        DmsElementId SourceNodeElementId { get; }

        /// <summary>
        /// Get the name of the source element.
        /// </summary>
        string ServiceSourceNode { get; }

        /// <summary>
        /// Get the channel ID.
        /// </summary>
        string ServiceChannelId { get; set; }

        /// <summary>
        /// Get the requested capacity in Mbps.
        /// </summary>
        double RequestedCapacityInMbps { get; }

        /// <summary>
        /// Get the reserved capacity in Mbps.
        /// </summary>
        double ReservedCapacityInMbps { get; }

        /// <summary>
        /// Get the operationalstate of the source TTP.
        /// </summary>
        ServiceOperationStatusManager OperationalState { get; }

        /// <summary>
        /// Get the Service Type.
        /// </summary>
        ServiceTypes ServiceType { get; }

        /// <summary>
        /// Get the source location.
        /// </summary>
        string SourceLocation { get; }

        /// <summary>
        /// Get the destinations.
        /// </summary>
        IEnumerable<IManagerServiceDestination> Destinations { get; }

        /// <summary>
        /// Get the destinations locations.
        /// </summary>
        IEnumerable<string> DestinationLocations { get; }

        /// <summary>
        /// Get the customer ID linked to the service.
        /// </summary>
        int CustomerId { get; }
    }
}