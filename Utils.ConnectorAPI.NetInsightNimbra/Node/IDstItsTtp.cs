namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra
{
    public interface IDstItsTtp
    {
        string Name { get; }

        int CustomerId { get; }

        string Purpose { get; }

        string InterfaceKey { get; }

        string InterfaceName { get; }

        string Dsti { get; }
    }
}