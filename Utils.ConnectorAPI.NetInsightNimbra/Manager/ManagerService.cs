namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra
{
    using Skyline.DataMiner.Core.DataMinerSystem.Common;
    using Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra.Manager;
    using System;
    using System.Collections.Generic;
    using System.Globalization;

    internal class ManagerService : IManagerService
    {
        internal ManagerService(NimbraManager manager, object[] serviceRow)
        {
            if (serviceRow.Length < 19)
            {
                throw new ArgumentException($"ERROR|Service row does not contain 19 columns: '" + string.Join("', '", serviceRow) + "'", "serviceRow");
            }

            Key = Convert.ToString(serviceRow[0]);
            OperationalState = (ServiceOperationStatusManager)Convert.ToInt32(serviceRow[8]);
            ServiceSourceNode = Convert.ToString(serviceRow[7]);
            ServiceChannelId = Convert.ToString(serviceRow[2]);
            RequestedCapacityInMbps = Convert.ToDouble(serviceRow[18], CultureInfo.InvariantCulture);
            ReservedCapacityInMbps = Convert.ToDouble(serviceRow[10], CultureInfo.InvariantCulture);
            Name = Convert.ToString(serviceRow[1]);
            var elementId = Convert.ToString(serviceRow[3]);
            SourceLocation = Convert.ToString(serviceRow[15]);
            DestinationLocations = Convert.ToString(serviceRow[16]).Split(';');
            CustomerId = Convert.ToInt32(serviceRow[9]);
            ServiceType = (ServiceTypes)Convert.ToInt32(serviceRow[12]);
            if (string.IsNullOrWhiteSpace(elementId))
            {
                throw new ArgumentException("The element ID can't be null or white space", "serviceRow");
            }
            else
            {
                SourceNodeElementId = new DmsElementId(elementId);
            }

            var serviceId = Convert.ToString(serviceRow[5]);
            if (serviceId == "-1" || string.IsNullOrWhiteSpace(serviceId))
            {
                DmsServiceId = null;
            }
            else
            {
                DmsServiceId = new DmsServiceId(serviceId);
            }

            var destinations = new List<IManagerServiceDestination>();
            foreach (var dst in Convert.ToString(serviceRow[11]).Split(','))
            {
                var dstParts = dst.Split(new[] { ':' });
                if (dstParts.Length != 2)
                {
                    continue;
                }

                if (manager.TryGetNodeForDtm(dstParts[0], out IManagerNode dstNode))
                {
                    destinations.Add(new ManagerServiceDestination(dstNode, dstParts[1]));
                }
            }

            Destinations = destinations.ToArray();
        }

        public string Key { get; private set; }

        public string Name { get; private set; }

        public DmsServiceId? DmsServiceId { get; private set; }

        public DmsElementId SourceNodeElementId { get; private set; }

        public string ServiceSourceNode { get; private set; }

        public string ServiceChannelId { get; set; }

        public double RequestedCapacityInMbps { get; private set; }

        public double ReservedCapacityInMbps { get; private set; }

        public ServiceOperationStatusManager OperationalState { get; private set; }

        public ServiceTypes ServiceType { get; private set; }

        public string SourceLocation { get; private set; }

        public IEnumerable<IManagerServiceDestination> Destinations { get; private set; }

        public IEnumerable<string> DestinationLocations { get; private set; }

        public int CustomerId { get; private set; }
    }
}