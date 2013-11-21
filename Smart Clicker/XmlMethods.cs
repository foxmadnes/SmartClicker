using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;

namespace Smart_Clicker
{
    class XmlMethods
    {
        public CustomizationParameters loadFromXML()
        {
            // if the file exists, load from the xml
            if (File.Exists(@"SmartClickerConfig.xml"))
            {
                XmlSerializer reader = new XmlSerializer(typeof(CustomizationParameters));
                System.IO.StreamReader file = new System.IO.StreamReader(@"SmartClickerConfig.xml");
                return (CustomizationParameters)reader.Deserialize(file);
            }

            else
            {
                //make new instance with default values
                return CustomizationParameters.createDefault();
            }
        }

        public void saveCustomParams(CustomizationParameters currentParams)
        {
            XmlSerializer writer = new XmlSerializer(typeof(CustomizationParameters));
            System.IO.StreamWriter file = new System.IO.StreamWriter(@"SmartClickerConfig.xml");
            writer.Serialize(file, currentParams);
            file.Close();
        }
    }
}
