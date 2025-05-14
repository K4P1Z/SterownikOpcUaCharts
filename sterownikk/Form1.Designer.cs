namespace sterownikk
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
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox3 = new TextBox();
            label2 = new Label();
            button3 = new Button();
            button4 = new Button();
            cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            button5 = new Button();
            label3 = new Label();
            textBox4 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 20F);
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(461, 43);
            textBox1.TabIndex = 0;
            textBox1.Text = "opc.tcp://192.168.15.99:4840";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(501, 17);
            button1.Name = "button1";
            button1.Size = new Size(144, 47);
            button1.TabIndex = 1;
            button1.Text = "Connect";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(501, 70);
            button2.Name = "button2";
            button2.Size = new Size(144, 46);
            button2.TabIndex = 2;
            button2.Text = "Disconnect";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Red;
            pictureBox1.Location = new Point(12, 61);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(461, 13);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(76, 102);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 4;
            textBox2.Text = "ns=4;i=4";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 102);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 5;
            label1.Text = "NodeID";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(76, 131);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 139);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 7;
            label2.Text = "Value";
            // 
            // button3
            // 
            button3.Location = new Point(300, 98);
            button3.Name = "button3";
            button3.Size = new Size(103, 23);
            button3.TabIndex = 8;
            button3.Text = "Read Value";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(300, 135);
            button4.Name = "button4";
            button4.Size = new Size(103, 23);
            button4.TabIndex = 9;
            button4.Text = "Subscription";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // cartesianChart1
            // 
            cartesianChart1.BackColor = Color.DimGray;
            cartesianChart1.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            cartesianChart1.ForeColor = SystemColors.ControlText;
            cartesianChart1.Location = new Point(30, 199);
            cartesianChart1.Name = "cartesianChart1";
            cartesianChart1.Size = new Size(637, 239);
            cartesianChart1.TabIndex = 10;
            cartesianChart1.Text = "cartesianChart1";
            // 
            // button5
            // 
            button5.Location = new Point(300, 170);
            button5.Name = "button5";
            button5.Size = new Size(103, 23);
            button5.TabIndex = 13;
            button5.Text = "Write data";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 174);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 12;
            label3.Text = "Write";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(76, 166);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(label3);
            Controls.Add(textBox4);
            Controls.Add(cartesianChart1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(textBox3);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox3;
        private Label label2;
        private Button button3;
        private Button button4;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private Button button5;
        private Label label3;
        private TextBox textBox4;
    }
}
