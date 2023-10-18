namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra
{
    using System;

    internal class Customer : ICustomer
    {
        internal Customer(object[] customerRow)
        {
            if (customerRow.Length < 4)
            {
                throw new ArgumentException($"ERROR|Customer row does not contain 4 columns: '" + string.Join("', '", customerRow) + "'", "customerRow");
            }

            CustomerId = Convert.ToInt32(customerRow[0]);
            HasServices = Convert.ToInt32(customerRow[3]) == 1;
            Name = Convert.ToString(customerRow[1]);
            MainCustomer = Name;
            HasSubsection = false;
            if (!String.IsNullOrWhiteSpace(Name) && Name != "-1")
            {
                string[] customerNameParts = Name.Split('.');
                MainCustomer = customerNameParts[0];
                if (customerNameParts.Length > 1)
                {
                    HasSubsection = true;
                }
            }
        }

        public string Name { get; private set; }

        public string MainCustomer { get; private set; }

        public bool HasSubsection { get; private set; }

        public int CustomerId { get; private set; }

        public bool HasServices { get; private set; }
    }
}