namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Results
{
    using Newtonsoft.Json;
    using System;

    /// <summary>
    /// Represents the result after adding the Ethernet Group.
    /// </summary>
    public class AddEthGroupResult : BaseResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddEthGroupResult"/> class.
        /// </summary>
        /// <param name="id">The unique identifier of the result.</param>
        /// <param name="groupKey">The unique identifier of the group.</param>
        /// <param name="groupId">The ID of the Ethernet group.</param>
        /// <param name="success">A value indicating whether the operation was successful.</param>
        /// <param name="error">An error message, if applicable.</param>
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
        /// Gets or sets the unique identifier of the group.
        /// </summary>
        [JsonProperty("Group Key")]
        public string GroupKey { get; set; }

        /// <summary>
        /// Gets or sets the ID of the Ethernet group.
        /// </summary>
        [JsonProperty("Group ID")]
        public string GroupID { get; set; }
    }

}