using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace ControlsLibrary.Controls
{
    [DesignerCategory("code")]
    [ToolboxBitmap(typeof(CheckBox))]
    [ToolStripItemDesignerAvailability(ToolStripItemDesignerAvailability.All)]
    public class ToolStripCheckBox : ToolStripControl<CheckBox>
    {
        public ToolStripCheckBox() : base(new CheckBox())
        {
            HostControl.CheckedChanged += new EventHandler(CheckBox_CheckedChanged);
            HostControl.CheckStateChanged += new EventHandler(CheckBox_CheckStateChanged);
        }

       

        #region CheckedChanged

        public bool Checked
        {
            get { return HostControl.Checked; }
            set { HostControl.Checked = value; }
        }

        public event EventHandler CheckedChanged;

        public void DoCheckedChanged()
        {
            //...

            this.OnCheckedChanged(new EventArgs());
        }

        protected virtual void OnCheckedChanged(EventArgs e)
        {
            CheckedChanged?.Invoke(this, e);
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            DoCheckedChanged();
        }

        #endregion

        #region CheckStateChanged

        public CheckState CheckState
        {
            get { return HostControl.CheckState; }
            set { HostControl.CheckState = value; }
        }

        public event EventHandler CheckStateChanged;

        public void DoCheckStateChanged()
        {
            this.OnCheckStateChanged(new EventArgs());
        }

        protected virtual void OnCheckStateChanged(EventArgs e)
        {
            CheckStateChanged?.Invoke(this, e);
        }

        private void CheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            this.DoCheckStateChanged();
        }

        #endregion
    }
}
