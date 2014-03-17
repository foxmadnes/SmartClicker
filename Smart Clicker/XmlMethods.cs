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
                CustomizationParameters currentParameters =  (CustomizationParameters)reader.Deserialize(file);
                file.Close();
                return currentParameters;
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
            try
            {
                System.IO.StreamWriter file = new System.IO.StreamWriter(@"SmartClickerConfig.xml");
                writer.Serialize(file, currentParams);
                file.Close();
            }
            catch (IOException e)
            {
                //File is already open by a different process, nothing we can do
            }
        }
    }
}
