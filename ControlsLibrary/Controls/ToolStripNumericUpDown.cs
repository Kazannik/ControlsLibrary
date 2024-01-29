using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace ControlsLibrary.Controls
{
    [DesignerCategory("code")]
    [ToolboxBitmap(typeof(NumericUpDown))]
    [ToolStripItemDesignerAvailability(ToolStripItemDesignerAvailability.All)]
    public class ToolStripNumericUpDown: ToolStripControl<NumericUpDown>
    {

        public ToolStripNumericUpDown(): base(new NumericUpDown())
        {
            HostControl.ValueChanged += new EventHandler(NumericUpDown_ValueChanged);
        }
                
        #region ValueChanged

        public decimal Value
        {
            get { return HostControl.Value; }
            set { HostControl.Value = value; }
        }

        public event EventHandler ValueChanged;

        public void DoValueChanged()
        {
            //...

            OnValueChanged(new EventArgs());
        }

        protected virtual void OnValueChanged(EventArgs e)
        {
            ValueChanged?.Invoke(this, e);
        }

        private void NumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            DoValueChanged();
        }

        #endregion
    }
}
