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
