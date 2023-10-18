namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Requests
{
    using Newtonsoft.Json;

    [JsonConverter(typeof(TolerantEnumConverter))]
    public enum RequestType
    {
        Unknown,
        AddItsSource,
        AddEtsSource,
        AddItsDestination,
        SetItsDestination,
        SetEtsDestination,
        AddRoute,
        AddEthGroup,
        AddForwardingFunction,
        AddVlanMembership,
        RemoveItsSource,
        RemoveEtsSource,
        RemoveItsDestination,
        RemoveDestination,
        RemoveRoute,
        RemoveEthGroup,
        RemoveForwardingFunction,
        RemoveVlan,
        SetForwardingFunction,
    }
}