namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra
{
    using System;

    internal class DstItsTtp : IDstItsTtp
    {
        internal DstItsTtp(object[] ttpRow)
        {
            if (ttpRow.Length < 29)
            {
                throw new ArgumentException($"ERROR|Sink ITS TTP row does not contain 29 columns: '" + string.Join("', '", ttpRow) + "'", "ttpRow");
            }

            Name = Convert.ToString(ttpRow[1]);
            Purpose = Convert.ToString(ttpRow[2]);
            InterfaceKey = Convert.ToString(ttpRow[3]);
            Dsti = Convert.ToString(ttpRow[4]);
            InterfaceName = Convert.ToString(ttpRow[9]);
            if (ttpRow.Length > 29)
            {
                CustomerId = Convert.ToInt32(ttpRow[28]);
            }
        }

        public string Name { get; private set; }

        public string Purpose { get; private set; }

        public string InterfaceKey { get; private set; }

        public string InterfaceName { get; private set; }

        public string Dsti { get; private set; }

        public int CustomerId { get; private set; }
    }
}