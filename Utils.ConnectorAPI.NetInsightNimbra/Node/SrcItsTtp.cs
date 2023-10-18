namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra
{
    using System;

    internal class SrcItsTtp : ISrcItsTtp
    {
        internal SrcItsTtp(object[] ttpRow)
        {
            if (ttpRow.Length < 25)
            {
                throw new ArgumentException($"ERROR|Service row does not contain 25 columns: '" + string.Join("', '", ttpRow) + "'", "ttpRow");
            }

            Name = Convert.ToString(ttpRow[2]);
            CustomerId = Convert.ToInt32(ttpRow[3]);
            Purpose = Convert.ToString(ttpRow[4]);
            InterfaceKey = Convert.ToString(ttpRow[5]);
            Dsti = Convert.ToString(ttpRow[6]);
            InterfaceName = Convert.ToString(ttpRow[14]);
        }

        public string Name { get; private set; }

        public int CustomerId { get; private set; }

        public string Purpose { get; private set; }

        public string InterfaceKey { get; private set; }

        public string InterfaceName { get; private set; }

        public string Dsti { get; private set; }
    }
}