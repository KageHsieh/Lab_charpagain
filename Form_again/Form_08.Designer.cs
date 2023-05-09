namespace Form_again
{
    partial class Form_08
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
            this.buttonRegister = new System.Windows.Forms.Button();
            this.buttonRegister01 = new System.Windows.Forms.Button();
            this.buttonRegister02 = new System.Windows.Forms.Button();
            this.buttonQuestion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonRegister
            // 
            this.buttonRegister.Location = new System.Drawing.Point(12, 36);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(75, 23);
            this.buttonRegister.TabIndex = 0;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // buttonRegister01
            // 
            this.buttonRegister01.Location = new System.Drawing.Point(12, 86);
            this.buttonRegister01.Name = "buttonRegister01";
            this.buttonRegister01.Size = new System.Drawing.Size(75, 23);
            this.buttonRegister01.TabIndex = 1;
            this.buttonRegister01.Text = "Register01";
            this.buttonRegister01.UseVisualStyleBackColor = true;
            // 
            // buttonRegister02
            // 
            this.buttonRegister02.Location = new System.Drawing.Point(12, 133);
            this.buttonRegister02.Name = "buttonRegister02";
            this.buttonRegister02.Size = new System.Drawing.Size(75, 23);
            this.buttonRegister02.TabIndex = 2;
            this.buttonRegister02.Text = "Register02";
            this.buttonRegister02.UseVisualStyleBackColor = true;
            // 
            // buttonQuestion
            // 
            this.buttonQuestion.Location = new System.Drawing.Point(13, 185);
            this.buttonQuestion.Name = "buttonQuestion";
            this.buttonQuestion.Size = new System.Drawing.Size(138, 49);
            this.buttonQuestion.TabIndex = 3;
            this.buttonQuestion.Text = "請點回我答問題";
            this.buttonQuestion.UseVisualStyleBackColor = true;
            this.buttonQuestion.Click += new System.EventHandler(this.buttonQuestion_Click);
            // 
            // Form_08
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonQuestion);
            this.Controls.Add(this.buttonRegister02);
            this.Controls.Add(this.buttonRegister01);
            this.Controls.Add(this.buttonRegister);
            this.Name = "Form_08";
            this.Text = "Form_08";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Button buttonRegister01;
        private System.Windows.Forms.Button buttonRegister02;
        private System.Windows.Forms.Button buttonQuestion;
    }
}