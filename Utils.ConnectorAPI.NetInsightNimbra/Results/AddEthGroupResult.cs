namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Results
{
    using Newtonsoft.Json;
    using System;

    /// <summary>
    /// Represents the result after adding the ETH Group
    /// </summary>
    public class AddEthGroupResult : BaseResult
    {
        public AddEthGroupResult(Guid id, string groupKey, string groupId, bool success, string error = null)
        {
            this.Id = id;
            this.Success = success;
            this.Error = error;
            this.GroupKey = groupKey;
            this.GroupID = groupId;
            this.RequestType = Requests.RequestType.AddEthGroup;
        }

        /// <summary>
        /// Represents the unique identifier of the group.
        /// </summary>
        [JsonProperty("Group Key")]
        public string GroupKey { get; set; }

        /// <summary>
        /// Represents the ID of the ETH group.
        /// </summary>
        [JsonProperty("Group ID")]
        public string GroupID { get; set; }
    }
}