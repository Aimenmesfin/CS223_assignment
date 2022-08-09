namespace assignment3
{
    partial class login
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
            this.lblun = new System.Windows.Forms.Label();
            this.lblps = new System.Windows.Forms.Label();
            this.txtun = new System.Windows.Forms.TextBox();
            this.txtps = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblun
            // 
            this.lblun.AutoSize = true;
            this.lblun.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblun.Location = new System.Drawing.Point(164, 87);
            this.lblun.Name = "lblun";
            this.lblun.Size = new System.Drawing.Size(71, 17);
            this.lblun.TabIndex = 0;
            this.lblun.Text = "username";
            // 
            // lblps
            // 
            this.lblps.AutoSize = true;
            this.lblps.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblps.Location = new System.Drawing.Point(164, 141);
            this.lblps.Name = "lblps";
            this.lblps.Size = new System.Drawing.Size(68, 17);
            this.lblps.TabIndex = 1;
            this.lblps.Text = "password";
            // 
            // txtun
            // 
            this.txtun.Location = new System.Drawing.Point(276, 82);
            this.txtun.Name = "txtun";
            this.txtun.Size = new System.Drawing.Size(265, 22);
            this.txtun.TabIndex = 2;
            // 
            // txtps
            // 
            this.txtps.Location = new System.Drawing.Point(276, 136);
            this.txtps.Name = "txtps";
            this.txtps.Size = new System.Drawing.Size(265, 22);
            this.txtps.TabIndex = 3;
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(224, 207);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(75, 39);
            this.btnlogin.TabIndex = 4;
            this.btnlogin.Text = "log in";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(403, 207);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 39);
            this.btnexit.TabIndex = 5;
            this.btnexit.Text = "exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.txtps);
            this.Controls.Add(this.txtun);
            this.Controls.Add(this.lblps);
            this.Controls.Add(this.lblun);
            this.Name = "login";
            this.Text = "login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblun;
        private System.Windows.Forms.Label lblps;
        private System.Windows.Forms.TextBox txtun;
        private System.Windows.Forms.TextBox txtps;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Button btnexit;
    }
}