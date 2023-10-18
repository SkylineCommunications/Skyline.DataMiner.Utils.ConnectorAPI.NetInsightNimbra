namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Results
{
    using Newtonsoft.Json;
    using System;

    public class AddForwardingFunctionResult : BaseResult
    {
        public AddForwardingFunctionResult(Guid id, int ffid, string tableKey, bool success, string error = null)
        {
            this.Id = id;
            this.FfId = ffid;
            this.TableKey = tableKey;
            this.Success = success;
            this.Error = error;
            this.RequestType = Requests.RequestType.AddForwardingFunction;
        }

        [JsonProperty("FF ID")]
        public int FfId { get; set; }

        [JsonProperty("Table Key")]
        public string TableKey { get; set; }
    }
}