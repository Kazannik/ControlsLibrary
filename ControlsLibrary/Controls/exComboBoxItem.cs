namespace ControlsLibrary.Controls
{
    public class exComboBoxItem : ComboControl<exComboBoxItem>.IComboBoxItem
    {
        public string Code { get; }
        public string Text { get; }

        public exComboBoxItem(string code, string text)
        {
            Code = code;
            Text = text;
        }
    }
}