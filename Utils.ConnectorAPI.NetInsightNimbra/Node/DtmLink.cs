namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra
{
    using System;

    internal class DtmLink : IDtmLink
    {
        internal DtmLink(object[] dtmLinkRow)
        {
            if (dtmLinkRow.Length < 10)
            {
                throw new ArgumentException($"ERROR|DTM link row does not contain 10 columns: '" + string.Join("', '", dtmLinkRow) + "'", "dtmLinkRow");
            }

            Key = Convert.ToString(dtmLinkRow[0]);
            IfMacAddress = Convert.ToString(dtmLinkRow[1]);
            NodeMacAddress = Convert.ToString(dtmLinkRow[2]);
            Name = Convert.ToString(dtmLinkRow[4]);
            LocalIfMacAddress = Convert.ToString(dtmLinkRow[7]);
            RowState = (DataMinerSnmpRowStatus)Convert.ToInt32(dtmLinkRow[8]);
        }

        public string Key { get; private set; }

        public string IfMacAddress { get; private set; }

        public string NodeMacAddress { get; private set; }

        public string Name { get; private set; }

        public string LocalIfMacAddress { get; private set; }

        public DataMinerSnmpRowStatus RowState { get; private set; }

        public DtmLinkTypes LinkType
        {
            get
            {
                if (Name.Contains("/rx"))
                {
                    return DtmLinkTypes.Rx;
                }
                else if (Name.Contains("/tx"))
                {
                    return DtmLinkTypes.Tx;
                }
                else
                {
                    return DtmLinkTypes.Local;
                }
            }
        }
    }
}