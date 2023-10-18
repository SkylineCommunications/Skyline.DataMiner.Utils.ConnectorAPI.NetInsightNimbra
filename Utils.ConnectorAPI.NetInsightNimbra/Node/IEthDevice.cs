namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Node
{
    public interface IEthDevice
    {
        string DeviceKey { get; }

        RowStatus RowStatus { get; }

        string Name { get; }

        string ContainerName { get; }

        string ProductName { get; }

        DeviceStatus Status { get; }
    }
}