// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Xml;
using System.Xml.Linq;
using Azure.Core;

namespace xml_service.Models
{
    public partial class ComplexTypeNoMeta : IXmlSerializable
    {
        void IXmlSerializable.Write(XmlWriter writer, string nameHint)
        {
            writer.WriteStartElement(nameHint ?? "ComplexTypeNoMeta");
            if (Optional.IsDefined(ID))
            {
                writer.WriteStartElement("ID");
                writer.WriteValue(ID);
                writer.WriteEndElement();
            }
            writer.WriteEndElement();
        }

        internal static ComplexTypeNoMeta DeserializeComplexTypeNoMeta(XElement element)
        {
            string id = default;
            if (element.Element("ID") is XElement idElement)
            {
                id = (string)idElement;
            }
            return new ComplexTypeNoMeta(id);
        }
    }
}
