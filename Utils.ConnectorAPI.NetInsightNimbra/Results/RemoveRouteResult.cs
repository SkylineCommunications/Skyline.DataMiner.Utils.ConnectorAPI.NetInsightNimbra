namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Results
{
    using System;

    public class RemoveRouteResult : BaseResult
    {
        public RemoveRouteResult(Guid id, bool success, string error = null)
        {
            this.Id = id;
            this.Success = success;
            this.Error = error;
            this.RequestType = Requests.RequestType.RemoveRoute;
        }
    }
}