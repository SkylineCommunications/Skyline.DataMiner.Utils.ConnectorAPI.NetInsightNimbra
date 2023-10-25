namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Requests
{
    using Newtonsoft.Json;

    /// <summary>
    /// Represents the connection settings for a TTP in the NetInsight Nimbra device.
    /// </summary>
    public class TtpConnectionSettings
    {
        /// <summary>
        /// Gets or sets the acceptable bitrate for the TTP connection.
        /// </summary>
        [JsonProperty("Accept Bitrate")]
        public ulong AcceptableBitrate { get; set; }

        /// <summary>
        /// Gets or sets the requested bitrate for the TTP connection.
        /// </summary>
        [JsonProperty("Request Bitrate")]
        public ulong RequestedBitrate { get; set; }

        /// <summary>
        /// Gets or sets the reestablishment method for the TTP connection.
        /// </summary>
        [JsonProperty("Reestablish")]
        public ReestablishMethod ReestablishMethod { get; set; }

        /// <summary>
        /// Gets or sets the minimum interval for the TTP connection.
        /// </summary>
        [JsonProperty("Min Interval")]
        public int MinimumInterval { get; set; }

        /// <summary>
        /// Gets or sets the maximum interval for the TTP connection.
        /// </summary>
        [JsonProperty("Max Interval")]
        public int MaximumInterval { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the TTP connection is established.
        /// </summary>
        [JsonProperty("Connection Established")]
        public TruthValue ConnectionEstablished { get; set; }

        /// <summary>
        /// Gets or sets a value indicating the channel precedence for the TTP connection.
        /// </summary>
        [JsonProperty("Channel Precedence")]
        public TruthValue ChannelPrecedence { get; set; }

        /// <summary>
        /// Gets or sets the number of alarms to be suppressed for the TTP connection.
        /// </summary>
        [JsonProperty("Suppress Alarms")]
        public int SuppressAlarms { get; set; }
    }

}