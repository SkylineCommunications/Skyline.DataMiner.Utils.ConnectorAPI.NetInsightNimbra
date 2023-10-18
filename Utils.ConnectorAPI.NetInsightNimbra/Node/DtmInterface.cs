namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra
{
    using System;
    using System.Globalization;

    internal class DtmInterface : IDtmInterface
    {
        internal DtmInterface(object[] dtmIfRow)
        {
            if (dtmIfRow.Length < 60)
            {
                throw new ArgumentException($"ERROR|DTM Interface row does not contain 60 columns: '" + string.Join("', '", dtmIfRow) + "'", "channelrow");
            }

            Key = Convert.ToString(dtmIfRow[0]);
            Name = Convert.ToString(dtmIfRow[1]);
            TxCapacityInMbps = Convert.ToDouble(dtmIfRow[2], CultureInfo.InvariantCulture);
            TxCapacityUsedInMbps = Convert.ToDouble(dtmIfRow[3], CultureInfo.InvariantCulture);
            Purpose = Convert.ToString(dtmIfRow[8]);
            TxUsage = Convert.ToDouble(dtmIfRow[9], CultureInfo.InvariantCulture);
            MacAddress = Convert.ToString(dtmIfRow[23]);
        }

        public string Key { get; private set; }

        public string Name { get; private set; }

        public double TxCapacityInMbps { get; private set; }

        public double TxCapacityUsedInMbps { get; private set; }

        public string Purpose { get; private set; }

        public double TxUsage { get; private set; }

        public string MacAddress { get; private set; }
    }
}