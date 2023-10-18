namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Results
{
    using Newtonsoft.Json;
    using System;

    public class SetEtsDestinationResult : BaseResult
    {
        public SetEtsDestinationResult(Guid id, string destinationKey, bool success, string error = null)
        {
            this.Id = id;
            this.Success = success;
            this.Error = error;
            this.DestinationKey = destinationKey;
            this.RequestType = Requests.RequestType.SetEtsDestination;
        }

        [JsonProperty("Dst Key")]
        public string DestinationKey { get; set; }
    }
}