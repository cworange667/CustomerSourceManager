namespace ClientSourceManager
{
    partial class Login
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
            this.conformButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.userPasswordLabel = new System.Windows.Forms.Label();
            this.userNameText = new System.Windows.Forms.TextBox();
            this.userPasswordText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // conformButton
            // 
            this.conformButton.Location = new System.Drawing.Point(26, 105);
            this.conformButton.Name = "conformButton";
            this.conformButton.Size = new System.Drawing.Size(75, 23);
            this.conformButton.TabIndex = 0;
            this.conformButton.Text = "确定";
            this.conformButton.UseVisualStyleBackColor = true;
            this.conformButton.Click += new System.EventHandler(this.conformButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(149, 105);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "取消";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(24, 20);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(65, 12);
            this.userNameLabel.TabIndex = 2;
            this.userNameLabel.Text = "用户名称：";
            // 
            // userPasswordLabel
            // 
            this.userPasswordLabel.AutoSize = true;
            this.userPasswordLabel.Location = new System.Drawing.Point(24, 58);
            this.userPasswordLabel.Name = "userPasswordLabel";
            this.userPasswordLabel.Size = new System.Drawing.Size(65, 12);
            this.userPasswordLabel.TabIndex = 3;
            this.userPasswordLabel.Text = "用户密码：";
            // 
            // userNameText
            // 
            this.userNameText.Location = new System.Drawing.Point(124, 17);
            this.userNameText.Name = "userNameText";
            this.userNameText.Size = new System.Drawing.Size(100, 21);
            this.userNameText.TabIndex = 4;
            this.userNameText.Text = "namea";
            // 
            // userPasswordText
            // 
            this.userPasswordText.Location = new System.Drawing.Point(124, 55);
            this.userPasswordText.Name = "userPasswordText";
            this.userPasswordText.PasswordChar = '*';
            this.userPasswordText.Size = new System.Drawing.Size(100, 21);
            this.userPasswordText.TabIndex = 5;
            this.userPasswordText.Text = "123123";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 151);
            this.Controls.Add(this.userPasswordText);
            this.Controls.Add(this.userNameText);
            this.Controls.Add(this.userPasswordLabel);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.conformButton);
            this.Name = "Login";
            this.Text = "登录";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.btnClose_Click);
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button conformButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label userPasswordLabel;
        private System.Windows.Forms.TextBox userNameText;
        private System.Windows.Forms.TextBox userPasswordText;
    }
}