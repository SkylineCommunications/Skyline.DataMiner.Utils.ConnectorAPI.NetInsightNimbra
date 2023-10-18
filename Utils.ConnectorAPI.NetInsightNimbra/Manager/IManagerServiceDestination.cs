namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Manager
{
    /// <summary>
    /// The destination on the service in the manager.
    /// </summary>
    public interface IManagerServiceDestination
    {
        /// <summary>
        /// The node of the destination.
        /// </summary>
        IManagerNode Node { get; }

        /// <summary>
        /// The DSTI of the destination.
        /// </summary>
        string Dsti { get; }
    }
}