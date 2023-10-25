namespace achmut
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            button5 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(92, 178);
            button1.Name = "button1";
            button1.Size = new Size(330, 122);
            button1.TabIndex = 0;
            button1.Text = "Nová Hra";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(92, 367);
            button2.Name = "button2";
            button2.Size = new Size(330, 122);
            button2.TabIndex = 1;
            button2.Text = "nastavení";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(99, 565);
            button3.Name = "button3";
            button3.Size = new Size(330, 122);
            button3.TabIndex = 2;
            button3.Text = "Načíst";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(92, 758);
            button4.Name = "button4";
            button4.Size = new Size(330, 122);
            button4.TabIndex = 3;
            button4.Text = "Ukončit";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(99, 22);
            label1.Name = "label1";
            label1.Size = new Size(323, 128);
            label1.TabIndex = 4;
            label1.Text = "Game";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(183, 963);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 5;
            // 
            // button5
            // 
            button5.Location = new Point(183, 1000);
            button5.Name = "button5";
            button5.Size = new Size(150, 54);
            button5.TabIndex = 6;
            button5.Text = "nacti hrace";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(515, 1267);
            Controls.Add(button5);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
        private TextBox textBox1;
        private Button button5;
    }
}