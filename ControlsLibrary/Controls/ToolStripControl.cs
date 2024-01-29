using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ControlsLibrary.Controls
{
    [DesignerCategory("code")]
    [ToolboxBitmap(typeof(exComboBox))]
    [ComVisible(false)]
    public abstract class ToolStripControl<T> : ToolStripControlHost where T : Control
    {
        public ToolStripControl(T control) : base(control) { }

        public T HostControl
        {
            get { return (T)base.Control; }
        }
    }
}
