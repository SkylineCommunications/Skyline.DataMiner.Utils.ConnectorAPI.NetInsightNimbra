namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class EtsTtp : IEtsTtp
    {
        private readonly NimbraNode node;

        internal EtsTtp(NimbraNode node, object[] ttpRow)
        {
            if (ttpRow.Length < 60)
            {
                throw new ArgumentException($"ERROR|Service row does not contain 60 columns: '" + string.Join("', '", ttpRow) + "'", "ttpRow");
            }

            this.node = node;
            Name = Convert.ToString(ttpRow[15]);
            Purpose = Convert.ToString(ttpRow[18]);
            CustomerId = Convert.ToInt32(ttpRow[17]);
            Dsti = Convert.ToString(ttpRow[3]);
            FwdFuncKey = Convert.ToString(ttpRow[22]);
            FwdFuncName = Convert.ToString(ttpRow[57]);
        }

        public string Name { get; private set; }

        public int CustomerId { get; private set; }

        public string Purpose { get; private set; }

        public string FwdFuncKey { get; private set; }

        public string FwdFuncName { get; private set; }

        public string Dsti { get; private set; }

        public IEnumerable<IEthInterface> EthInterfaces
        {
            get
            {
                if (FwdFuncName == "-1")
                {
                    return new IEthInterface[0];
                }

                return node.EthInterfaces.Where(i => i.FwdFuncName == FwdFuncName);
            }
        }
    }
}