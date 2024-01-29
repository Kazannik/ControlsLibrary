using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace ControlsLibrary.Controls
{
    [DesignerCategory("code")]
    [ToolboxBitmap(typeof(ComboBox))]
    [ToolStripItemDesignerAvailability(ToolStripItemDesignerAvailability.All)]
    public class exToolStripPickerBox : ToolStripControl<exPickerBox>
    {
        public exToolStripPickerBox() : base(new exPickerBox()) { }        
    }
}
