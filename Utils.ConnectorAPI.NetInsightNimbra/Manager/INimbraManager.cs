namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra
{
    using Skyline.DataMiner.Core.DataMinerSystem.Common;
    using Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Requests;
    using Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Results;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the Nimbra Manager.
    /// </summary>
    public interface INimbraManager
    {
        /// <summary>
        /// Gets or sets whether data should be cached in memory.
        /// </summary>
        bool Caching { get; set; }

        /// <summary>
        /// Get the DataMiner element.
        /// </summary>
        IDmsElement Element { get; }

        /// <summary>
        /// Get the services.
        /// </summary>
        IEnumerable<IManagerService> Services { get; }

        /// <summary>
        /// Get the customers.
        /// </summary>
        IEnumerable<ICustomer> Customers { get; }

        /// <summary>
        /// Get the nodes.
        /// </summary>
        IReadOnlyDictionary<DmsElementId, IManagerNode> Nodes { get; }

        /// <summary>
        /// Get the node that has a specific DTM address.
        /// </summary>
        /// <param name="dtmAddress">The DTM address.</param>
        /// <returns>The node with the specific DTM address.</returns>
        bool TryGetNodeForDtm(string dtmAddress, out IManagerNode node);

        /// <summary>
        /// Send a request to the manager.
        /// </summary>
        /// <param name="request">The request that needs to be handled.</param>
        void SendRequestToManager(IRequest request);

        /// <summary>
        /// Send a response to the manager.
        /// Should only be used by the Nimbra nodes.
        /// </summary>
        /// <param name="response"></param>
        void SendResponseToManager(IResult response);
    }
}