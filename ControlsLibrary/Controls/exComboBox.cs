using System.Windows.Forms.Design;

namespace ControlsLibrary.Controls
{
    [ToolStripItemDesignerAvailability(ToolStripItemDesignerAvailability.All)]
    public class exComboBox : ComboControl<exComboBoxItem>
    {
        #region Initialize
        public exComboBox() : base() { }
        
        #endregion
    }
}
