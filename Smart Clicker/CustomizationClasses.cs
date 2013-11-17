using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Smart_Clicker
{
    public class CustomizationParameters
    {
        public ClickCustomization clickValues;
        public LayoutCustomization layoutValues;
        public ContextCustomization contextValues;


        public CustomizationParameters()
        {
            //this.clickValues = loadFromXML().clickValues;
            //this.layoutValues = loadFromXML().layoutValues;
            //this.contextValues = loadFromXML().contextValues;
        }

        public CustomizationParameters loadFromXML()
        {
            System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(typeof(CustomizationParameters));
            System.IO.StreamReader file = new System.IO.StreamReader(@"c:\temp\SmartClickerCustomization.xml");
            return (CustomizationParameters)reader.Deserialize(file);
        }
  
        public void saveCustomParams()
        {
            System.Xml.Serialization.XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(typeof(CustomizationParameters));
            System.IO.StreamWriter file = new System.IO.StreamWriter(@"c:\temp\SmartClickerCustomization.xml");
            CustomizationParameters currentParams = new CustomizationParameters(); // This may not be the best way to do this
            writer.Serialize(file,currentParams);
            file.Close();
        }

    }

    public class ClickCustomization
    {
        // In ms
        public int timeout;
        // In pixels
        public int clickBoundingBox;
    }

    public class LayoutCustomization
    {
        public List<String> hiddenIconNames;
        public int startWidth;
        public int startHeight;
        public int totalModes;
        public bool restartOnCrash;
    }

    public class ContextCustomization
    {
        public List<Bitmap> clickAndDragBitmaps;
        public List<Bitmap> doubleClickBitmaps;
        public List<Bitmap> rightClickBitmaps;
    }


}
