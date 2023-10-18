namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra
{
    /// <summary>
    /// Defines a customer in the Nimbra Solution.
    /// </summary>
    public interface ICustomer
    {
        /// <summary>
        /// The full name of the customer.
        /// This name can exist of the following format '[MainCustomer].[Subsection]'.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// The name of the main customer.
        /// </summary>
        string MainCustomer { get; }

        /// <summary>
        /// Whether the customer has a subsection defined.
        /// </summary>
        bool HasSubsection { get; }

        /// <summary>
        /// The ID of the customer.
        /// </summary>
        int CustomerId { get; }

        /// <summary>
        /// Whether the customer has services defined.
        /// </summary>
        bool HasServices { get; }
    }
}