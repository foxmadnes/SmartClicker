using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Smart_Clicker
{
    class CustomizationParameters
    {
        public ClickCustomization clickValues;
        public LayoutCustomization layoutValues;
        public ContextCustomization contextValues;


        public CustomizationParameters()
        {
            // To be replaced by load from file!
            this.clickValues = new ClickCustomization();
            this.layoutValues = new LayoutCustomization();
            this.contextValues = new ContextCustomization();

        }
        //// Umm.. where is this supposed to go? Ask Andres about design decisions.
        //public CustomizationParameters readCustomParams()
        //{
        //    System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(typeof(CustomizationParameters));
        //    System.IO.StreamReader file = new System.IO.StreamReader(@"c:\temp\SmartClickerCustomization.xml");
        //    return (CustomizationParameters)reader.Deserialize(file);
        //    // break up into clickValues, layoutValues, contextValues
        //}

    }

    class ClickCustomization
    {
        // In ms
        public int timeout;
        // In pixels
        public int clickBoundingBox;
    }

    class LayoutCustomization
    {
        public List<PictureBox> orderedIcons;
        int startWidth;
        int startHeight;
        bool restartOnCrash;
    }

    class ContextCustomization
    {
        public List<Bitmap> clickAndDragBitmaps;
        public List<Bitmap> doubleClickBitmaps;
        public List<Bitmap> rightClickBitmaps;
    }


}
