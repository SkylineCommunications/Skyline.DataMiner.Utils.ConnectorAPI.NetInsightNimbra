namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra
{
    using Skyline.DataMiner.Core.DataMinerSystem.Common;
    using System;

    internal class ManagerNode : IManagerNode
    {
        internal ManagerNode(object[] nodeRow)
        {
            if (nodeRow.Length < 21)
            {
                throw new ArgumentException($"ERROR|Node row does not contain 21 columns: '" + string.Join("', '", nodeRow) + "'", "nodeRow");
            }

            ElementId = new DmsElementId(Convert.ToString(nodeRow[0]));
            Name = Convert.ToString(nodeRow[1]);
            DtmAddress = Convert.ToString(nodeRow[2]);
            MacAddress = Convert.ToString(nodeRow[3]);
            SystemName = Convert.ToString(nodeRow[4]);
            SystemLocation = Convert.ToString(nodeRow[13]);
            Location = Convert.ToString(nodeRow[14]);
            Continent = Convert.ToString(nodeRow[15]);
            IpAddress = Convert.ToString(nodeRow[16]);
            SoftwareVersion = Convert.ToString(nodeRow[17]);
        }

        public DmsElementId ElementId { get; private set; }

        public string Name { get; private set; }

        public string SystemName { get; private set; }

        public string SystemLocation { get; private set; }

        public string Location { get; private set; }

        public string Continent { get; private set; }

        public string DtmAddress { get; private set; }

        public string MacAddress { get; private set; }

        public string IpAddress { get; private set; }

        public string SoftwareVersion { get; private set; }
    }
}