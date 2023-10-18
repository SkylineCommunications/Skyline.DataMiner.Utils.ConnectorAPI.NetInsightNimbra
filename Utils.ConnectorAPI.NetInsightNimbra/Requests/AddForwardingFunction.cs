namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Requests
{
    using Newtonsoft.Json;
    using Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Results;
    using System;

    public class AddForwardingFunction : BaseRequest
    {
        public AddForwardingFunction()
        {
            RequestType = RequestType.AddForwardingFunction;
        }

        [JsonProperty("Aging Time")]
        public TimeSpan AgingTime { get; set; }

        [JsonProperty("CustomerId")]
        public int CustomerId { get; set; }

        [JsonProperty("Eth Key")]
        public string EthDeviceKey { get; set; }

        [JsonProperty("VLAN Mode")]
        public VlanMode VlanMode { get; set; }

        [JsonProperty("Spanning Tree")]
        public SpanningTree SpanningTree { get; set; }

        [JsonProperty("Purpose")]
        public string Purpose { get; set; }

        [JsonProperty("Propagate Faults")]
        public TruthValue PropagateFaults { get; set; }

        [JsonProperty("MAC Mode")]
        public MacMode MacMode { get; set; }

        [JsonProperty("Jumbo Frames")]
        public TruthValue JumboFrames { get; set; }

        public IResult GetResult(int ffid, string tableKey, bool success, string errorMessage = null)
        {
            return new AddForwardingFunctionResult(Id, ffid, tableKey, success, errorMessage);
        }
    }
}