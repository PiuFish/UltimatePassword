namespace UltimatePassword3104S204
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.bntok = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.lblmessage = new System.Windows.Forms.Label();
            this.lblanswer = new System.Windows.Forms.Label();
            this.btnshowanswer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 48F);
            this.label1.Location = new System.Drawing.Point(31, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "輸入密碼:";
            // 
            // txtpassword
            // 
            this.txtpassword.Font = new System.Drawing.Font("新細明體", 48F);
            this.txtpassword.Location = new System.Drawing.Point(338, 110);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(185, 84);
            this.txtpassword.TabIndex = 1;
            // 
            // bntok
            // 
            this.bntok.Font = new System.Drawing.Font("新細明體", 35F);
            this.bntok.Location = new System.Drawing.Point(550, 137);
            this.bntok.Name = "bntok";
            this.bntok.Size = new System.Drawing.Size(132, 57);
            this.bntok.TabIndex = 2;
            this.bntok.Text = "確定";
            this.bntok.UseVisualStyleBackColor = true;
            this.bntok.Click += new System.EventHandler(this.bntok_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 12);
            this.label2.TabIndex = 3;
            // 
            // lblpassword
            // 
            this.lblpassword.Font = new System.Drawing.Font("新細明體", 48F);
            this.lblpassword.Location = new System.Drawing.Point(338, 51);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(185, 56);
            this.lblpassword.TabIndex = 4;
            // 
            // lblmessage
            // 
            this.lblmessage.Font = new System.Drawing.Font("新細明體", 48F);
            this.lblmessage.Location = new System.Drawing.Point(54, 235);
            this.lblmessage.Name = "lblmessage";
            this.lblmessage.Size = new System.Drawing.Size(555, 86);
            this.lblmessage.TabIndex = 5;
            // 
            // lblanswer
            // 
            this.lblanswer.Font = new System.Drawing.Font("新細明體", 16F);
            this.lblanswer.Location = new System.Drawing.Point(570, 24);
            this.lblanswer.Name = "lblanswer";
            this.lblanswer.Size = new System.Drawing.Size(100, 83);
            this.lblanswer.TabIndex = 6;
            this.lblanswer.Visible = false;
            // 
            // btnshowanswer
            // 
            this.btnshowanswer.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnshowanswer.Location = new System.Drawing.Point(676, 62);
            this.btnshowanswer.Name = "btnshowanswer";
            this.btnshowanswer.Size = new System.Drawing.Size(92, 44);
            this.btnshowanswer.TabIndex = 7;
            this.btnshowanswer.Text = "顯示答案";
            this.btnshowanswer.UseVisualStyleBackColor = true;
            this.btnshowanswer.Click += new System.EventHandler(this.btnshowanswer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnshowanswer);
            this.Controls.Add(this.lblanswer);
            this.Controls.Add(this.lblmessage);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bntok);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Button bntok;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Label lblmessage;
        private System.Windows.Forms.Label lblanswer;
        private System.Windows.Forms.Button btnshowanswer;
    }
}

