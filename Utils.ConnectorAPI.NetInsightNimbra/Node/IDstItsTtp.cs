namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra
{
    /// <summary>
    /// Represents the DSTI ITS TTP attributes for a Nimbra node.
    /// </summary>
    public interface IDstItsTtp
    {
        /// <summary>
        /// Gets the name associated with the DSTI ITS TTP entry.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Gets the customer identifier associated with the DSTI ITS TTP entry.
        /// </summary>
        int CustomerId { get; }

        /// <summary>
        /// Gets the purpose or usage of the DSTI ITS TTP entry.
        /// </summary>
        string Purpose { get; }

        /// <summary>
        /// Gets the unique key of the interface associated with the DSTI ITS TTP entry.
        /// </summary>
        string InterfaceKey { get; }

        /// <summary>
        /// Gets the name of the interface associated with the DSTI ITS TTP entry.
        /// </summary>
        string InterfaceName { get; }

        /// <summary>
        /// Gets the DSTI value associated with the DSTI ITS TTP entry.
        /// </summary>
        string Dsti { get; }
    }
}