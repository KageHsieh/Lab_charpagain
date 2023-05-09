namespace Form_again
{
    partial class Form_12
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
            this.buttonAddCut = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labelShow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAddCut
            // 
            this.buttonAddCut.Location = new System.Drawing.Point(65, 104);
            this.buttonAddCut.Name = "buttonAddCut";
            this.buttonAddCut.Size = new System.Drawing.Size(75, 23);
            this.buttonAddCut.TabIndex = 0;
            this.buttonAddCut.Text = "++,--";
            this.buttonAddCut.UseVisualStyleBackColor = true;
            this.buttonAddCut.Click += new System.EventHandler(this.buttonAddCut_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(65, 142);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // labelShow
            // 
            this.labelShow.AutoSize = true;
            this.labelShow.Location = new System.Drawing.Point(63, 65);
            this.labelShow.Name = "labelShow";
            this.labelShow.Size = new System.Drawing.Size(49, 12);
            this.labelShow.TabIndex = 2;
            this.labelShow.Text = "Count : 0";
            // 
            // Form_12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelShow);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonAddCut);
            this.Name = "Form_12";
            this.Text = "Form_12";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddCut;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelShow;
    }
}