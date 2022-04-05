
namespace rendszszerterv_winapp
{
    partial class Form1
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
            this.userlist_panel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.edu_datagrid = new System.Windows.Forms.DataGridView();
            this.userlist_datagrid = new System.Windows.Forms.DataGridView();
            this.newuser_panel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.but_crerateuser = new System.Windows.Forms.Button();
            this.rad_eszkoz = new System.Windows.Forms.RadioButton();
            this.rad_op = new System.Windows.Forms.RadioButton();
            this.rad_karban = new System.Windows.Forms.RadioButton();
            this.rbut_admin = new System.Windows.Forms.RadioButton();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.user_tabcontrol = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.edit_user_panel = new System.Windows.Forms.Panel();
            this.user_cahnge_tab_layout = new System.Windows.Forms.TableLayoutPanel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_edit_pass = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_edit_username = new System.Windows.Forms.TextBox();
            this.edit_usertype_combbox = new System.Windows.Forms.ComboBox();
            this.pan_edu_list = new System.Windows.Forms.Panel();
            this.users_combobox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.but_change_data = new System.Windows.Forms.Button();
            this.userlist_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edu_datagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userlist_datagrid)).BeginInit();
            this.newuser_panel.SuspendLayout();
            this.user_tabcontrol.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.edit_user_panel.SuspendLayout();
            this.user_cahnge_tab_layout.SuspendLayout();
            this.SuspendLayout();
            // 
            // userlist_panel
            // 
            this.userlist_panel.Controls.Add(this.label2);
            this.userlist_panel.Controls.Add(this.label1);
            this.userlist_panel.Controls.Add(this.edu_datagrid);
            this.userlist_panel.Controls.Add(this.userlist_datagrid);
            this.userlist_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userlist_panel.Location = new System.Drawing.Point(3, 3);
            this.userlist_panel.Name = "userlist_panel";
            this.userlist_panel.Size = new System.Drawing.Size(853, 526);
            this.userlist_panel.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(391, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Képzettségek";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Felhasználók";
            // 
            // edu_datagrid
            // 
            this.edu_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.edu_datagrid.Location = new System.Drawing.Point(391, 36);
            this.edu_datagrid.Name = "edu_datagrid";
            this.edu_datagrid.RowTemplate.Height = 25;
            this.edu_datagrid.Size = new System.Drawing.Size(402, 325);
            this.edu_datagrid.TabIndex = 1;
            this.edu_datagrid.SelectionChanged += new System.EventHandler(this.edu_datagrid_SelectionChanged);
            // 
            // userlist_datagrid
            // 
            this.userlist_datagrid.AllowUserToOrderColumns = true;
            this.userlist_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userlist_datagrid.Location = new System.Drawing.Point(13, 36);
            this.userlist_datagrid.Name = "userlist_datagrid";
            this.userlist_datagrid.RowTemplate.Height = 25;
            this.userlist_datagrid.Size = new System.Drawing.Size(365, 325);
            this.userlist_datagrid.TabIndex = 0;
            this.userlist_datagrid.SelectionChanged += new System.EventHandler(this.userlist_datagrid_SelectionChanged);
            // 
            // newuser_panel
            // 
            this.newuser_panel.Controls.Add(this.label6);
            this.newuser_panel.Controls.Add(this.label5);
            this.newuser_panel.Controls.Add(this.label4);
            this.newuser_panel.Controls.Add(this.label3);
            this.newuser_panel.Controls.Add(this.but_crerateuser);
            this.newuser_panel.Controls.Add(this.rad_eszkoz);
            this.newuser_panel.Controls.Add(this.rad_op);
            this.newuser_panel.Controls.Add(this.rad_karban);
            this.newuser_panel.Controls.Add(this.rbut_admin);
            this.newuser_panel.Controls.Add(this.txt_password);
            this.newuser_panel.Controls.Add(this.txt_username);
            this.newuser_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newuser_panel.Location = new System.Drawing.Point(3, 3);
            this.newuser_panel.Name = "newuser_panel";
            this.newuser_panel.Size = new System.Drawing.Size(853, 526);
            this.newuser_panel.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(306, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Pozíció:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(314, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Új felhasználó létrehozása";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(314, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Jelszó:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(264, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Felhazsnálónév:";
            // 
            // but_crerateuser
            // 
            this.but_crerateuser.Location = new System.Drawing.Point(247, 363);
            this.but_crerateuser.Name = "but_crerateuser";
            this.but_crerateuser.Size = new System.Drawing.Size(318, 23);
            this.but_crerateuser.TabIndex = 6;
            this.but_crerateuser.Text = "Új felhazsnáló létrehozása";
            this.but_crerateuser.UseVisualStyleBackColor = true;
            this.but_crerateuser.Click += new System.EventHandler(this.but_crerateuser_Click);
            // 
            // rad_eszkoz
            // 
            this.rad_eszkoz.AutoSize = true;
            this.rad_eszkoz.Location = new System.Drawing.Point(368, 270);
            this.rad_eszkoz.Name = "rad_eszkoz";
            this.rad_eszkoz.Size = new System.Drawing.Size(93, 19);
            this.rad_eszkoz.TabIndex = 5;
            this.rad_eszkoz.TabStop = true;
            this.rad_eszkoz.Text = "Eszközfelelős";
            this.rad_eszkoz.UseVisualStyleBackColor = true;
            // 
            // rad_op
            // 
            this.rad_op.AutoSize = true;
            this.rad_op.Location = new System.Drawing.Point(368, 318);
            this.rad_op.Name = "rad_op";
            this.rad_op.Size = new System.Drawing.Size(72, 19);
            this.rad_op.TabIndex = 4;
            this.rad_op.TabStop = true;
            this.rad_op.Text = "Operátor";
            this.rad_op.UseVisualStyleBackColor = true;
            // 
            // rad_karban
            // 
            this.rad_karban.AutoSize = true;
            this.rad_karban.Location = new System.Drawing.Point(368, 229);
            this.rad_karban.Name = "rad_karban";
            this.rad_karban.Size = new System.Drawing.Size(87, 19);
            this.rad_karban.TabIndex = 3;
            this.rad_karban.TabStop = true;
            this.rad_karban.Text = "Karbantartó";
            this.rad_karban.UseVisualStyleBackColor = true;
            // 
            // rbut_admin
            // 
            this.rbut_admin.AutoSize = true;
            this.rbut_admin.Location = new System.Drawing.Point(368, 187);
            this.rbut_admin.Name = "rbut_admin";
            this.rbut_admin.Size = new System.Drawing.Size(61, 19);
            this.rbut_admin.TabIndex = 2;
            this.rbut_admin.TabStop = true;
            this.rbut_admin.Text = "Admin";
            this.rbut_admin.UseVisualStyleBackColor = true;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(360, 120);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(100, 23);
            this.txt_password.TabIndex = 1;
            this.txt_password.UseSystemPasswordChar = true;
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(360, 53);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(100, 23);
            this.txt_username.TabIndex = 0;
            // 
            // user_tabcontrol
            // 
            this.user_tabcontrol.Controls.Add(this.tabPage1);
            this.user_tabcontrol.Controls.Add(this.tabPage2);
            this.user_tabcontrol.Controls.Add(this.tabPage3);
            this.user_tabcontrol.Location = new System.Drawing.Point(0, 12);
            this.user_tabcontrol.Name = "user_tabcontrol";
            this.user_tabcontrol.SelectedIndex = 0;
            this.user_tabcontrol.Size = new System.Drawing.Size(867, 560);
            this.user_tabcontrol.TabIndex = 7;
            this.user_tabcontrol.SelectedIndexChanged += new System.EventHandler(this.user_tabcontrol_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.userlist_panel);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(859, 532);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.newuser_panel);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(859, 532);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.edit_user_panel);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(859, 532);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // edit_user_panel
            // 
            this.edit_user_panel.Controls.Add(this.but_change_data);
            this.edit_user_panel.Controls.Add(this.user_cahnge_tab_layout);
            this.edit_user_panel.Controls.Add(this.users_combobox);
            this.edit_user_panel.Controls.Add(this.label8);
            this.edit_user_panel.Controls.Add(this.label7);
            this.edit_user_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edit_user_panel.Location = new System.Drawing.Point(3, 3);
            this.edit_user_panel.Name = "edit_user_panel";
            this.edit_user_panel.Size = new System.Drawing.Size(853, 526);
            this.edit_user_panel.TabIndex = 0;
            // 
            // user_cahnge_tab_layout
            // 
            this.user_cahnge_tab_layout.AutoSize = true;
            this.user_cahnge_tab_layout.ColumnCount = 2;
            this.user_cahnge_tab_layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49F));
            this.user_cahnge_tab_layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51F));
            this.user_cahnge_tab_layout.Controls.Add(this.label12, 0, 3);
            this.user_cahnge_tab_layout.Controls.Add(this.label11, 0, 2);
            this.user_cahnge_tab_layout.Controls.Add(this.txt_edit_pass, 1, 1);
            this.user_cahnge_tab_layout.Controls.Add(this.label10, 0, 1);
            this.user_cahnge_tab_layout.Controls.Add(this.label9, 0, 0);
            this.user_cahnge_tab_layout.Controls.Add(this.txt_edit_username, 1, 0);
            this.user_cahnge_tab_layout.Controls.Add(this.edit_usertype_combbox, 1, 2);
            this.user_cahnge_tab_layout.Controls.Add(this.pan_edu_list, 1, 3);
            this.user_cahnge_tab_layout.Location = new System.Drawing.Point(227, 136);
            this.user_cahnge_tab_layout.Name = "user_cahnge_tab_layout";
            this.user_cahnge_tab_layout.RowCount = 4;
            this.user_cahnge_tab_layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.85542F));
            this.user_cahnge_tab_layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.14458F));
            this.user_cahnge_tab_layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.user_cahnge_tab_layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.user_cahnge_tab_layout.Size = new System.Drawing.Size(410, 188);
            this.user_cahnge_tab_layout.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 150);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(194, 15);
            this.label12.TabIndex = 6;
            this.label12.Text = "Képzettségek:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 96);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(194, 15);
            this.label11.TabIndex = 4;
            this.label11.Text = "Jogosultság";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_edit_pass
            // 
            this.txt_edit_pass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_edit_pass.Location = new System.Drawing.Point(203, 54);
            this.txt_edit_pass.Name = "txt_edit_pass";
            this.txt_edit_pass.Size = new System.Drawing.Size(204, 23);
            this.txt_edit_pass.TabIndex = 3;
            this.txt_edit_pass.UseSystemPasswordChar = true;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(194, 15);
            this.label10.TabIndex = 2;
            this.label10.Text = "Jelszó:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(194, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Felhasználónév:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_edit_username
            // 
            this.txt_edit_username.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_edit_username.Location = new System.Drawing.Point(203, 14);
            this.txt_edit_username.Name = "txt_edit_username";
            this.txt_edit_username.Size = new System.Drawing.Size(204, 23);
            this.txt_edit_username.TabIndex = 1;
            // 
            // edit_usertype_combbox
            // 
            this.edit_usertype_combbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.edit_usertype_combbox.FormattingEnabled = true;
            this.edit_usertype_combbox.Location = new System.Drawing.Point(203, 92);
            this.edit_usertype_combbox.Name = "edit_usertype_combbox";
            this.edit_usertype_combbox.Size = new System.Drawing.Size(204, 23);
            this.edit_usertype_combbox.TabIndex = 5;
            // 
            // pan_edu_list
            // 
            this.pan_edu_list.AutoSize = true;
            this.pan_edu_list.Location = new System.Drawing.Point(203, 131);
            this.pan_edu_list.Name = "pan_edu_list";
            this.pan_edu_list.Size = new System.Drawing.Size(0, 0);
            this.pan_edu_list.TabIndex = 7;
            // 
            // users_combobox
            // 
            this.users_combobox.FormattingEnabled = true;
            this.users_combobox.Location = new System.Drawing.Point(345, 87);
            this.users_combobox.Name = "users_combobox";
            this.users_combobox.Size = new System.Drawing.Size(123, 23);
            this.users_combobox.TabIndex = 2;
            this.users_combobox.SelectionChangeCommitted += new System.EventHandler(this.users_combobox_SelectionChangeCommitted);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(345, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "Válasszon felhasználót";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(316, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Felhasználó adatinak módosítása";
            // 
            // but_change_data
            // 
            this.but_change_data.Location = new System.Drawing.Point(352, 361);
            this.but_change_data.Name = "but_change_data";
            this.but_change_data.Size = new System.Drawing.Size(144, 23);
            this.but_change_data.TabIndex = 5;
            this.but_change_data.Text = "Adatok módosítása";
            this.but_change_data.UseVisualStyleBackColor = true;
            this.but_change_data.Click += new System.EventHandler(this.but_change_data_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 568);
            this.Controls.Add(this.user_tabcontrol);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.userlist_panel.ResumeLayout(false);
            this.userlist_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edu_datagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userlist_datagrid)).EndInit();
            this.newuser_panel.ResumeLayout(false);
            this.newuser_panel.PerformLayout();
            this.user_tabcontrol.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.edit_user_panel.ResumeLayout(false);
            this.edit_user_panel.PerformLayout();
            this.user_cahnge_tab_layout.ResumeLayout(false);
            this.user_cahnge_tab_layout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel userlist_panel;
        private System.Windows.Forms.DataGridView userlist_datagrid;
        private System.Windows.Forms.DataGridView edu_datagrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel newuser_panel;
        private System.Windows.Forms.RadioButton rad_eszkoz;
        private System.Windows.Forms.RadioButton rad_op;
        private System.Windows.Forms.RadioButton rad_karban;
        private System.Windows.Forms.RadioButton rbut_admin;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Button but_crerateuser;
        private System.Windows.Forms.TabControl user_tabcontrol;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel edit_user_panel;
        private System.Windows.Forms.ComboBox users_combobox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel user_cahnge_tab_layout;
        private System.Windows.Forms.TextBox txt_edit_pass;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_edit_username;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox edit_usertype_combbox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel pan_edu_list;
        private System.Windows.Forms.Button but_change_data;
    }
}

