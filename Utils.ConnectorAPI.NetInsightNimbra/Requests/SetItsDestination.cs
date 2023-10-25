namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Requests
{
    using Newtonsoft.Json;
    using Skyline.DataMiner.Core.DataMinerSystem.Common;
    using Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Results;
    using System;

    /// <summary>
    /// Represents the request to set the settings for existing ITS on the NetInsight Nimbra destination device.
    /// </summary>
    public class SetItsDestination : BaseRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SetItsDestination"/> class.
        /// </summary>
        public SetItsDestination()
        {
            RequestType = RequestType.SetItsDestination;
        }

        /// <summary>
        /// Gets or sets the TTP source key associated with the ITS destination.
        /// </summary>
        [JsonProperty("TTP")]
        public string TtpSourceKey { get; set; }

        /// <summary>
        /// Gets or sets the DTM address for the ITS destination.
        /// </summary>
        [JsonProperty("DTM")]
        public string DtmAddress { get; set; }

        /// <summary>
        /// Gets or sets the DSTI identifying the ITS destination.
        /// </summary>
        [JsonProperty("DSTI")]
        public int DestinationDSTI { get; set; }

        /// <summary>
        /// Retrieves the DTM address from the manager in case the Manager and Node are located on the same DataMiner system.
        /// Ensure that the manager is configured before calling this method.
        /// </summary>
        /// <param name="thisDms">The IDms instance used to interact with the DataMiner system.</param>
        /// <param name="destinationNode">The destination node for which to obtain the DTM address.</param>
        /// <exception cref="MissingManagerException">Thrown when the Manager is not set for this request.</exception>
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
        /// Generates the result object for the SetItsDestination request.
        /// </summary>
        /// <param name="destinationKey">The key identifying the existing ITS in the destination node.</param>
        /// <param name="success">A boolean indicating the success status of the request.</param>
        /// <param name="errorMessage">An optional error message, if any, associated with the request.</param>
        /// <returns>An instance of the <see cref="SetItsDestinationResult"/> representing the result of the request.</returns>
        public IResult GetResult(string destinationKey, bool success, string errorMessage = null)
        {
            return new SetItsDestinationResult(Id, destinationKey, success, errorMessage);
        }
    }

}