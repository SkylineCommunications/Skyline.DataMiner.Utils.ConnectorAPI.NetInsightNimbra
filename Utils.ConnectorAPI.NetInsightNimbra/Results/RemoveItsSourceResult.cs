namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Results
{
    using System;

    public class RemoveItsSourceResult : BaseResult
    {
        public RemoveItsSourceResult(Guid id, bool success, string error = null)
        {
            this.Id = id;
            this.Success = success;
            this.Error = error;
            this.RequestType = Requests.RequestType.RemoveItsSource;
        }
    }
}