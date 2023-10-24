namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra
{
    using System;

    internal class EthInterface : IEthInterface
    {
        internal EthInterface(object[] interfRow)
        {
            if (interfRow.Length < 71)
            {
                throw new ArgumentException($"ERROR|Interface ETH row does not contain 71 columns: '" + string.Join("', '", interfRow) + "'", "interfRow");
            }

            Name = Convert.ToString(interfRow[18]);
            AdminState = (AdminState)Convert.ToInt32(interfRow[22]);
            FwdFuncKey = Convert.ToString(interfRow[25]);
            FwdFuncName = Convert.ToString(interfRow[60]);
        }

        public string Name { get; private set; }

        public AdminState AdminState { get; private set; }

        public string FwdFuncKey { get; private set; }

        public string FwdFuncName { get; private set; }
    }
}