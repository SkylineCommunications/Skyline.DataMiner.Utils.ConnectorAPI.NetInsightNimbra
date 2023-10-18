namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Results
{
    using System;

    public class RemoveVlanResult : BaseResult
    {
        public RemoveVlanResult(Guid id, bool success, string error = null)
        {
            this.Id = id;
            this.Success = success;
            this.Error = error;
            this.RequestType = Requests.RequestType.RemoveVlan;
        }
    }
}