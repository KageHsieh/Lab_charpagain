namespace Form_again
{
    partial class helloForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSayHello = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSayHello
            // 
            this.buttonSayHello.Location = new System.Drawing.Point(595, 200);
            this.buttonSayHello.Name = "buttonSayHello";
            this.buttonSayHello.Size = new System.Drawing.Size(75, 23);
            this.buttonSayHello.TabIndex = 0;
            this.buttonSayHello.Text = "Hello!";
            this.buttonSayHello.UseVisualStyleBackColor = true;
            this.buttonSayHello.Click += new System.EventHandler(this.buttonSayHello_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(595, 159);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 22);
            this.textBoxName.TabIndex = 1;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelName.Location = new System.Drawing.Point(512, 162);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(65, 12);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "請輸入姓名";
            // 
            // helloForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonSayHello);
            this.Name = "helloForm";
            this.Text = "Hello Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSayHello;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
    }
}

