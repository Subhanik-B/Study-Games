namespace Gim
{
    partial class Question
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Picture = new System.Windows.Forms.PictureBox();
            this.Prompt = new System.Windows.Forms.TextBox();
            this.Answer = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // Picture
            // 
            this.Picture.Location = new System.Drawing.Point(9, 3);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(144, 123);
            this.Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Picture.TabIndex = 0;
            this.Picture.TabStop = false;
            // 
            // Prompt
            // 
            this.Prompt.Location = new System.Drawing.Point(9, 133);
            this.Prompt.Multiline = true;
            this.Prompt.Name = "Prompt";
            this.Prompt.ReadOnly = true;
            this.Prompt.Size = new System.Drawing.Size(166, 34);
            this.Prompt.TabIndex = 1;
            // 
            // Answer
            // 
            this.Answer.Location = new System.Drawing.Point(9, 173);
            this.Answer.Multiline = true;
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(166, 20);
            this.Answer.TabIndex = 2;
            // 
            // Question
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.Prompt);
            this.Controls.Add(this.Picture);
            this.Name = "Question";
            this.Size = new System.Drawing.Size(242, 221);
            this.Load += new System.EventHandler(this.Question_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Picture;
        private System.Windows.Forms.TextBox Prompt;
        private System.Windows.Forms.TextBox Answer;
    }
}
