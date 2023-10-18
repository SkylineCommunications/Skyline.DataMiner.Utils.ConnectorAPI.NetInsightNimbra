namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra
{
    public interface IChannel
    {
        /// <summary>
        /// Get the key of the channel.
        /// </summary>
        string Key { get; }

        /// <summary>
        /// Get the service ID of the channel.
        /// </summary>
        string ServiceId { get; }

        /// <summary>
        /// Get the DTM name where the channel enters.
        /// If the channel originates from this node, then the value will be 'origin'.
        /// </summary>
        string DtmIn { get; }

        /// <summary>
        /// Get the DTM key where the channel enters.
        /// If the channel originates from this node, then the value will be '-1'.
        /// </summary>
        string DtmInKey { get; }

        /// <summary>
        /// Get the DTM name where the channel leaves.
        /// If the channel ends in this node, then the value will be 'end'.
        /// </summary>
        string DtmOut { get; }

        /// <summary>
        /// Get the DTM key where the channel leaves.
        /// If the channel ends ind this node, then the value will be '-1'.
        /// </summary>
        string DtmOutKey { get; }

        /// <summary>
        /// Get name of the node where the channel originates.
        /// </summary>
        string ServiceSourceNode { get; }
    }
}