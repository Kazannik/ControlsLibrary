using System.Windows.Forms.Design;

namespace ControlsLibrary.Controls
{
    [ToolStripItemDesignerAvailability(ToolStripItemDesignerAvailability.All)]
    public class exPickerBox : PickerComboControl<exPickerBoxPopupForm>
    {
        #region Initialize
        public exPickerBox() : base(new exPickerBoxPopupForm()) { }

        #endregion
    }
}
