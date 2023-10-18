namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Results
{
    using Newtonsoft.Json;
    using System;

    public class AddItsDestinationResult : BaseResult
    {
        public AddItsDestinationResult(Guid id, string ttpKey, int dsti, bool success, string error = null)
        {
            this.Id = id;
            this.Success = success;
            this.Error = error;
            this.TtpKey = ttpKey;
            this.Dsti = dsti;
            this.RequestType = Requests.RequestType.AddItsDestination;
        }

        [JsonProperty("TTP Key")]
        public string TtpKey { get; set; }

        [JsonProperty("DSTI")]
        public int Dsti { get; set; }
    }
}