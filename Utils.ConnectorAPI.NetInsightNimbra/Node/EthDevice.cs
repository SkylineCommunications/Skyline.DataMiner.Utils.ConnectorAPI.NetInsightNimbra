namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Node
{
    using System;

    internal class EthDevice : IEthDevice
    {
        private const int ColNumber = 26;

        internal EthDevice(object[] ethDeviceRow)
        {
            if (ethDeviceRow.Length < ColNumber)
            {
                throw new ArgumentException($"ERROR|ETH Device row does not contain {ColNumber} columns: '" + string.Join("', '", ethDeviceRow) + "'", "ethDeviceRow");
            }

            this.DeviceKey = Convert.ToString(ethDeviceRow[0]);
            this.RowStatus = (RowStatus)Convert.ToInt32(ethDeviceRow[1]);
            this.Name = Convert.ToString(ethDeviceRow[2]);
            this.ContainerName = Convert.ToString(ethDeviceRow[3]);
            this.ProductName = Convert.ToString(ethDeviceRow[4]);
            this.Status = (DeviceStatus)Convert.ToInt32(ethDeviceRow[5]);
        }

        public string DeviceKey { get; private set; }

        public RowStatus RowStatus { get; private set; }

        public string Name { get; private set; }

        public string ContainerName { get; private set; }

        public string ProductName { get; private set; }

        public DeviceStatus Status { get; private set; }
    }
}