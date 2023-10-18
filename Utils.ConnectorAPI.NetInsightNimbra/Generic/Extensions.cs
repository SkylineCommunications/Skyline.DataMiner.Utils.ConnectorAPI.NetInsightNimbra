namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra
{
    using Newtonsoft.Json;
    using Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Requests;
    using Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Results;
    using System;
    using System.Collections.Generic;

    public static class Extensions
    {
        private static readonly Dictionary<RequestType, Type> RequestTypes = new Dictionary<RequestType, Type>
        {
            { RequestType.SetItsDestination, typeof(SetItsDestination) },
            { RequestType.SetEtsDestination, typeof(SetEtsDestination) },
            { RequestType.AddItsDestination, typeof(AddItsDestination) },
            { RequestType.AddItsSource, typeof(AddItsSource) },
            { RequestType.AddRoute, typeof(AddRoute) },
            { RequestType.AddEtsSource, typeof(AddEtsSource) },
            { RequestType.AddEthGroup, typeof(AddEthGroup) },
            { RequestType.AddForwardingFunction, typeof(AddForwardingFunction) },
            { RequestType.AddVlanMembership, typeof(AddVlan) },
            { RequestType.RemoveDestination, typeof(RemoveDestination) },
            { RequestType.RemoveItsDestination, typeof(RemoveItsDestination) },
            { RequestType.RemoveItsSource, typeof(RemoveItsSource) },
            { RequestType.RemoveEtsSource, typeof(RemoveEtsSource) },
            { RequestType.RemoveEthGroup, typeof(RemoveEthGroup) },
            { RequestType.RemoveRoute, typeof(RemoveRoute) },
            { RequestType.RemoveForwardingFunction, typeof(RemoveForwardingFunction)},
            { RequestType.RemoveVlan, typeof(RemoveVlan)},
            { RequestType.SetForwardingFunction, typeof(SetForwardingFunction) },
        };

        private static readonly Dictionary<RequestType, Type> ResultTypes = new Dictionary<RequestType, Type>
        {
            { RequestType.SetItsDestination, typeof(SetItsDestinationResult) },
            { RequestType.SetEtsDestination, typeof(SetEtsDestinationResult) },
            { RequestType.AddItsDestination, typeof(AddItsDestinationResult) },
            { RequestType.AddItsSource, typeof(AddItsSourceResult) },
            { RequestType.AddRoute, typeof(AddRouteResult) },
            { RequestType.AddEtsSource, typeof(AddEtsSourceResult) },
            { RequestType.AddEthGroup, typeof(AddEthGroupResult) },
            { RequestType.AddForwardingFunction, typeof(AddForwardingFunctionResult) },
            { RequestType.AddVlanMembership, typeof(AddVlanResult) },
            { RequestType.RemoveDestination, typeof(RemoveDestinationResult) },
            { RequestType.RemoveItsDestination, typeof(RemoveItsDestinationResult) },
            { RequestType.RemoveItsSource, typeof(RemoveItsSourceResult) },
            { RequestType.RemoveEtsSource, typeof(RemoveEtsSourceResult) },
            { RequestType.RemoveEthGroup, typeof(RemoveEthGroupResult) },
            { RequestType.RemoveForwardingFunction, typeof(RemoveForwardingFunctionResult) },
            { RequestType.RemoveVlan, typeof(RemoveVlanResult) },
            { RequestType.RemoveRoute, typeof(RemoveRouteResult) },
            { RequestType.SetForwardingFunction, typeof(SetForwardingFunctionResult) },
        };

        public static IRequest DeserializeRequest(this string stringValue)
        {
            BaseRequest request = JsonConvert.DeserializeObject<BaseRequest>(stringValue);

            if (request == null)
            {
                throw new ArgumentNullException("stringValue");
            }

            if (request.RequestType == RequestType.Unknown)
            {
                throw new ArgumentException("Request has unknown command.");
            }

            if (!RequestTypes.ContainsKey(request.RequestType))
            {
                throw new ArgumentException("Request has unimplemented request type: " + request.RequestType);
            }

            return (IRequest)JsonConvert.DeserializeObject(stringValue, RequestTypes[request.RequestType]);
        }

        public static IResult DeserializeResult(this string stringValue)
        {
            BaseResult result = JsonConvert.DeserializeObject<BaseResult>(stringValue);

            if (result == null)
            {
                throw new ArgumentNullException("stringValue");
            }

            if (result.RequestType == RequestType.Unknown)
            {
                throw new ArgumentException("Result has unknown request type.");
            }

            if (!ResultTypes.ContainsKey(result.RequestType))
            {
                throw new ArgumentException("Result has unimplemented request type: " + result.RequestType);
            }

            return (IResult)JsonConvert.DeserializeObject(stringValue, ResultTypes[result.RequestType]);
        }

        public static string Serialize(this IRequest request)
        {
            return JsonConvert.SerializeObject(request);
        }

        public static string Serialize(this IResult request)
        {
            return JsonConvert.SerializeObject(request);
        }
    }
}