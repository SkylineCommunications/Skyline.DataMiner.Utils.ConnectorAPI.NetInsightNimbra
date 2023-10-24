namespace Skyline.DataMiner.Utils.ConnectorAPI.NetInsightNimbra
{
    using Skyline.DataMiner.Core.DataMinerSystem.Common;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Extension Methods
    /// </summary>
    public static class ExtensionMethods
    {
        /// <summary>
        /// Get the Nimbra Manager from a DataMiner system.
        /// </summary>
        /// <param name="element">The element defined in DataMiner.</param>
        /// <returns>The Nimbra Manager.</returns>
        public static INimbraManager GetNimbraManager(this IDmsElement element)
        {
            if (element.Protocol.Name != NimbraManager.ProtocolName)
            {
                throw new ArgumentException($"The element is not running protocol {NimbraManager.ProtocolName}", "element");
            }

            return new NimbraManager(element);
        }

        /// <summary>
        /// Get the Nimbra Manager from a DataMiner system.
        /// </summary>
        /// <param name="thisDms">The DataMiner system.</param>
        /// <param name="elementName">The element name defined in DataMiner.</param>
        /// <returns>The Nimbra Manager.</returns>
        public static INimbraManager GetNimbraManager(this IDms thisDms, string elementName)
        {
            IDmsElement element;
            element = thisDms.GetElement(elementName);
            if (element.Protocol.Name != NimbraManager.ProtocolName)
            {
                throw new ArgumentException($"The element is not running protocol {NimbraManager.ProtocolName}", "elementName");
            }

            return new NimbraManager(element);
        }

        /// <summary>
        /// Get the Nimbra Manager from a DataMiner system.
        /// </summary>
        /// <param name="thisDms">The DataMiner system.</param>
        /// <returns>The Nimbra Manager.</returns>
        public static INimbraManager GetNimbraManager(this IDms thisDms)
        {
            IDmsElement element;
            element = thisDms.GetElements().FirstOrDefault(e => e.Protocol.Name == NimbraManager.ProtocolName);
            if (element == null)
                throw new MissingManagerException("Unable to find the Manager in the DataMiner system.");

            return new NimbraManager(element);
        }

        /// <summary>
        /// Get the Nimbra Node from a DataMiner system.
        /// </summary>
        /// <param name="element">The element defined in DataMiner.</param>
        /// <returns>The Nimbra Node.</returns>
        public static INimbraNode ToNimbraNode(this IDmsElement element)
        {
            if (element.Protocol.Name != NimbraNode.ProtocolName)
            {
                throw new ArgumentException($"The element is not running protocol {NimbraNode.ProtocolName}", "element");
            }

            return new NimbraNode(element);
        }

        /// <summary>
        /// Get the Nimbra Node from a DataMiner system.
        /// </summary>
        /// <param name="thisDms">The DataMiner system.</param>
        /// <param name="elementName">The element name defined in DataMiner.</param>
        /// <returns>The Nimbra Node.</returns>
        public static INimbraNode GetNimbraNode(this IDms thisDms, string elementName)
        {
            IDmsElement element;
            element = thisDms.GetElement(elementName);
            if (element.Protocol.Name != NimbraNode.ProtocolName)
            {
                throw new ArgumentException($"The element is not running protocol {NimbraNode.ProtocolName}", "elementName");
            }

            return new NimbraNode(element);
        }

        /// <summary>
        /// Get the Nimbra Node from a DataMiner system.
        /// </summary>
        /// <param name="thisDms">The DataMiner system.</param>
        /// <param name="elementId">The element ID defined in DataMiner.</param>
        /// <returns>The Nimbra Node.</returns>
        public static INimbraNode GetNimbraNode(this IDms thisDms, DmsElementId elementId)
        {
            IDmsElement element;
            element = thisDms.GetElement(elementId);
            if (element.Protocol.Name != NimbraNode.ProtocolName)
            {
                throw new ArgumentException($"The element is not running protocol {NimbraNode.ProtocolName}", "elementId");
            }

            return new NimbraNode(element);
        }

        /// <summary>
        /// Get the Nimbra Nodes from a DataMiner system.
        /// </summary>
        /// <param name="thisDms">The DataMiner system.</param>
        /// <returns>The Nimbra Nodes.</returns>
        public static IEnumerable<INimbraNode> GetNimbraNodes(this IDms thisDms)
        {
            IEnumerable<IDmsElement> elements;
            elements = thisDms.GetElements().Where(e => e.Protocol.Name == NimbraNode.ProtocolName);
            return elements.Select(e => new NimbraNode(e)).ToArray();
        }
    }
}