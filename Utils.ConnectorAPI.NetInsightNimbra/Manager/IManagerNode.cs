namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra
{
    using Skyline.DataMiner.Core.DataMinerSystem.Common;

    /// <summary>
    /// NetInsight Manager Node properties.
    /// </summary>
    public interface IManagerNode
    {
        /// <summary>
        /// The DataMiner ID of the node.
        /// </summary>
        DmsElementId ElementId { get; }

        /// <summary>
        /// The name of the node.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// The system name of the node.
        /// </summary>
        string SystemName { get; }

        /// <summary>
        /// The system location of the node.
        /// </summary>
        string SystemLocation { get; }

        /// <summary>
        /// The location of the node.
        /// </summary>
        string Location { get; }

        /// <summary>
        /// The continent of the node.
        /// </summary>
        string Continent { get; }

        /// <summary>
        /// The DTM address of the node.
        /// </summary>
        string DtmAddress { get; }

        /// <summary>
        /// The MAC address of the node.
        /// </summary>
        string MacAddress { get; }

        /// <summary>
        /// The IP address of the node.
        /// </summary>
        string IpAddress { get; }

        /// <summary>
        /// The software version of the node.
        /// </summary>
        string SoftwareVersion { get; }
    }
}