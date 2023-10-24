namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra
{
    using System.Collections.Generic;

    /// <summary>
    /// Represents an ITSTTP table row for the NetInsight Nimbra connector.
    /// </summary>
    public interface IEtsTtp
    {
        /// <summary>
        /// Gets the name or label associated with the ITSTTP entry.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Gets the unique identifier for the customer associated with this ITSTTP entry.
        /// </summary>
        int CustomerId { get; }

        /// <summary>
        /// Gets the purpose or description detailing the use or intent of this ITSTTP entry.
        /// </summary>
        string Purpose { get; }

        /// <summary>
        /// Gets the unique key or identifier associated with the forwarding functionality tied to this ITSTTP entry.
        /// </summary>
        string FwdFuncKey { get; }

        /// <summary>
        /// Gets the name or description of the forwarding functionality tied to this ITSTTP entry.
        /// </summary>
        string FwdFuncName { get; }

        /// <summary>
        /// Gets the DSTI (Destination Signal Transfer Point) information related to this ITSTTP entry.
        /// </summary>
        string Dsti { get; }

        /// <summary>
        /// Gets a collection of Ethernet interfaces associated with this ITSTTP entry.
        /// </summary>
        IEnumerable<IEthInterface> EthInterfaces { get; }
    }

}