﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OneDrive.ApiDocumentation.Validation.OData
{
    public class ReturnType
    {
        public string Type { get; set; }
        public bool Nullable { get; set; }
        
        
        public static string ElementName { get { return "ReturnType"; } }

        internal static ReturnType FromXml(System.Xml.Linq.XElement xml)
        {
            if (xml.Name.LocalName != ReturnType.ElementName) throw new ArgumentException("xml wasn't a ReturnType element");

            var obj = new ReturnType();
            obj.Type = xml.AttributeValue("Type");
            obj.Nullable = xml.AttributeValue("Nullable").ToBoolean();
            
            return obj;
        }

    }
}