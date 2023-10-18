namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Manager
{
    internal class ManagerServiceDestination : IManagerServiceDestination
    {
        public ManagerServiceDestination(IManagerNode node, string dsti)
        {
            Node = node;
            Dsti = dsti;
        }

        public IManagerNode Node { get; private set; }

        public string Dsti { get; private set; }
    }
}