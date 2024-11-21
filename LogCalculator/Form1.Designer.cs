namespace LogCalculator
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
            label1 = new Label();
            base_log = new TextBox();
            upper_fraction = new TextBox();
            lower_fraction = new TextBox();
            label2 = new Label();
            label3 = new Label();
            result = new TextBox();
            button1 = new Button();
            label4 = new Label();
            showA = new TextBox();
            saveA = new Button();
            saveB = new Button();
            showB = new TextBox();
            label5 = new Label();
            saveC = new Button();
            showC = new TextBox();
            label6 = new Label();
            label7 = new Label();
            resultFraction = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 29);
            label1.Name = "label1";
            label1.Size = new Size(34, 20);
            label1.TabIndex = 0;
            label1.Text = "Log";
            // 
            // base_log
            // 
            base_log.Location = new Point(57, 52);
            base_log.Name = "base_log";
            base_log.Size = new Size(64, 27);
            base_log.TabIndex = 1;
            // 
            // upper_fraction
            // 
            upper_fraction.Location = new Point(137, 12);
            upper_fraction.Name = "upper_fraction";
            upper_fraction.Size = new Size(75, 27);
            upper_fraction.TabIndex = 2;
            // 
            // lower_fraction
            // 
            lower_fraction.Location = new Point(137, 52);
            lower_fraction.Name = "lower_fraction";
            lower_fraction.Size = new Size(75, 27);
            lower_fraction.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(137, 29);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 4;
            label2.Text = "_____________";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(230, 29);
            label3.Name = "label3";
            label3.Size = new Size(19, 20);
            label3.TabIndex = 5;
            label3.Text = "=";
            // 
            // result
            // 
            result.BackColor = Color.White;
            result.Location = new Point(264, 29);
            result.Name = "result";
            result.ReadOnly = true;
            result.Size = new Size(75, 27);
            result.TabIndex = 6;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(27, 97);
            button1.Name = "button1";
            button1.Size = new Size(209, 66);
            button1.TabIndex = 7;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 187);
            label4.Name = "label4";
            label4.Size = new Size(37, 20);
            label4.TabIndex = 8;
            label4.Text = "A = ";
            // 
            // showA
            // 
            showA.BackColor = Color.White;
            showA.Location = new Point(60, 184);
            showA.Name = "showA";
            showA.ReadOnly = true;
            showA.Size = new Size(75, 27);
            showA.TabIndex = 9;
            showA.Text = "0";
            // 
            // saveA
            // 
            saveA.Location = new Point(155, 184);
            saveA.Name = "saveA";
            saveA.Size = new Size(94, 29);
            saveA.TabIndex = 10;
            saveA.Text = "Save";
            saveA.UseVisualStyleBackColor = true;
            saveA.Click += button2_Click;
            // 
            // saveB
            // 
            saveB.Location = new Point(155, 219);
            saveB.Name = "saveB";
            saveB.Size = new Size(94, 29);
            saveB.TabIndex = 13;
            saveB.Text = "Save";
            saveB.UseVisualStyleBackColor = true;
            saveB.Click += saveB_Click;
            // 
            // showB
            // 
            showB.BackColor = Color.White;
            showB.Location = new Point(60, 219);
            showB.Name = "showB";
            showB.ReadOnly = true;
            showB.Size = new Size(75, 27);
            showB.TabIndex = 12;
            showB.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 222);
            label5.Name = "label5";
            label5.Size = new Size(36, 20);
            label5.TabIndex = 11;
            label5.Text = "B = ";
            // 
            // saveC
            // 
            saveC.Location = new Point(155, 254);
            saveC.Name = "saveC";
            saveC.Size = new Size(94, 29);
            saveC.TabIndex = 16;
            saveC.Text = "Save";
            saveC.UseVisualStyleBackColor = true;
            saveC.Click += saveC_Click;
            // 
            // showC
            // 
            showC.BackColor = Color.White;
            showC.Location = new Point(60, 254);
            showC.Name = "showC";
            showC.ReadOnly = true;
            showC.Size = new Size(75, 27);
            showC.TabIndex = 15;
            showC.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 257);
            label6.Name = "label6";
            label6.Size = new Size(36, 20);
            label6.TabIndex = 14;
            label6.Text = "C = ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(268, 94);
            label7.Name = "label7";
            label7.Size = new Size(72, 20);
            label7.TabIndex = 17;
            label7.Text = "Fraction=";
            // 
            // resultFraction
            // 
            resultFraction.BackColor = Color.White;
            resultFraction.Location = new Point(268, 117);
            resultFraction.Name = "resultFraction";
            resultFraction.ReadOnly = true;
            resultFraction.Size = new Size(75, 27);
            resultFraction.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 427);
            Controls.Add(resultFraction);
            Controls.Add(label7);
            Controls.Add(saveC);
            Controls.Add(showC);
            Controls.Add(label6);
            Controls.Add(saveB);
            Controls.Add(showB);
            Controls.Add(label5);
            Controls.Add(saveA);
            Controls.Add(showA);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(result);
            Controls.Add(label3);
            Controls.Add(lower_fraction);
            Controls.Add(upper_fraction);
            Controls.Add(base_log);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox base_log;
        private TextBox upper_fraction;
        private TextBox lower_fraction;
        private Label label2;
        private Label label3;
        private TextBox result;
        private Button button1;
        private Label label4;
        private TextBox showA;
        private Button saveA;
        private Button saveB;
        private TextBox showB;
        private Label label5;
        private Button saveC;
        private TextBox showC;
        private Label label6;
        private Label label7;
        private TextBox resultFraction;
    }
}
