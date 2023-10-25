namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Results
{
    using Newtonsoft.Json;
    using System;

    /// <summary>
    /// Represents the result of an Add VLAN Membership request sent to the NetInsight Nimbra device.
    /// </summary>
    public class AddVlanResult : BaseResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddVlanResult"/> class.
        /// </summary>
        /// <param name="id">The unique identifier for the result.</param>
        /// <param name="vlanKeys">An array of VLAN keys associated with the result.</param>
        /// <param name="success">A flag indicating the success of the operation.</param>
        /// <param name="error">An optional error message if the operation was not successful.</param>
        public AddVlanResult(Guid id, string[] vlanKeys, bool success, string error = null)
        {
            this.Id = id;
            this.Success = success;
            this.Error = error;
            this.VlanKeys = vlanKeys;
            this.RequestType = Requests.RequestType.AddVlanMembership;
        }

        /// <summary>
        /// Gets or sets an array of VLAN keys associated with the result.
        /// </summary>
        [JsonProperty("VLAN Keys")]
        public string[] VlanKeys { get; set; }
    }

}