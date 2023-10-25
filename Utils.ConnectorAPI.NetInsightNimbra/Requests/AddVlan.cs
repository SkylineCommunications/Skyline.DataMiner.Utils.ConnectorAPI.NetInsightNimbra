namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Requests
{
    using Newtonsoft.Json;
    using Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Results;

    /// <summary>
    /// Represents the request to add VLAN membership in the NetInsight Nimbra device.
    /// </summary>
    public class AddVlan : BaseRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddVlan"/> class.
        /// </summary>
        public AddVlan()
        {
            RequestType = RequestType.AddVlanMembership;
        }

        /// <summary>
        /// Gets or sets an array of VLAN configurations.
        /// </summary>
        [JsonProperty("VLANs")]
        public Vlan[] Vlans { get; set; }

        /// <summary>
        /// Generates the result object for the AddVlan request.
        /// </summary>
        /// <param name="vlanKeys">An array of VLAN keys associated with the request.</param>
        /// <param name="success">A boolean indicating the success status of the request.</param>
        /// <param name="errorMessage">An optional error message, if any, associated with the request.</param>
        /// <returns>An instance of the <see cref="AddVlanResult"/> representing the result of the request.</returns>
        public IResult GetResult(string[] vlanKeys, bool success, string errorMessage = null)
        {
            return new AddVlanResult(Id, vlanKeys, success, errorMessage);
        }

        /// <summary>
        /// Represents a VLAN configuration in the AddVlan request.
        /// </summary>
        public class Vlan
        {
            /// <summary>
            /// Gets or sets an array of VLAN IDs.
            /// </summary>
            [JsonProperty("VLAN IDs")]
            public int[] VlanIds { get; set; }

            /// <summary>
            /// Gets or sets the customer ID associated with the VLAN.
            /// </summary>
            [JsonProperty("Customer ID")]
            public int CustomerId { get; set; }

            /// <summary>
            /// Gets or sets the purpose of the VLAN.
            /// </summary>
            [JsonProperty("Purpose")]
            public string Purpose { get; set; }

            /// <summary>
            /// Gets or sets the interface ID associated with the VLAN.
            /// </summary>
            [JsonProperty("If ID")]
            public string IfId { get; set; }
        }
    }

}