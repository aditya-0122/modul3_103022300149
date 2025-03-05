namespace Modul3_103022300149_2
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
            Nomor1 = new Button();
            Nomor3 = new Button();
            Nomor2 = new Button();
            Nomor4 = new Button();
            Nomor5 = new Button();
            Nomor6 = new Button();
            Nomor7 = new Button();
            Nomor8 = new Button();
            Nomor9 = new Button();
            Nomor0 = new Button();
            Equal = new Button();
            Plus = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // Nomor1
            // 
            Nomor1.Location = new Point(228, 119);
            Nomor1.Name = "Nomor1";
            Nomor1.Size = new Size(46, 42);
            Nomor1.TabIndex = 1;
            Nomor1.Text = "1";
            Nomor1.UseVisualStyleBackColor = true;
            Nomor1.Click += Nomor1_Click;
            // 
            // Nomor3
            // 
            Nomor3.Location = new Point(332, 119);
            Nomor3.Name = "Nomor3";
            Nomor3.Size = new Size(46, 42);
            Nomor3.TabIndex = 2;
            Nomor3.Text = "3";
            Nomor3.UseVisualStyleBackColor = true;
            Nomor3.Click += Nomor3_Click;
            // 
            // Nomor2
            // 
            Nomor2.Location = new Point(280, 119);
            Nomor2.Name = "Nomor2";
            Nomor2.Size = new Size(46, 42);
            Nomor2.TabIndex = 3;
            Nomor2.Text = "2";
            Nomor2.UseVisualStyleBackColor = true;
            Nomor2.Click += Nomor2_Click;
            // 
            // Nomor4
            // 
            Nomor4.Location = new Point(228, 167);
            Nomor4.Name = "Nomor4";
            Nomor4.Size = new Size(46, 42);
            Nomor4.TabIndex = 4;
            Nomor4.Text = "4";
            Nomor4.UseVisualStyleBackColor = true;
            Nomor4.Click += Nomor4_Click;
            // 
            // Nomor5
            // 
            Nomor5.Location = new Point(280, 167);
            Nomor5.Name = "Nomor5";
            Nomor5.Size = new Size(46, 42);
            Nomor5.TabIndex = 5;
            Nomor5.Text = "5";
            Nomor5.UseVisualStyleBackColor = true;
            Nomor5.Click += Nomor5_Click;
            // 
            // Nomor6
            // 
            Nomor6.Location = new Point(332, 167);
            Nomor6.Name = "Nomor6";
            Nomor6.Size = new Size(46, 42);
            Nomor6.TabIndex = 6;
            Nomor6.Text = "6";
            Nomor6.UseVisualStyleBackColor = true;
            Nomor6.Click += Nomor6_Click;
            // 
            // Nomor7
            // 
            Nomor7.Location = new Point(228, 215);
            Nomor7.Name = "Nomor7";
            Nomor7.Size = new Size(46, 42);
            Nomor7.TabIndex = 7;
            Nomor7.Text = "7";
            Nomor7.UseVisualStyleBackColor = true;
            Nomor7.Click += Nomor7_Click;
            // 
            // Nomor8
            // 
            Nomor8.Location = new Point(280, 215);
            Nomor8.Name = "Nomor8";
            Nomor8.Size = new Size(46, 42);
            Nomor8.TabIndex = 8;
            Nomor8.Text = "8";
            Nomor8.UseVisualStyleBackColor = true;
            Nomor8.Click += Nomor8_Click;
            // 
            // Nomor9
            // 
            Nomor9.Location = new Point(332, 215);
            Nomor9.Name = "Nomor9";
            Nomor9.Size = new Size(46, 42);
            Nomor9.TabIndex = 9;
            Nomor9.Text = "9";
            Nomor9.UseVisualStyleBackColor = true;
            Nomor9.Click += Nomor9_Click;
            // 
            // Nomor0
            // 
            Nomor0.Location = new Point(280, 263);
            Nomor0.Name = "Nomor0";
            Nomor0.Size = new Size(46, 42);
            Nomor0.TabIndex = 10;
            Nomor0.Text = "0";
            Nomor0.UseVisualStyleBackColor = true;
            Nomor0.Click += Nomor0_Click;
            // 
            // Equal
            // 
            Equal.Location = new Point(436, 167);
            Equal.Name = "Equal";
            Equal.Size = new Size(46, 42);
            Equal.TabIndex = 12;
            Equal.Text = "=";
            Equal.UseVisualStyleBackColor = true;
            Equal.Click += Equal_Click;
            // 
            // Plus
            // 
            Plus.Location = new Point(436, 119);
            Plus.Name = "Plus";
            Plus.Size = new Size(46, 42);
            Plus.TabIndex = 13;
            Plus.Text = "+";
            Plus.UseVisualStyleBackColor = true;
            Plus.Click += Plus_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Location = new Point(228, 86);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 14;
            label1.Text = "Masukkan Angka";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(Plus);
            Controls.Add(Equal);
            Controls.Add(Nomor0);
            Controls.Add(Nomor9);
            Controls.Add(Nomor8);
            Controls.Add(Nomor7);
            Controls.Add(Nomor6);
            Controls.Add(Nomor5);
            Controls.Add(Nomor4);
            Controls.Add(Nomor2);
            Controls.Add(Nomor3);
            Controls.Add(Nomor1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Nomor1;
        private Button Nomor3;
        private Button Nomor2;
        private Button Nomor4;
        private Button Nomor5;
        private Button Nomor6;
        private Button Nomor7;
        private Button Nomor8;
        private Button Nomor9;
        private Button Nomor0;
        private Button button11;
        private Button Equal;
        private Button Plus;
        private Label label1;
    }
}
