namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra
{
    using System;
    using System.Collections.Generic;

    internal class ServiceDestination : IServiceDestination
    {
        internal ServiceDestination(object[] destinationRow, Dictionary<string, ServiceChannel> serviceChannels)
        {
            if (destinationRow.Length < 6)
            {
                throw new ArgumentException($"ERROR|Destination row does not contain 6 columns: '" + string.Join("', '", destinationRow) + "'", "destinationRow");
            }

            Key = Convert.ToString(destinationRow[0]);
            DstDtmAddress = Convert.ToString(destinationRow[1]);
            DstDsti = Convert.ToString(destinationRow[2]);
            ServiceKey = Convert.ToString(destinationRow[3]);
            DstName = Convert.ToString(destinationRow[4]);
            DstOperStatus = (DstOperationStatus)Convert.ToInt32(destinationRow[5]);

            // Populate DefaultChannel and ProtectionChannel properties based on the related channels
            if (serviceChannels.ContainsKey(Key + ".1"))
            {
                HasDefaultChannel = true;
                DefaultChannel = serviceChannels[Key + ".1"];
            }

            if (serviceChannels.ContainsKey(Key + ".2"))
            {
                HasProtectionChannel = true;
                ProtectionChannel = serviceChannels[Key + ".2"];
            }
        }

        public string Key { get; private set; }

        public string DstName { get; private set; }

        public string DstDsti { get; private set; }

        public string DstDtmAddress { get; private set; }

        public DstOperationStatus DstOperStatus { get; private set; }

        public string ServiceKey { get; private set; }

        public IServiceChannel DefaultChannel { get; private set; }

        public IServiceChannel ProtectionChannel { get; private set; }

        public bool HasDefaultChannel { get; private set; }

        public bool HasProtectionChannel { get; private set; }
    }
}