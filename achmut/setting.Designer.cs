namespace achmut
{
    partial class setting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            colorDialog1 = new ColorDialog();
            fontDialog1 = new FontDialog();
            button1 = new Button();
            button2 = new Button();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 188);
            button1.Name = "button1";
            button1.Size = new Size(225, 147);
            button1.TabIndex = 0;
            button1.Text = "Uložit hodnoty";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(259, 188);
            button2.Name = "button2";
            button2.Size = new Size(225, 147);
            button2.TabIndex = 1;
            button2.Text = "Zpět do menu";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(12, 153);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(117, 29);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "FullScreen";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // setting
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 385);
            Controls.Add(checkBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "setting";
            Text = "setting";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ColorDialog colorDialog1;
        private FontDialog fontDialog1;
        private Button button1;
        private Button button2;
        private CheckBox checkBox1;
    }
}