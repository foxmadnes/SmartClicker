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

            this.clickValues = new ClickCustomization();
            this.layoutValues = new LayoutCustomization();
            this.contextValues = new ContextCustomization();

        }

        // Default values used if configuration is missing
        public static CustomizationParameters createDefault()
        {
            CustomizationParameters defaultParameters = new CustomizationParameters();
            defaultParameters.clickValues = new ClickCustomization();
            defaultParameters.clickValues.timeout = 100;
            defaultParameters.clickValues.clickBoundingBox = 25;
            defaultParameters.layoutValues = new LayoutCustomization();
            defaultParameters.layoutValues.hiddenIconNames = new List<string>();
            defaultParameters.layoutValues.restartOnCrash = true;
            defaultParameters.layoutValues.startOnStartup = false;
            defaultParameters.layoutValues.startHeight = 462;
            defaultParameters.layoutValues.startWidth = 100;
            defaultParameters.layoutValues.startLeft = 0;
            defaultParameters.layoutValues.startTop = 0;
            defaultParameters.contextValues = new ContextCustomization();
            defaultParameters.contextValues.clickAndDragBitmaps = new List<Bitmap>();
            defaultParameters.contextValues.doubleClickBitmaps = new List<Bitmap>();
            defaultParameters.contextValues.rightClickBitmaps = new List<Bitmap>();
            defaultParameters.contextValues.supportScrollBars = true;
            defaultParameters.contextValues.supportTitleBars = true;
            defaultParameters.contextValues.supportTabs = true;
            defaultParameters.contextValues.compareCursors = true;
            return defaultParameters;
        }

        // Used by Customization UI (CustomUI) to clone configurations without "committing"
        public CustomizationParameters copy()
        {
            CustomizationParameters copy = new CustomizationParameters();
            copy.clickValues = this.clickValues.copy();
            copy.layoutValues = this.layoutValues.copy();
            copy.contextValues = this.contextValues.copy();
            return copy;

        }

        // Used by Customization UI to save new configurations while application is running
        public void merge(CustomizationParameters newCustomization)
        {
            this.clickValues = newCustomization.clickValues;
            this.layoutValues = newCustomization.layoutValues;
            this.contextValues = newCustomization.contextValues;
        }
    }

    public class ClickCustomization
    {
        // In ms
        public int timeout;
        // In pixels
        public int clickBoundingBox;

        public ClickCustomization copy()
        {
            ClickCustomization copy = new ClickCustomization();
            copy.timeout = this.timeout;
            copy.clickBoundingBox = this.clickBoundingBox;
            return copy;
        }
    }

    public class LayoutCustomization
    {
        public List<string> hiddenIconNames;
        public int startWidth;
        public int startHeight;
        public int totalModes;
        public int startLeft;
        public int startTop;
        public bool restartOnCrash;
        public bool startOnStartup;

        public LayoutCustomization copy()
        {
            LayoutCustomization copy = new LayoutCustomization();
            string[] copyList = new string[this.hiddenIconNames.Count];
            this.hiddenIconNames.CopyTo(copyList);
            copy.hiddenIconNames = copyList.ToList<string>();
            copy.startWidth = this.startWidth;
            copy.startHeight = this.startHeight;
            copy.totalModes = this.totalModes;
            copy.restartOnCrash = this.restartOnCrash;
            copy.startOnStartup = this.startOnStartup;
            return copy;
        }
    }

    public class ContextCustomization
    {
        // For future support of adding cursors to ContextMode
        public List<Bitmap> clickAndDragBitmaps;
        public List<Bitmap> doubleClickBitmaps;
        public List<Bitmap> rightClickBitmaps;

        // Booleans to turn off API and cursor Comparison functionality
        public bool compareCursors;
        public bool supportTitleBars;
        public bool supportScrollBars;
        public bool supportTabs;

        public ContextCustomization copy()
        {
            ContextCustomization copy = new ContextCustomization();
            copy.compareCursors = this.compareCursors;
            copy.supportTitleBars = this.supportTitleBars;
            copy.supportScrollBars = this.supportScrollBars;
            copy.supportTabs = this.supportTabs;
            return this;
        }
    }


}
