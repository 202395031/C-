namespace UnitConversionForm
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            textBox1 = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("맑은 고딕", 15F);
            button1.Location = new Point(12, 85);
            button1.Name = "button1";
            button1.Size = new Size(348, 72);
            button1.TabIndex = 0;
            button1.Text = "단위환산";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 15F);
            label2.Location = new Point(12, 175);
            label2.Name = "label2";
            label2.Size = new Size(143, 35);
            label2.TabIndex = 2;
            label2.Text = "inch 입력 : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("맑은 고딕", 15F);
            label3.Location = new Point(12, 226);
            label3.Name = "label3";
            label3.Size = new Size(219, 35);
            label3.TabIndex = 3;
            label3.Text = "inch to cm 결과 : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("맑은 고딕", 15F);
            label4.Location = new Point(221, 226);
            label4.Name = "label4";
            label4.Size = new Size(0, 35);
            label4.TabIndex = 4;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("맑은 고딕", 15F);
            textBox1.Location = new Point(150, 172);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(149, 41);
            textBox1.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("맑은 고딕", 15F);
            label5.Location = new Point(12, 284);
            label5.Name = "label5";
            label5.Size = new Size(113, 35);
            label5.TabIndex = 6;
            label5.Text = "0초 경과";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 420);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "202395031 천승용";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label2;
        private Label label3;
        private Label label4;
        private System.Windows.Forms.Timer timer1;
        private TextBox textBox1;
        private Label label5;
    }
}
