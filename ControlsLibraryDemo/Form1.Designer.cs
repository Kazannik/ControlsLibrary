namespace ControlsLibraryDemo
{
    partial class Form1
    {
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pickerBox1 = new ControlsLibrary.Controls.exPickerBox();
            this.comboBox1 = new ControlsLibrary.Controls.exComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripCheckBox1 = new ControlsLibrary.Controls.ToolStripCheckBox();
            this.toolStripNumericUpDown1 = new ControlsLibrary.Controls.ToolStripNumericUpDown();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripCheckBox2 = new ControlsLibrary.Controls.ToolStripCheckBox();
            this.toolStripNumericUpDown2 = new ControlsLibrary.Controls.ToolStripNumericUpDown();
            this.exToolStripPickerBox1 = new ControlsLibrary.Controls.exToolStripPickerBox();
            this.exToolStripPickerBox2 = new ControlsLibrary.Controls.exToolStripPickerBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pickerBox1
            // 
            this.pickerBox1.DropDownHeight = 150;
            this.pickerBox1.DropDownWidth = 150;
            this.pickerBox1.FormattingEnabled = true;
            this.pickerBox1.IntegralHeight = false;
            this.pickerBox1.Location = new System.Drawing.Point(12, 100);
            this.pickerBox1.Name = "pickerBox1";
            this.pickerBox1.Size = new System.Drawing.Size(258, 24);
            this.pickerBox1.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.Code = "";
            this.comboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox1.DropDownHeight = 164;
            this.comboBox1.DropDownWidth = 80;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.ItemHeight = 20;
            this.comboBox1.Location = new System.Drawing.Point(12, 39);
            this.comboBox1.MaxDropDownItems = 20;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(258, 26);
            this.comboBox1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripCheckBox1,
            this.toolStripNumericUpDown1,
            this.exToolStripPickerBox1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(632, 35);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripCheckBox1
            // 
            this.toolStripCheckBox1.Checked = false;
            this.toolStripCheckBox1.CheckState = System.Windows.Forms.CheckState.Unchecked;
            this.toolStripCheckBox1.Name = "toolStripCheckBox1";
            this.toolStripCheckBox1.Size = new System.Drawing.Size(161, 28);
            this.toolStripCheckBox1.Text = "toolStripCheckBox1";
            // 
            // toolStripNumericUpDown1
            // 
            this.toolStripNumericUpDown1.Name = "toolStripNumericUpDown1";
            this.toolStripNumericUpDown1.Size = new System.Drawing.Size(53, 28);
            this.toolStripNumericUpDown1.Text = "0";
            this.toolStripNumericUpDown1.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.toolStripNumericUpDown1.Click += new System.EventHandler(this.toolStripNumericUpDown1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripCheckBox2,
            this.toolStripNumericUpDown2,
            this.exToolStripPickerBox2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 361);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(632, 30);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripCheckBox2
            // 
            this.toolStripCheckBox2.Checked = false;
            this.toolStripCheckBox2.CheckState = System.Windows.Forms.CheckState.Unchecked;
            this.toolStripCheckBox2.Name = "toolStripCheckBox2";
            this.toolStripCheckBox2.Size = new System.Drawing.Size(161, 28);
            this.toolStripCheckBox2.Text = "toolStripCheckBox2";
            // 
            // toolStripNumericUpDown2
            // 
            this.toolStripNumericUpDown2.Name = "toolStripNumericUpDown2";
            this.toolStripNumericUpDown2.Size = new System.Drawing.Size(53, 28);
            this.toolStripNumericUpDown2.Text = "0";
            this.toolStripNumericUpDown2.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // exToolStripPickerBox1
            // 
            this.exToolStripPickerBox1.Name = "exToolStripPickerBox1";
            this.exToolStripPickerBox1.Size = new System.Drawing.Size(121, 28);
            this.exToolStripPickerBox1.Text = "exToolStripPickerBox1";
            // 
            // exToolStripPickerBox2
            // 
            this.exToolStripPickerBox2.Name = "exToolStripPickerBox2";
            this.exToolStripPickerBox2.Size = new System.Drawing.Size(121, 28);
            this.exToolStripPickerBox2.Text = "exToolStripPickerBox2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 391);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pickerBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlsLibrary.Controls.exComboBox comboBox1;
        private ControlsLibrary.Controls.exPickerBox pickerBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private ControlsLibrary.Controls.ToolStripCheckBox toolStripCheckBox1;
        private ControlsLibrary.Controls.ToolStripNumericUpDown toolStripNumericUpDown1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private ControlsLibrary.Controls.ToolStripCheckBox toolStripCheckBox2;
        private ControlsLibrary.Controls.ToolStripNumericUpDown toolStripNumericUpDown2;
        private ControlsLibrary.Controls.exToolStripPickerBox exToolStripPickerBox1;
        private ControlsLibrary.Controls.exToolStripPickerBox exToolStripPickerBox2;
    }
}

