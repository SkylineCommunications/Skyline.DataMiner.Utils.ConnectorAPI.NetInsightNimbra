namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra
{
    public interface IServiceChannel
    {
        /// <summary>
        /// Get the key of the channel.
        /// </summary>
        string Key { get; }

        /// <summary>
        /// Get the source route index of the channel.
        /// </summary>
        int SrcRouteIndex { get; }

        /// <summary>
        /// Get the id of the service.
        /// </summary>
        string ServiceId { get; }

        /// <summary>
        /// Get the error message of the channel.
        /// </summary>
        string ErrorMessage { get; }

        /// <summary>
        /// Get the error address of the channel.
        /// </summary>
        string ErrorAddress { get; }

        /// <summary>
        /// Get the hidden operational status of the channel.
        /// </summary>
        ChannelOperationStatusHidden OperStatusHidden { get; }

        /// <summary>
        /// Get the sysUpTime when the status of the channel to the destination was last established or torn down.
        /// </summary>
        int StatusChanged { get; }

        /// <summary>
		/// Get the key of the service.
		/// </summary>
		string ServiceKey { get; }

        /// <summary>
        /// Get the key of the destination.
        /// </summary>
        string DestinationKey { get; }

        /// <summary>
        /// Get the channel Id which contains 1 for the default channel or 2 for the protection channel.
        /// </summary>
        string ChannelId { get; }

        /// <summary>
        /// Get the operational status of the channel.
        /// </summary>
        ChannelOperationStatus ChannelOperStatus { get; }

        /// <summary>
        /// Get the source route name of the channel.
        /// </summary>
        string SrcRouteNameValue { get; }

        /// <summary>
        /// Get the purpose defined on the source TTP for the associated service.
        /// </summary>
        string Purpose { get; }

        /// <summary>
        /// Get the source route name (display value). For the actual value use <see cref="SrcRouteNameValue"/>.
        /// </summary>
		string SrcRouteName { get; }
    }
}