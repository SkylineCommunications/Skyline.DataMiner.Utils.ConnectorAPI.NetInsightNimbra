namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Requests
{
    using Newtonsoft.Json;
    using Skyline.DataMiner.Core.DataMinerSystem.Common;
    using Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Results;
    using System;

    public class SetEtsDestination : BaseRequest
    {
        public SetEtsDestination()
        {
            RequestType = RequestType.SetEtsDestination;
        }

        [JsonProperty("TTP")]
        public string TtpSourceKey { get; set; }

        [JsonProperty("DTM")]
        public string DtmAddress { get; set; }

        [JsonProperty("DSTI")]
        public int DestinationDSTI { get; set; }

        /// <summary>
        /// Can only be used to find the DTM address in case the Manager and Node is located on the same DataMiner system.
        /// Make sure to first configure the manager prior to calling this method.
        /// </summary>
        /// <param name="thisDms">The dms class.</param>
        /// <param name="destinationNode">The destination node.</param>
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

        public IResult GetResult(string destinationKey, bool success, string errorMessage = null)
        {
            return new SetEtsDestinationResult(Id, destinationKey, success, errorMessage);
        }
    }
}