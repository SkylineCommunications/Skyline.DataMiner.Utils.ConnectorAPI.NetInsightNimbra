namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Requests
{
    using Newtonsoft.Json;
    using Skyline.DataMiner.Core.DataMinerSystem.Common;
    using Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Results;
    using System;

    /// <summary>
    /// Represents the request to set existing ETS settings on the NetInsight Nimbra destination device.
    /// </summary>
    public class SetEtsDestination : BaseRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SetEtsDestination"/> class.
        /// </summary>
        public SetEtsDestination()
        {
            RequestType = RequestType.SetEtsDestination;
        }

        /// <summary>
        /// Gets or sets the TTP  key associated with the source of the ETS.
        /// </summary>
        [JsonProperty("TTP")]
        public string TtpSourceKey { get; set; }

        /// <summary>
        /// Gets or sets the DTM address to which the ETS traffic is directed.
        /// </summary>
        [JsonProperty("DTM")]
        public string DtmAddress { get; set; }

        /// <summary>
        /// Gets or sets the destination DSTI for the ETS traffic.
        /// </summary>
        [JsonProperty("DSTI")]
        public int DestinationDSTI { get; set; }

        /// <summary>
        /// Can only be used to find the DTM address in case the Manager and Node are located on the same DataMiner system.
        /// Make sure to first configure the manager prior to calling this method.
        /// </summary>
        /// <param name="thisDms">The DMS (DataMiner System) class.</param>
        /// <param name="destinationNode">The destination node for which to retrieve the DTM address.</param>
        public void GetDtmAddressFromManager(IDms thisDms, DmsElementId destinationNode)
        {
            if (!Manager.HasValue)
            {
                throw new MissingManagerException();
            }

            var nodeTable = thisDms.GetElement(Manager.Value).GetTable(1000);
            var row = nodeTable.GetRow(destinationNode.Value);
            this.DtmAddress = Convert.ToString(row[2]);
        }

        /// <summary>
        /// Generates the result object for the SetEtsDestination request.
        /// </summary>
        /// <param name="destinationKey">The key identifying the ETS in the destination node.</param>
        /// <param name="success">A boolean indicating the success status of the request.</param>
        /// <param name="errorMessage">An optional error message, if any, associated with the request.</param>
        /// <returns>An instance of the <see cref="SetEtsDestinationResult"/> representing the result of the request.</returns>
        public IResult GetResult(string destinationKey, bool success, string errorMessage = null)
        {
            return new SetEtsDestinationResult(Id, destinationKey, success, errorMessage);
        }
    }

}