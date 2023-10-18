namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Results
{
    using System;

    public class SetForwardingFunctionResult : BaseResult
    {
        public SetForwardingFunctionResult(Guid id, bool success, string error = null)
        {
            this.Id = id;
            this.Success = success;
            this.Error = error;
            this.RequestType = Requests.RequestType.AddForwardingFunction;
        }
    }
}