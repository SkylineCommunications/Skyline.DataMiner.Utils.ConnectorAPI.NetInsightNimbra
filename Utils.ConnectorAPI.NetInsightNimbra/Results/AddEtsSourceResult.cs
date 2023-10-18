namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Results
{
    using Newtonsoft.Json;
    using System;

    public class AddEtsSourceResult : BaseResult
    {
        public AddEtsSourceResult(Guid id, string ttpKey, int dsti, bool success, string error = null)
        {
            this.Id = id;
            this.Success = success;
            this.Dsti = dsti;
            this.Error = error;
            this.TtpKey = ttpKey;
            this.RequestType = Requests.RequestType.AddEtsSource;
        }

        [JsonProperty("TTP Key")]
        public string TtpKey { get; set; }

        [JsonProperty("DSTI")]
        public int Dsti { get; set; }
    }
}