namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Requests
{
    using Newtonsoft.Json;

    public class TtpConnectionSettings
    {
        [JsonProperty("Accept Bitrate")]
        public ulong AcceptableBitrate { get; set; }

        [JsonProperty("Request Bitrate")]
        public ulong RequestedBitrate { get; set; }

        [JsonProperty("Reestablish")]
        public ReestablishMethod ReestablishMethod { get; set; }

        [JsonProperty("Min Interval")]
        public int MinimumInterval { get; set; }

        [JsonProperty("Max Interval")]
        public int MaximumInterval { get; set; }

        [JsonProperty("Connection Established")]
        public TruthValue ConnectionEstablished { get; set; }

        [JsonProperty("Channel Precedence")]
        public TruthValue ChannelPrecedence { get; set; }

        [JsonProperty("Suppress Alarms")]
        public int SuppressAlarms { get; set; }
    }
}