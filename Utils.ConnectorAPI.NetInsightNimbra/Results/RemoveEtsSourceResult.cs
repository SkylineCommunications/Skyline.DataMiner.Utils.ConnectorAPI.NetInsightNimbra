﻿namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Results
{
    using System;

    /// <summary>
    /// Represents the result of a Remove ETS (Ethernet Traffic Shaping) of the source node request sent to the NetInsight Nimbra device.
    /// </summary>
    public class RemoveEtsSourceResult : BaseResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveEtsSourceResult"/> class.
        /// </summary>
        /// <param name="id">The unique identifier for the result.</param>
        /// <param name="success">A flag indicating the success of the operation.</param>
        /// <param name="error">An optional error message if the operation was not successful.</param>
        public RemoveEtsSourceResult(Guid id, bool success, string error = null)
        {
            this.Id = id;
            this.Success = success;
            this.Error = error;
            this.RequestType = Requests.RequestType.RemoveEtsSource;
        }
    }

}