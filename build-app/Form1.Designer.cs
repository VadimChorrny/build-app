
namespace build_app
{
    partial class RegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            this.tbNameCompany = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lblLogoNameCopmany = new System.Windows.Forms.Label();
            this.lblLogoEmail = new System.Windows.Forms.Label();
            this.lblLogoPass = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.chSignIn = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tbNameCompany
            // 
            this.tbNameCompany.Location = new System.Drawing.Point(297, 119);
            this.tbNameCompany.Name = "tbNameCompany";
            this.tbNameCompany.Size = new System.Drawing.Size(223, 27);
            this.tbNameCompany.TabIndex = 0;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(297, 213);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(223, 27);
            this.tbEmail.TabIndex = 1;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(297, 301);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(223, 27);
            this.tbPassword.TabIndex = 2;
            // 
            // lblLogoNameCopmany
            // 
            this.lblLogoNameCopmany.AutoSize = true;
            this.lblLogoNameCopmany.Location = new System.Drawing.Point(297, 85);
            this.lblLogoNameCopmany.Name = "lblLogoNameCopmany";
            this.lblLogoNameCopmany.Size = new System.Drawing.Size(149, 20);
            this.lblLogoNameCopmany.TabIndex = 3;
            this.lblLogoNameCopmany.Text = "Enter name company";
            // 
            // lblLogoEmail
            // 
            this.lblLogoEmail.AutoSize = true;
            this.lblLogoEmail.Location = new System.Drawing.Point(297, 177);
            this.lblLogoEmail.Name = "lblLogoEmail";
            this.lblLogoEmail.Size = new System.Drawing.Size(117, 20);
            this.lblLogoEmail.TabIndex = 4;
            this.lblLogoEmail.Text = "Enter your email";
            // 
            // lblLogoPass
            // 
            this.lblLogoPass.AutoSize = true;
            this.lblLogoPass.Location = new System.Drawing.Point(297, 267);
            this.lblLogoPass.Name = "lblLogoPass";
            this.lblLogoPass.Size = new System.Drawing.Size(143, 20);
            this.lblLogoPass.TabIndex = 5;
            this.lblLogoPass.Text = "Enter your password";
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(297, 368);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(223, 39);
            this.btnEnter.TabIndex = 6;
            this.btnEnter.Text = "Register new account";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // chSignIn
            // 
            this.chSignIn.AutoSize = true;
            this.chSignIn.Location = new System.Drawing.Point(370, 414);
            this.chSignIn.Name = "chSignIn";
            this.chSignIn.Size = new System.Drawing.Size(76, 24);
            this.chSignIn.TabIndex = 7;
            this.chSignIn.Text = "Sign In";
            this.chSignIn.UseVisualStyleBackColor = true;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chSignIn);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.lblLogoPass);
            this.Controls.Add(this.lblLogoEmail);
            this.Controls.Add(this.lblLogoNameCopmany);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbNameCompany);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistrationForm";
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNameCompany;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lblLogoNameCopmany;
        private System.Windows.Forms.Label lblLogoEmail;
        private System.Windows.Forms.Label lblLogoPass;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.CheckBox chSignIn;
    }
}

