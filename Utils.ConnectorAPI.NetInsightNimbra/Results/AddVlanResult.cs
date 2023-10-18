namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Results
{
    using Newtonsoft.Json;
    using System;

    public class AddVlanResult : BaseResult
    {
        public AddVlanResult(Guid id, string[] vlanKeys, bool success, string error = null)
        {
            this.Id = id;
            this.Success = success;
            this.Error = error;
            this.VlanKeys = vlanKeys;
            this.RequestType = Requests.RequestType.AddVlanMembership;
        }

        [JsonProperty("VLAN Keys")]
        public string[] VlanKeys { get; set; }
    }
}