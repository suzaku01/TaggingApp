namespace TaggingApp
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
            label2 = new Label();
            openFileDialog1 = new OpenFileDialog();
            textBox1 = new TextBox();
            button3 = new Button();
            numericUpDown1 = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            folderBrowserDialog1 = new FolderBrowserDialog();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 68);
            button1.Name = "button1";
            button1.Size = new Size(96, 23);
            button1.TabIndex = 0;
            button1.Text = "Select file";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 27);
            button2.Name = "button2";
            button2.Size = new Size(148, 23);
            button2.TabIndex = 1;
            button2.Text = "Install requirements";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(422, 15);
            label2.TabIndex = 3;
            label2.Text = "If you are opening this app for the first time, please run Install requirements first";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(181, 68);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(443, 23);
            textBox1.TabIndex = 4;
            // 
            // button3
            // 
            button3.Location = new Point(12, 97);
            button3.Name = "button3";
            button3.Size = new Size(96, 23);
            button3.TabIndex = 5;
            button3.Text = "Select folder";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.DecimalPlaces = 1;
            numericUpDown1.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDown1.Location = new Point(85, 132);
            numericUpDown1.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(54, 23);
            numericUpDown1.TabIndex = 6;
            numericUpDown1.Value = new decimal(new int[] { 3, 0, 0, 65536 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 134);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 7;
            label3.Text = "Threshold";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(145, 134);
            label4.Name = "label4";
            label4.Size = new Size(196, 15);
            label4.TabIndex = 8;
            label4.Text = "Low Threshold means more detailed";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(114, 72);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 9;
            label5.Text = "result=>";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(114, 101);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Lime;
            label7.Location = new Point(166, 31);
            label7.Name = "label7";
            label7.Size = new Size(0, 15);
            label7.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(655, 174);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(numericUpDown1);
            Controls.Add(button3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "TaggingApp";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private OpenFileDialog openFileDialog1;
        private TextBox textBox1;
        private Button button3;
        private NumericUpDown numericUpDown1;
        private Label label3;
        private Label label4;
        private Label label5;
        private FolderBrowserDialog folderBrowserDialog1;
        private Label label6;
        private Label label7;
    }
}
