namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra
{
    using Skyline.DataMiner.Core.DataMinerSystem.Common;
    using Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Node;
    using Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Requests;
    using Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Results;
    using System.Collections.Generic;

    public interface INimbraNode
    {
        /// <summary>
        /// Get the system name of the node.
        /// </summary>
        string SystemName { get; }

        /// <summary>
        /// Get the local MAC address of the node.
        /// </summary>
        string LocalMacAddress { get; }

        /// <summary>
        /// Get the local DTM address of the node.
        /// </summary>
        string LocalDtmAddress { get; }

        /// <summary>
        /// Get the DataMiner element of the node.
        /// </summary>
        IDmsElement Element { get; }

        /// <summary>
        /// Get the channels of the node.
        /// </summary>
        IEnumerable<IChannel> Channels { get; }

        /// <summary>
        /// Get the DTM interfaces of the node.
        /// </summary>
        IEnumerable<IDtmInterface> DtmInterfaces { get; }

        /// <summary>
        /// Get the DTM links of the node. Deleted rows are not returned.
        /// </summary>
        IEnumerable<IDtmLink> DtmLinks { get; }

        /// <summary>
        /// Get the services that originate on this node.
        /// </summary>
        IEnumerable<INodeService> Services { get; }

        /// <summary>
        /// Get the Ethernet interfaces on this node.
        /// </summary>
        IEnumerable<IEthInterface> EthInterfaces { get; }

        /// <summary>
        /// Get the Ethernet devices on this node.
        /// </summary>
        IEnumerable<IEthDevice> EthDevices { get; }

        /// <summary>
        /// Get the source TTPs for ITS by DSTI.
        /// </summary>
        IReadOnlyDictionary<string, ISrcItsTtp> SrcItsTtps { get; }

        /// <summary>
        /// Get the destination TTPs for ITS by DSTI.
        /// </summary>
        IReadOnlyDictionary<string, IDstItsTtp> DstItsTtps { get; }

        /// <summary>
        /// Get the ETS TTPs by DSTI.
        /// </summary>
        IReadOnlyDictionary<string, IEtsTtp> EtsTtps { get; }

        /// <summary>
        /// Send a request to the node.
        /// </summary>
        /// <param name="request">The request.</param>
        void SendRequestToNode(IRequest request);

        /// <summary>
        /// Send a request to the node and wait on the response returned by the manager.
        /// </summary>
        /// <param name="dms">The DataMiner system.</param>
        /// <param name="request">The request.</param>
        /// <param name="timeoutInMilliSeconds">The timeout time in ms.</param>
        /// <param name="pauseInMilliSeconds">The pause time between checks in ms.</param>
        /// <returns>The response of the manager.</returns>
        IResult SendRequestAndGetResultFromManager(IDms dms, IRequest request, int timeoutInMilliSeconds = 60000, int pauseInMilliSeconds = 200);
    }
}