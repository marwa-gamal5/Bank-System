
namespace projectfinal
{
    partial class main_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_form));
            this.panel_menu = new System.Windows.Forms.Panel();
            this.panel_services = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button_complaint = new System.Windows.Forms.Button();
            this.button_service = new System.Windows.Forms.Button();
            this.panel_account = new System.Windows.Forms.Panel();
            this.button_display_ac_info = new System.Windows.Forms.Button();
            this.button_create_ac = new System.Windows.Forms.Button();
            this.button_account = new System.Windows.Forms.Button();
            this.panel_transaction = new System.Windows.Forms.Panel();
            this.button_withdraw = new System.Windows.Forms.Button();
            this.button_deposit = new System.Windows.Forms.Button();
            this.button_check = new System.Windows.Forms.Button();
            this.button_transaction = new System.Windows.Forms.Button();
            this.panel_logo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_Logout = new System.Windows.Forms.Button();
            this.panel_menu.SuspendLayout();
            this.panel_services.SuspendLayout();
            this.panel_account.SuspendLayout();
            this.panel_transaction.SuspendLayout();
            this.panel_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_menu.Controls.Add(this.panel_services);
            this.panel_menu.Controls.Add(this.button_service);
            this.panel_menu.Controls.Add(this.panel_account);
            this.panel_menu.Controls.Add(this.button_account);
            this.panel_menu.Controls.Add(this.panel_transaction);
            this.panel_menu.Controls.Add(this.button_transaction);
            this.panel_menu.Location = new System.Drawing.Point(2, 105);
            this.panel_menu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(209, 471);
            this.panel_menu.TabIndex = 0;
            // 
            // panel_services
            // 
            this.panel_services.Controls.Add(this.button1);
            this.panel_services.Controls.Add(this.button_complaint);
            this.panel_services.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_services.Location = new System.Drawing.Point(0, 315);
            this.panel_services.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel_services.Name = "panel_services";
            this.panel_services.Size = new System.Drawing.Size(209, 84);
            this.panel_services.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(0, 38);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 40);
            this.button1.TabIndex = 8;
            this.button1.Text = "Check Balance";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_complaint
            // 
            this.button_complaint.BackColor = System.Drawing.Color.Teal;
            this.button_complaint.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_complaint.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_complaint.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_complaint.Location = new System.Drawing.Point(0, 0);
            this.button_complaint.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_complaint.Name = "button_complaint";
            this.button_complaint.Size = new System.Drawing.Size(209, 38);
            this.button_complaint.TabIndex = 7;
            this.button_complaint.Text = "Make Complaint";
            this.button_complaint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_complaint.UseVisualStyleBackColor = false;
            this.button_complaint.Click += new System.EventHandler(this.button_complaint_Click);
            // 
            // button_service
            // 
            this.button_service.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_service.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_service.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_service.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_service.Location = new System.Drawing.Point(0, 277);
            this.button_service.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_service.Name = "button_service";
            this.button_service.Size = new System.Drawing.Size(209, 38);
            this.button_service.TabIndex = 11;
            this.button_service.Text = "Services";
            this.button_service.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_service.UseVisualStyleBackColor = false;
            this.button_service.Click += new System.EventHandler(this.button_service_Click_1);
            // 
            // panel_account
            // 
            this.panel_account.Controls.Add(this.button_display_ac_info);
            this.panel_account.Controls.Add(this.button_create_ac);
            this.panel_account.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_account.Location = new System.Drawing.Point(0, 199);
            this.panel_account.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel_account.Name = "panel_account";
            this.panel_account.Size = new System.Drawing.Size(209, 78);
            this.panel_account.TabIndex = 3;
            // 
            // button_display_ac_info
            // 
            this.button_display_ac_info.BackColor = System.Drawing.Color.Teal;
            this.button_display_ac_info.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_display_ac_info.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_display_ac_info.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_display_ac_info.Location = new System.Drawing.Point(0, 38);
            this.button_display_ac_info.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_display_ac_info.Name = "button_display_ac_info";
            this.button_display_ac_info.Size = new System.Drawing.Size(209, 38);
            this.button_display_ac_info.TabIndex = 8;
            this.button_display_ac_info.Text = "Display Account Info";
            this.button_display_ac_info.UseVisualStyleBackColor = false;
            this.button_display_ac_info.Click += new System.EventHandler(this.button_display_ac_info_Click);
            // 
            // button_create_ac
            // 
            this.button_create_ac.BackColor = System.Drawing.Color.Teal;
            this.button_create_ac.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_create_ac.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_create_ac.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_create_ac.Location = new System.Drawing.Point(0, 0);
            this.button_create_ac.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_create_ac.Name = "button_create_ac";
            this.button_create_ac.Size = new System.Drawing.Size(209, 38);
            this.button_create_ac.TabIndex = 7;
            this.button_create_ac.Text = "Create Account";
            this.button_create_ac.UseVisualStyleBackColor = false;
            this.button_create_ac.Click += new System.EventHandler(this.button_create_ac_Click);
            // 
            // button_account
            // 
            this.button_account.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_account.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_account.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_account.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_account.Location = new System.Drawing.Point(0, 161);
            this.button_account.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_account.Name = "button_account";
            this.button_account.Size = new System.Drawing.Size(209, 38);
            this.button_account.TabIndex = 6;
            this.button_account.Text = "Account";
            this.button_account.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_account.UseVisualStyleBackColor = false;
            this.button_account.Click += new System.EventHandler(this.button_account_Click);
            // 
            // panel_transaction
            // 
            this.panel_transaction.Controls.Add(this.button_withdraw);
            this.panel_transaction.Controls.Add(this.button_deposit);
            this.panel_transaction.Controls.Add(this.button_check);
            this.panel_transaction.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_transaction.Location = new System.Drawing.Point(0, 38);
            this.panel_transaction.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel_transaction.Name = "panel_transaction";
            this.panel_transaction.Size = new System.Drawing.Size(209, 123);
            this.panel_transaction.TabIndex = 2;
            // 
            // button_withdraw
            // 
            this.button_withdraw.BackColor = System.Drawing.Color.Teal;
            this.button_withdraw.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_withdraw.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_withdraw.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_withdraw.Location = new System.Drawing.Point(0, 76);
            this.button_withdraw.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_withdraw.Name = "button_withdraw";
            this.button_withdraw.Size = new System.Drawing.Size(209, 40);
            this.button_withdraw.TabIndex = 3;
            this.button_withdraw.Text = "Withdraw";
            this.button_withdraw.UseVisualStyleBackColor = false;
            this.button_withdraw.Click += new System.EventHandler(this.button_withdraw_Click);
            // 
            // button_deposit
            // 
            this.button_deposit.BackColor = System.Drawing.Color.Teal;
            this.button_deposit.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_deposit.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_deposit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_deposit.Location = new System.Drawing.Point(0, 38);
            this.button_deposit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_deposit.Name = "button_deposit";
            this.button_deposit.Size = new System.Drawing.Size(209, 38);
            this.button_deposit.TabIndex = 4;
            this.button_deposit.Text = "Deposit";
            this.button_deposit.UseVisualStyleBackColor = false;
            this.button_deposit.Click += new System.EventHandler(this.button_deposite_Click);
            // 
            // button_check
            // 
            this.button_check.BackColor = System.Drawing.Color.Teal;
            this.button_check.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_check.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_check.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_check.Location = new System.Drawing.Point(0, 0);
            this.button_check.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_check.Name = "button_check";
            this.button_check.Size = new System.Drawing.Size(209, 38);
            this.button_check.TabIndex = 5;
            this.button_check.Text = "Transfer";
            this.button_check.UseVisualStyleBackColor = false;
            this.button_check.Click += new System.EventHandler(this.button_check_Click);
            // 
            // button_transaction
            // 
            this.button_transaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_transaction.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_transaction.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_transaction.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_transaction.Location = new System.Drawing.Point(0, 0);
            this.button_transaction.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_transaction.Name = "button_transaction";
            this.button_transaction.Size = new System.Drawing.Size(209, 38);
            this.button_transaction.TabIndex = 0;
            this.button_transaction.Text = "Transaction";
            this.button_transaction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_transaction.UseVisualStyleBackColor = false;
            this.button_transaction.Click += new System.EventHandler(this.button_transaction_Click);
            // 
            // panel_logo
            // 
            this.panel_logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_logo.Controls.Add(this.label1);
            this.panel_logo.Controls.Add(this.pictureBox1);
            this.panel_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_logo.Location = new System.Drawing.Point(0, 0);
            this.panel_logo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel_logo.Name = "panel_logo";
            this.panel_logo.Size = new System.Drawing.Size(933, 104);
            this.panel_logo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("High Tower Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(279, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bank Management System";
            // 
            // pictureBox1
            // 
          //  this.pictureBox1.BackgroundImage = global::WinFormsApp2.Properties.Resources._42492_bank_icon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(797, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button_Logout
            // 
            this.button_Logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_Logout.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Logout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Logout.Location = new System.Drawing.Point(812, 535);
            this.button_Logout.Name = "button_Logout";
            this.button_Logout.Size = new System.Drawing.Size(97, 41);
            this.button_Logout.TabIndex = 2;
            this.button_Logout.Text = "LogOut";
            this.button_Logout.UseVisualStyleBackColor = false;
            this.button_Logout.Click += new System.EventHandler(this.button_Logout_Click);
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::WinFormsApp2.Properties.Resources.how_do_banks_make_money;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(933, 590);
            this.Controls.Add(this.button_Logout);
            this.Controls.Add(this.panel_logo);
            this.Controls.Add(this.panel_menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "main_form";
            this.Text = "Bank Management System";
            this.panel_menu.ResumeLayout(false);
            this.panel_services.ResumeLayout(false);
            this.panel_account.ResumeLayout(false);
            this.panel_transaction.ResumeLayout(false);
            this.panel_logo.ResumeLayout(false);
            this.panel_logo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Panel panel_transaction;
        private System.Windows.Forms.Button button_transaction;
        private System.Windows.Forms.Panel panel_logo;
        private System.Windows.Forms.Button button_complaint;
        private System.Windows.Forms.Panel panel_account;
        private System.Windows.Forms.Button button_display_ac_info;
        private System.Windows.Forms.Button button_create_ac;
        private System.Windows.Forms.Button button_account;
        private System.Windows.Forms.Button button_check;
        private System.Windows.Forms.Button button_deposit;
        private System.Windows.Forms.Button button_withdraw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel_services;
        private System.Windows.Forms.Button button_service;
        private System.Windows.Forms.Button button_Logout;
    }
}