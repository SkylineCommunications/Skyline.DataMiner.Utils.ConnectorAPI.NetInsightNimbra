namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra
{
    using System;

    internal class ServiceChannel : IServiceChannel
    {
        internal ServiceChannel(object[] channelRow)
        {
            if (channelRow.Length < 15)
            {
                throw new ArgumentException($"ERROR|Channel row does not contain 14 columns: '" + string.Join("', '", channelRow) + "'", "channelRow");
            }

            Key = Convert.ToString(channelRow[0]);
            SrcRouteIndex = Convert.ToInt32(channelRow[1]);
            ServiceId = Convert.ToString(channelRow[2]);
            ErrorMessage = Convert.ToString(channelRow[3]);
            ErrorAddress = Convert.ToString(channelRow[4]);
            OperStatusHidden = (ChannelOperationStatusHidden)Convert.ToInt32(channelRow[5]);
            StatusChanged = Convert.ToInt32(channelRow[6]);
            ServiceKey = Convert.ToString(channelRow[8]);
            DestinationKey = Convert.ToString(channelRow[9]);
            ChannelId = Convert.ToString(channelRow[10]);
            ChannelOperStatus = (ChannelOperationStatus)Convert.ToInt32(channelRow[11]);
            SrcRouteNameValue = Convert.ToString(channelRow[12]);
            Purpose = Convert.ToString(channelRow[14]);
        }

        private static string ConvertSrcRouteName(string srcRouteName)
        {
            if (srcRouteName == "-1")
            {
                return "No Source Route";
            }
            else if (srcRouteName == "-2")
            {
                return "Unknown";
            }
            else
            {
                return srcRouteName;
            }
        }

        public string Key { get; private set; }

        public int SrcRouteIndex { get; private set; }

        public string ServiceId { get; private set; }

        public string ErrorMessage { get; private set; }

        public string ErrorAddress { get; private set; }

        public ChannelOperationStatusHidden OperStatusHidden { get; private set; }

        public int StatusChanged { get; private set; }

        public string ServiceKey { get; private set; }

        public string DestinationKey { get; private set; }

        public string ChannelId { get; private set; }

        public ChannelOperationStatus ChannelOperStatus { get; private set; }

        public string SrcRouteNameValue { get; private set; }

        public string Purpose { get; private set; }

        public string SrcRouteName => ConvertSrcRouteName(SrcRouteNameValue);
    }
}