
namespace build_app
{
    partial class UserForm
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
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.lblLogoSearch = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbSorting = new System.Windows.Forms.ComboBox();
            this.lblLogoTypeSorting = new System.Windows.Forms.Label();
            this.pbAccount = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(253, 130);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(267, 27);
            this.tbSearch.TabIndex = 0;
            // 
            // lblLogoSearch
            // 
            this.lblLogoSearch.AutoSize = true;
            this.lblLogoSearch.Location = new System.Drawing.Point(253, 89);
            this.lblLogoSearch.Name = "lblLogoSearch";
            this.lblLogoSearch.Size = new System.Drawing.Size(209, 20);
            this.lblLogoSearch.TabIndex = 1;
            this.lblLogoSearch.Text = "Enter name product for search";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(253, 273);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(267, 45);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // cbSorting
            // 
            this.cbSorting.FormattingEnabled = true;
            this.cbSorting.Location = new System.Drawing.Point(253, 220);
            this.cbSorting.Name = "cbSorting";
            this.cbSorting.Size = new System.Drawing.Size(267, 28);
            this.cbSorting.TabIndex = 3;
            // 
            // lblLogoTypeSorting
            // 
            this.lblLogoTypeSorting.AutoSize = true;
            this.lblLogoTypeSorting.Location = new System.Drawing.Point(253, 182);
            this.lblLogoTypeSorting.Name = "lblLogoTypeSorting";
            this.lblLogoTypeSorting.Size = new System.Drawing.Size(141, 20);
            this.lblLogoTypeSorting.TabIndex = 4;
            this.lblLogoTypeSorting.Text = "Choose type sorting";
            // 
            // pbAccount
            // 
            this.pbAccount.Location = new System.Drawing.Point(721, 1);
            this.pbAccount.Name = "pbAccount";
            this.pbAccount.Size = new System.Drawing.Size(79, 72);
            this.pbAccount.TabIndex = 5;
            this.pbAccount.TabStop = false;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbAccount);
            this.Controls.Add(this.lblLogoTypeSorting);
            this.Controls.Add(this.cbSorting);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblLogoSearch);
            this.Controls.Add(this.tbSearch);
            this.Name = "UserForm";
            this.Text = "UserForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbAccount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label lblLogoSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cbSorting;
        private System.Windows.Forms.Label lblLogoTypeSorting;
        private System.Windows.Forms.PictureBox pbAccount;
    }
}