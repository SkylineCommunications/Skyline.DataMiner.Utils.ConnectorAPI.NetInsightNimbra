namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra
{
    /// <summary>
    /// Represents an Ethernet interface table row for the NetInsight Nimbra connector.
    /// </summary>
    public interface IEthInterface
    {
        /// <summary>
        /// Gets the name associated with the Ethernet interface.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Gets the administrative state of the Ethernet interface, which can indicate whether the interface is up, down, or in another state.
        /// </summary>
        AdminState AdminState { get; }

        /// <summary>
        /// Gets the unique key or identifier associated with the forwarding functionality tied to this Ethernet interface.
        /// </summary>
        string FwdFuncKey { get; }

        /// <summary>
        /// Gets the name or description of the forwarding functionality tied to this Ethernet interface.
        /// </summary>
        string FwdFuncName { get; }
    }
}