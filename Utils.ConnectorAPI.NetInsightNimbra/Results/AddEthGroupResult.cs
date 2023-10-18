namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Results
{
    using Newtonsoft.Json;
    using System;

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

        [JsonProperty("Group Key")]
        public string GroupKey { get; set; }

        [JsonProperty("Group ID")]
        public string GroupID { get; set; }
    }
}