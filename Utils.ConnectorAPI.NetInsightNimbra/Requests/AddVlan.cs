namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Requests
{
    using Newtonsoft.Json;
    using Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Results;

    public class AddVlan : BaseRequest
    {
        public AddVlan()
        {
            RequestType = RequestType.AddVlanMembership;
        }

        [JsonProperty("VLANs")]
        public Vlan[] Vlans { get; set; }

        public IResult GetResult(string[] vlanKeys, bool success, string errorMessage = null)
        {
            return new AddVlanResult(Id, vlanKeys, success, errorMessage);
        }

        public class Vlan
        {
            [JsonProperty("VLAN IDs")]
            public int[] VlanIds { get; set; }

            [JsonProperty("Customer ID")]
            public int CustomerId { get; set; }

            [JsonProperty("Purpose")]
            public string Purpose { get; set; }

            [JsonProperty("If ID")]
            public string IfId { get; set; }
        }
    }
}