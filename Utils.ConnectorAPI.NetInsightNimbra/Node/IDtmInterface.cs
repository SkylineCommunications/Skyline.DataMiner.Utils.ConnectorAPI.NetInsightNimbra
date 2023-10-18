namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra
{
    public interface IDtmInterface
    {
        /// <summary>
        /// Get the key of the DTM interface.
        /// </summary>
        string Key { get; }

        /// <summary>
        /// Get the name of the DTM interface.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Get the TX capacity of the DTM interface in Mbps.
        /// </summary>
        double TxCapacityInMbps { get; }

        /// <summary>
        /// Get the TX usage of the DTM interface in Mbps.
        /// </summary>
        double TxCapacityUsedInMbps { get; }

        /// <summary>
        /// Get the purpose of the DTM interface.
        /// </summary>
        string Purpose { get; }

        /// <summary>
        /// Get the TX usage of the DTM interface in percentage.
        /// </summary>
        double TxUsage { get; }

        /// <summary>
        /// Get the MAC address of the DTM interface.
        /// </summary>
        string MacAddress { get; }
    }
}