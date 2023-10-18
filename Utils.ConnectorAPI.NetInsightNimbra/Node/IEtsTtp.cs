namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra
{
    using System.Collections.Generic;

    public interface IEtsTtp
    {
        string Name { get; }

        int CustomerId { get; }

        string Purpose { get; }

        string FwdFuncKey { get; }

        string FwdFuncName { get; }

        string Dsti { get; }

        IEnumerable<IEthInterface> EthInterfaces { get; }
    }
}