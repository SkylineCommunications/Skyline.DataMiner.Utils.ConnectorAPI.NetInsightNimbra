namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra
{
    /// <summary>
    /// Represents a Source ITS TTP configuration for the NetInsight Nimbra device.
    /// </summary>
    public interface ISrcItsTtp
    {
        /// <summary>
        /// Gets the name or label associated with the Source ITS TTP.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Gets the unique identifier for the customer associated with this Source ITS TTP configuration.
        /// </summary>
        int CustomerId { get; }

        /// <summary>
        /// Gets the purpose or description that details the use or intent of this Source ITS TTP within the Nimbra device.
        /// </summary>
        string Purpose { get; }

        /// <summary>
        /// Gets the unique key or identifier associated with the interface related to this Source ITS TTP configuration.
        /// </summary>
        string InterfaceKey { get; }

        /// <summary>
        /// Gets the name or description of the interface connected or related to this Source ITS TTP on the Nimbra device.
        /// </summary>
        string InterfaceName { get; }

        /// <summary>
        /// Gets the DSTI (Destination Signal Transfer Point) information, which specifies the routing or targeting details for this Source ITS TTP.
        /// </summary>
        string Dsti { get; }
    }
}