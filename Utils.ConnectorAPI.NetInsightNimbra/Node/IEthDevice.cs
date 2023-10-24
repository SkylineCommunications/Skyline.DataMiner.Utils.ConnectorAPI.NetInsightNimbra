namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Node
{
    /// <summary>
    /// Represents an Ethernet device row for the NetInsight Nimbra connector.
    /// </summary>
    public interface IEthDevice
    {
        /// <summary>
        /// Gets the unique key or identifier for the Ethernet device.
        /// </summary>
        string DeviceKey { get; }

        /// <summary>
        /// Gets the current status of the row in the table.
        /// </summary>
        RowStatus RowStatus { get; }

        /// <summary>
        /// Gets the name or label associated with the Ethernet device.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Gets the name of the container or parent grouping for the device, providing hierarchical or organizational context.
        /// </summary>
        string ContainerName { get; }

        /// <summary>
        /// Gets the name of the product related to the Ethernet device, indicating the make or model of the device or related hardware.
        /// </summary>
        string ProductName { get; }

        /// <summary>
        /// Gets the operational status of the Ethernet device.
        /// </summary>
        DeviceStatus Status { get; }
    }
}