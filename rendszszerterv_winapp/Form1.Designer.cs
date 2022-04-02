
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.userlist_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newuser_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tool_listToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userlist_panel = new System.Windows.Forms.Panel();
            this.txt_newpass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.edu_datagrid = new System.Windows.Forms.DataGridView();
            this.userlist_datagrid = new System.Windows.Forms.DataGridView();
            this.newuser_panel = new System.Windows.Forms.Panel();
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
            this.menuStrip1.SuspendLayout();
            this.userlist_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edu_datagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userlist_datagrid)).BeginInit();
            this.newuser_panel.SuspendLayout();
            this.user_tabcontrol.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userlist_ToolStripMenuItem,
            this.newuser_ToolStripMenuItem,
            this.tool_listToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(867, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // userlist_ToolStripMenuItem
            // 
            this.userlist_ToolStripMenuItem.Name = "userlist_ToolStripMenuItem";
            this.userlist_ToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.userlist_ToolStripMenuItem.Text = "Felhasznák listázása";
            this.userlist_ToolStripMenuItem.Click += new System.EventHandler(this.userlist_ToolStripMenuItem_Click);
            // 
            // newuser_ToolStripMenuItem
            // 
            this.newuser_ToolStripMenuItem.Name = "newuser_ToolStripMenuItem";
            this.newuser_ToolStripMenuItem.Size = new System.Drawing.Size(155, 20);
            this.newuser_ToolStripMenuItem.Text = "Új felhasználó hozzáadása";
            this.newuser_ToolStripMenuItem.Click += new System.EventHandler(this.newuser_ToolStripMenuItem_Click);
            // 
            // tool_listToolStripMenuItem
            // 
            this.tool_listToolStripMenuItem.Name = "tool_listToolStripMenuItem";
            this.tool_listToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.tool_listToolStripMenuItem.Text = "Eszközök listátzása";
            // 
            // userlist_panel
            // 
            this.userlist_panel.Controls.Add(this.txt_newpass);
            this.userlist_panel.Controls.Add(this.label2);
            this.userlist_panel.Controls.Add(this.label1);
            this.userlist_panel.Controls.Add(this.edu_datagrid);
            this.userlist_panel.Controls.Add(this.userlist_datagrid);
            this.userlist_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userlist_panel.Location = new System.Drawing.Point(3, 3);
            this.userlist_panel.Name = "userlist_panel";
            this.userlist_panel.Size = new System.Drawing.Size(853, 511);
            this.userlist_panel.TabIndex = 1;
            // 
            // txt_newpass
            // 
            this.txt_newpass.Location = new System.Drawing.Point(38, 375);
            this.txt_newpass.Name = "txt_newpass";
            this.txt_newpass.Size = new System.Drawing.Size(100, 23);
            this.txt_newpass.TabIndex = 7;
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
            this.edu_datagrid.Location = new System.Drawing.Point(371, 39);
            this.edu_datagrid.Name = "edu_datagrid";
            this.edu_datagrid.RowTemplate.Height = 25;
            this.edu_datagrid.Size = new System.Drawing.Size(402, 340);
            this.edu_datagrid.TabIndex = 1;
            this.edu_datagrid.SelectionChanged += new System.EventHandler(this.edu_datagrid_SelectionChanged);
            // 
            // userlist_datagrid
            // 
            this.userlist_datagrid.AllowUserToOrderColumns = true;
            this.userlist_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userlist_datagrid.Location = new System.Drawing.Point(0, 39);
            this.userlist_datagrid.Name = "userlist_datagrid";
            this.userlist_datagrid.RowTemplate.Height = 25;
            this.userlist_datagrid.Size = new System.Drawing.Size(365, 325);
            this.userlist_datagrid.TabIndex = 0;
            this.userlist_datagrid.SelectionChanged += new System.EventHandler(this.userlist_datagrid_SelectionChanged);
            // 
            // newuser_panel
            // 
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
            this.newuser_panel.Size = new System.Drawing.Size(853, 511);
            this.newuser_panel.TabIndex = 2;
            // 
            // but_crerateuser
            // 
            this.but_crerateuser.Location = new System.Drawing.Point(186, 224);
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
            this.rad_eszkoz.Location = new System.Drawing.Point(590, 171);
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
            this.rad_op.Location = new System.Drawing.Point(432, 171);
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
            this.rad_karban.Location = new System.Drawing.Point(271, 171);
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
            this.rbut_admin.Location = new System.Drawing.Point(71, 172);
            this.rbut_admin.Name = "rbut_admin";
            this.rbut_admin.Size = new System.Drawing.Size(61, 19);
            this.rbut_admin.TabIndex = 2;
            this.rbut_admin.TabStop = true;
            this.rbut_admin.Text = "Admin";
            this.rbut_admin.UseVisualStyleBackColor = true;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(297, 113);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(100, 23);
            this.txt_password.TabIndex = 1;
            this.txt_password.UseSystemPasswordChar = true;
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(297, 55);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(100, 23);
            this.txt_username.TabIndex = 0;
            // 
            // user_tabcontrol
            // 
            this.user_tabcontrol.Controls.Add(this.tabPage1);
            this.user_tabcontrol.Controls.Add(this.tabPage2);
            this.user_tabcontrol.Location = new System.Drawing.Point(0, 27);
            this.user_tabcontrol.Name = "user_tabcontrol";
            this.user_tabcontrol.SelectedIndex = 0;
            this.user_tabcontrol.Size = new System.Drawing.Size(867, 545);
            this.user_tabcontrol.TabIndex = 7;
            this.user_tabcontrol.SelectedIndexChanged += new System.EventHandler(this.user_tabcontrol_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.userlist_panel);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(859, 517);
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
            this.tabPage2.Size = new System.Drawing.Size(859, 517);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 568);
            this.Controls.Add(this.user_tabcontrol);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.userlist_panel.ResumeLayout(false);
            this.userlist_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edu_datagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userlist_datagrid)).EndInit();
            this.newuser_panel.ResumeLayout(false);
            this.newuser_panel.PerformLayout();
            this.user_tabcontrol.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem userlist_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newuser_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tool_listToolStripMenuItem;
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
        private System.Windows.Forms.TextBox txt_newpass;
        private System.Windows.Forms.TabControl user_tabcontrol;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

