namespace Form_again
{
    partial class Form2
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
            this.buttonHelloForm = new System.Windows.Forms.Button();
            this.buttonMethodPratice = new System.Windows.Forms.Button();
            this.buttonReturnPractice = new System.Windows.Forms.Button();
            this.buttonEnc = new System.Windows.Forms.Button();
            this.buttonPartialClass = new System.Windows.Forms.Button();
            this.buttonMyNewClass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonHelloForm
            // 
            this.buttonHelloForm.Location = new System.Drawing.Point(639, 38);
            this.buttonHelloForm.Name = "buttonHelloForm";
            this.buttonHelloForm.Size = new System.Drawing.Size(131, 45);
            this.buttonHelloForm.TabIndex = 0;
            this.buttonHelloForm.Text = "Hello Form";
            this.buttonHelloForm.UseVisualStyleBackColor = true;
            this.buttonHelloForm.Click += new System.EventHandler(this.buttonHelloForm_Click);
            // 
            // buttonMethodPratice
            // 
            this.buttonMethodPratice.Location = new System.Drawing.Point(639, 106);
            this.buttonMethodPratice.Name = "buttonMethodPratice";
            this.buttonMethodPratice.Size = new System.Drawing.Size(131, 45);
            this.buttonMethodPratice.TabIndex = 1;
            this.buttonMethodPratice.Text = "Method Practice";
            this.buttonMethodPratice.UseVisualStyleBackColor = true;
            this.buttonMethodPratice.Click += new System.EventHandler(this.buttonMethodPractice_Click);
            // 
            // buttonReturnPractice
            // 
            this.buttonReturnPractice.Location = new System.Drawing.Point(639, 172);
            this.buttonReturnPractice.Name = "buttonReturnPractice";
            this.buttonReturnPractice.Size = new System.Drawing.Size(131, 45);
            this.buttonReturnPractice.TabIndex = 2;
            this.buttonReturnPractice.Text = "Return Practice";
            this.buttonReturnPractice.UseVisualStyleBackColor = true;
            this.buttonReturnPractice.Click += new System.EventHandler(this.buttonReturnPractice_Click);
            // 
            // buttonEnc
            // 
            this.buttonEnc.Location = new System.Drawing.Point(477, 38);
            this.buttonEnc.Name = "buttonEnc";
            this.buttonEnc.Size = new System.Drawing.Size(131, 45);
            this.buttonEnc.TabIndex = 3;
            this.buttonEnc.Text = "封裝";
            this.buttonEnc.UseVisualStyleBackColor = true;
            this.buttonEnc.Click += new System.EventHandler(this.buttonEnc_Click);
            // 
            // buttonPartialClass
            // 
            this.buttonPartialClass.Location = new System.Drawing.Point(477, 106);
            this.buttonPartialClass.Name = "buttonPartialClass";
            this.buttonPartialClass.Size = new System.Drawing.Size(131, 45);
            this.buttonPartialClass.TabIndex = 4;
            this.buttonPartialClass.Text = "Partial class";
            this.buttonPartialClass.UseVisualStyleBackColor = true;
            this.buttonPartialClass.Click += new System.EventHandler(this.buttonPartialClass_Click);
            // 
            // buttonMyNewClass
            // 
            this.buttonMyNewClass.Location = new System.Drawing.Point(639, 241);
            this.buttonMyNewClass.Name = "buttonMyNewClass";
            this.buttonMyNewClass.Size = new System.Drawing.Size(131, 45);
            this.buttonMyNewClass.TabIndex = 5;
            this.buttonMyNewClass.Text = "My New Class";
            this.buttonMyNewClass.UseVisualStyleBackColor = true;
            this.buttonMyNewClass.Click += new System.EventHandler(this.buttonMyNewClass_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonMyNewClass);
            this.Controls.Add(this.buttonPartialClass);
            this.Controls.Add(this.buttonEnc);
            this.Controls.Add(this.buttonReturnPractice);
            this.Controls.Add(this.buttonMethodPratice);
            this.Controls.Add(this.buttonHelloForm);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonHelloForm;
        private System.Windows.Forms.Button buttonMethodPratice;
        private System.Windows.Forms.Button buttonReturnPractice;
        private System.Windows.Forms.Button buttonEnc;
        private System.Windows.Forms.Button buttonPartialClass;
        private System.Windows.Forms.Button buttonMyNewClass;
    }
}