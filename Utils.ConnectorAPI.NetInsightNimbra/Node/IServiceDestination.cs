namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra
{
    /// <summary>
    /// Represent the destination node of the NetInsight Nimbra service.
    /// </summary>
    public interface IServiceDestination
    {
        /// <summary>
        /// Get the key of the destination.
        /// </summary>
        string Key { get; }

        /// <summary>
        /// Get the name of the destination.
        /// </summary>
        string DstName { get; }

        /// <summary>
        /// Get the DSTI of the destination.
        /// </summary>
        string DstDsti { get; }

        /// <summary>
        /// Get the DTM address of the destination.
        /// </summary>
        string DstDtmAddress { get; }

        /// <summary>
        /// Get the key of the service.
        /// </summary>
        string ServiceKey { get; }

        /// <summary>
        /// Get the default channel.
        /// </summary>
        IServiceChannel DefaultChannel { get; }

        /// <summary>
        /// Get the protection channel.
        /// </summary>
        IServiceChannel ProtectionChannel { get; }

        /// <summary>
        /// Get whether there is a default channel.
        /// </summary>
        bool HasDefaultChannel { get; }

        /// <summary>
        /// Get whether there is a protection channel.
        /// </summary>
        bool HasProtectionChannel { get; }

        /// <summary>
        /// Get the operational status of the destination.
        /// </summary>
        DstOperationStatus DstOperStatus { get; }
    }
}