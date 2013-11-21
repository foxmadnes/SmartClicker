using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Smart_Clicker
{
    class XmlMethods
    {
        public CustomizationParameters loadFromXML()
        {
            // if the file exists, load from the xml
            if (File.Exists(@"c:\temp\SmartClickerCustomization.xml"))
            {
                System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(typeof(CustomizationParameters));
                System.IO.StreamReader file = new System.IO.StreamReader(@"c:\temp\SmartClickerCustomization.xml");
                return (CustomizationParameters)reader.Deserialize(file);
            }

            else
            {
                //make new instance
                return new CustomizationParameters();
            }
        }

        public void saveCustomParams(CustomizationParameters currentParams)
        {
            System.Xml.Serialization.XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(typeof(CustomizationParameters));
            System.IO.StreamWriter file = new System.IO.StreamWriter(@"c:\temp\SmartClickerCustomization.xml");
            writer.Serialize(file, currentParams);
            file.Close();
        }
    }
}
