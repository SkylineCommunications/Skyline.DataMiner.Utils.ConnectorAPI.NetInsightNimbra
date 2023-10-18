namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra
{
    public interface IEthInterface
    {
        string Name { get; }

        AdminState AdminState { get; }

        string FwdFuncKey { get; }

        string FwdFuncName { get; }
    }
}