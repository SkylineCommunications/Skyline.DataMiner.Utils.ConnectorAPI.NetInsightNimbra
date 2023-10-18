namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra
{
    using System;

    internal class Channel : IChannel
    {
        internal Channel(object[] channelrow)
        {
            if (channelrow.Length < 30)
            {
                throw new ArgumentException($"ERROR|Channel row does not contain 30 columns: '" + string.Join("', '", channelrow) + "'", "channelrow");
            }

            Key = Convert.ToString(channelrow[0]);
            ServiceId = Convert.ToString(channelrow[13]);
            DtmIn = Convert.ToString(channelrow[11]);
            DtmOut = Convert.ToString(channelrow[12]);
            DtmInKey = Convert.ToString(channelrow[26]);
            DtmOutKey = Convert.ToString(channelrow[27]);
            ServiceSourceNode = Convert.ToString(channelrow[10]);
        }

        public string Key { get; private set; }

        public string ServiceId { get; private set; }

        public string DtmIn { get; private set; }

        public string DtmOut { get; private set; }

        public string DtmInKey { get; private set; }

        public string DtmOutKey { get; private set; }

        public string ServiceSourceNode { get; private set; }
    }
}