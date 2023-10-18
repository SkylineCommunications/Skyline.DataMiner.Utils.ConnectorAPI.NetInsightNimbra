namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Results
{
    using Newtonsoft.Json;
    using System;

    public class AddItsSourceResult : BaseResult
    {
        public AddItsSourceResult(Guid id, string ttpKey, bool success, string error = null)
        {
            this.Id = id;
            this.Success = success;
            this.Error = error;
            this.TtpKey = ttpKey;
            this.RequestType = Requests.RequestType.AddItsSource;
        }

        [JsonProperty("TTP Key")]
        public string TtpKey { get; set; }
    }
}