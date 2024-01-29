using System;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace ControlsLibrary.Controls
{
    [System.ComponentModel.DesignerCategory("Code")]
    [System.Drawing.ToolboxBitmapAttribute(typeof(ComboBox))]
    [ToolStripItemDesignerAvailability(ToolStripItemDesignerAvailability.All)]
    public abstract class PickerComboControl <T> : ComboBox where T : UserControl
    {
        private ToolStripControlHost controlHost;
        private static ToolStripDropDown dropDown;

        public PickerComboControl(T popupForm)
        {
            popupForm.BorderStyle = BorderStyle.None;
            controlHost = new ToolStripControlHost(popupForm);

            dropDown = new ToolStripDropDown();
            dropDown.Items.Add(controlHost);
            DropDownHeight = popupForm.Height;
            DropDownWidth = popupForm.Width;
            controlHost.Width = DropDownWidth;
            controlHost.Height = DropDownHeight;
        }
                
        public T PopupForm
        {
            get { return controlHost.Control as T; }
        }
       
        private void ShowDropDown()
        {
            if (dropDown != null)
            {
                controlHost.Width = DropDownWidth;
                controlHost.Height = DropDownHeight;

                dropDown.Show(this, 0, Height);
            }
        }

        private void HideDropDown()
        {
            if (dropDown != null)
            {
                dropDown.Hide();
            }
        }

        private const int WM_USER = 0X400;
        private const int WM_REFLECT = WM_USER + 0X1C00;
        private const int WM_COMMAND = 0X111;
        private const int CBN_DROPDOWN = 0X7;

        public static int HIWORD(int n)
        {
            return (n >> 16) & 0xffff;
        }

        public static int HIWORD(IntPtr n)
        {
            return HIWORD(unchecked((int)(long)n));
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_REFLECT + WM_COMMAND)
            {
                if (HIWORD(m.WParam) == CBN_DROPDOWN)
                {
                    this.ShowDropDown();
                    return;
                }
            }
            base.WndProc(ref m);
        }
                
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
        }

        #endregion

    }
}
