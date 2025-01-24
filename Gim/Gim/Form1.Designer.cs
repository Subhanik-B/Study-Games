namespace Gim
{
    partial class Form1
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
            this.Checker = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.question4 = new Gim.Question();
            this.question3 = new Gim.Question();
            this.question2 = new Gim.Question();
            this.question1 = new Gim.Question();
            this.SuspendLayout();
            // 
            // Checker
            // 
            this.Checker.Location = new System.Drawing.Point(336, 511);
            this.Checker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Checker.Name = "Checker";
            this.Checker.Size = new System.Drawing.Size(181, 28);
            this.Checker.TabIndex = 1;
            this.Checker.Text = "Check Answers";
            this.Checker.UseVisualStyleBackColor = true;
            this.Checker.Click += new System.EventHandler(this.Checker_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(612, 507);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(557, 511);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Score:";
            // 
            // question4
            // 
            this.question4.correctAnswer = "china";
            this.question4.image = global::Gim.Properties.Resources.Forbidden_city_final;
            this.question4.isInt = false;
            this.question4.Location = new System.Drawing.Point(776, 15);
            this.question4.Margin = new System.Windows.Forms.Padding(5);
            this.question4.Name = "question4";
            this.question4.Queston = "Where was the Forbidden City?";
            this.question4.Size = new System.Drawing.Size(229, 244);
            this.question4.TabIndex = 6;
            // 
            // question3
            // 
            this.question3.correctAnswer = "china";
            this.question3.image = global::Gim.Properties.Resources.Forbidden_city_final;
            this.question3.isInt = false;
            this.question3.Location = new System.Drawing.Point(516, 15);
            this.question3.Margin = new System.Windows.Forms.Padding(5);
            this.question3.Name = "question3";
            this.question3.Queston = "Where was the Forbidden City?";
            this.question3.Size = new System.Drawing.Size(229, 244);
            this.question3.TabIndex = 5;
            // 
            // question2
            // 
            this.question2.correctAnswer = "1789";
            this.question2.image = global::Gim.Properties.Resources.download;
            this.question2.isInt = true;
            this.question2.Location = new System.Drawing.Point(267, 15);
            this.question2.Margin = new System.Windows.Forms.Padding(5);
            this.question2.Name = "question2";
            this.question2.Queston = "When did the French Revolution start?";
            this.question2.Size = new System.Drawing.Size(229, 244);
            this.question2.TabIndex = 4;
            // 
            // question1
            // 
            this.question1.correctAnswer = "china";
            this.question1.image = global::Gim.Properties.Resources.Forbidden_city_final;
            this.question1.isInt = false;
            this.question1.Location = new System.Drawing.Point(16, 15);
            this.question1.Margin = new System.Windows.Forms.Padding(5);
            this.question1.Name = "question1";
            this.question1.Queston = "Where was the Forbidden City?";
            this.question1.Size = new System.Drawing.Size(229, 244);
            this.question1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.question4);
            this.Controls.Add(this.question3);
            this.Controls.Add(this.question2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Checker);
            this.Controls.Add(this.question1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Question question1;
        private System.Windows.Forms.Button Checker;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private Question question2;
        private Question question3;
        private Question question4;
    }
}

