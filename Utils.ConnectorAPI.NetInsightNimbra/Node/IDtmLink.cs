namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra
{
    public interface IDtmLink
    {
        /// <summary>
        /// Get the key of the DTM link.
        /// </summary>
        string Key { get; }

        /// <summary>
        /// Get the IF MAC address of the DTM interface.
        /// For RX and TX links this will be for the interface on the other side of the link.
        /// </summary>
        string IfMacAddress { get; }

        /// <summary>
        /// Get the MAC address of the node.
        /// For RX and TX links this will be the node on the other side of the link.
        /// </summary>
        string NodeMacAddress { get; }

        /// <summary>
        /// Get the name of the DTM link.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Get the IF MAC address of the DTM interface.
        /// </summary>
        string LocalIfMacAddress { get; }

        /// <summary>
        /// The state of the row.
        /// Deleted means it is still present in DataMiner, but it is already deleted from the device.
        /// </summary>
        DataMinerSnmpRowStatus RowState { get; }

        /// <summary>
        /// The type of the link.
        /// </summary>
        DtmLinkTypes LinkType { get; }
    }
}