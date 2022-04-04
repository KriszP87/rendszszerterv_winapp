
namespace rendszszerterv_winapp
{
    partial class toolform
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
            this.tools_tabcontrol = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tool_list_panel = new System.Windows.Forms.Panel();
            this.tool_list_datagrid = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.newtool_panel = new System.Windows.Forms.Panel();
            this.cat_list_combobox = new System.Windows.Forms.ComboBox();
            this.txt_desc = new System.Windows.Forms.TextBox();
            this.txt_identi = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.but_createtool = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.create_category_panel = new System.Windows.Forms.Panel();
            this.but_new_cat = new System.Windows.Forms.Button();
            this.parent_cat_combobox = new System.Windows.Forms.ComboBox();
            this.time_combobox = new System.Windows.Forms.ComboBox();
            this.txt_cat_desc = new System.Windows.Forms.TextBox();
            this.txt_cat_name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.categorylist_panel = new System.Windows.Forms.Panel();
            this.cat_list_grid = new System.Windows.Forms.DataGridView();
            this.tools_tabcontrol.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tool_list_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tool_list_datagrid)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.newtool_panel.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.create_category_panel.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.categorylist_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cat_list_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // tools_tabcontrol
            // 
            this.tools_tabcontrol.Controls.Add(this.tabPage1);
            this.tools_tabcontrol.Controls.Add(this.tabPage2);
            this.tools_tabcontrol.Controls.Add(this.tabPage3);
            this.tools_tabcontrol.Controls.Add(this.tabPage4);
            this.tools_tabcontrol.Location = new System.Drawing.Point(-2, 0);
            this.tools_tabcontrol.Name = "tools_tabcontrol";
            this.tools_tabcontrol.SelectedIndex = 0;
            this.tools_tabcontrol.Size = new System.Drawing.Size(807, 453);
            this.tools_tabcontrol.TabIndex = 0;
            this.tools_tabcontrol.SelectedIndexChanged += new System.EventHandler(this.tools_tabcontrol_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tool_list_panel);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(799, 425);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tool_list_panel
            // 
            this.tool_list_panel.Controls.Add(this.tool_list_datagrid);
            this.tool_list_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tool_list_panel.Location = new System.Drawing.Point(3, 3);
            this.tool_list_panel.Name = "tool_list_panel";
            this.tool_list_panel.Size = new System.Drawing.Size(793, 419);
            this.tool_list_panel.TabIndex = 0;
            // 
            // tool_list_datagrid
            // 
            this.tool_list_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tool_list_datagrid.Location = new System.Drawing.Point(7, 22);
            this.tool_list_datagrid.Name = "tool_list_datagrid";
            this.tool_list_datagrid.RowTemplate.Height = 25;
            this.tool_list_datagrid.Size = new System.Drawing.Size(753, 315);
            this.tool_list_datagrid.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.newtool_panel);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(799, 425);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // newtool_panel
            // 
            this.newtool_panel.Controls.Add(this.cat_list_combobox);
            this.newtool_panel.Controls.Add(this.txt_desc);
            this.newtool_panel.Controls.Add(this.txt_identi);
            this.newtool_panel.Controls.Add(this.txt_name);
            this.newtool_panel.Controls.Add(this.but_createtool);
            this.newtool_panel.Controls.Add(this.label3);
            this.newtool_panel.Controls.Add(this.label1);
            this.newtool_panel.Controls.Add(this.label5);
            this.newtool_panel.Controls.Add(this.label2);
            this.newtool_panel.Controls.Add(this.label4);
            this.newtool_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newtool_panel.Location = new System.Drawing.Point(3, 3);
            this.newtool_panel.Name = "newtool_panel";
            this.newtool_panel.Size = new System.Drawing.Size(793, 419);
            this.newtool_panel.TabIndex = 6;
            // 
            // cat_list_combobox
            // 
            this.cat_list_combobox.FormattingEnabled = true;
            this.cat_list_combobox.Location = new System.Drawing.Point(338, 182);
            this.cat_list_combobox.Name = "cat_list_combobox";
            this.cat_list_combobox.Size = new System.Drawing.Size(121, 23);
            this.cat_list_combobox.TabIndex = 10;
            // 
            // txt_desc
            // 
            this.txt_desc.Location = new System.Drawing.Point(338, 141);
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(100, 23);
            this.txt_desc.TabIndex = 8;
            // 
            // txt_identi
            // 
            this.txt_identi.Location = new System.Drawing.Point(338, 103);
            this.txt_identi.Name = "txt_identi";
            this.txt_identi.Size = new System.Drawing.Size(100, 23);
            this.txt_identi.TabIndex = 7;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(338, 66);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 23);
            this.txt_name.TabIndex = 6;
            // 
            // but_createtool
            // 
            this.but_createtool.Location = new System.Drawing.Point(276, 261);
            this.but_createtool.Name = "but_createtool";
            this.but_createtool.Size = new System.Drawing.Size(201, 23);
            this.but_createtool.TabIndex = 5;
            this.but_createtool.Text = "Eszköz rögzítése";
            this.but_createtool.UseVisualStyleBackColor = true;
            this.but_createtool.Click += new System.EventHandler(this.but_createtool_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(338, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Eszköz adatai";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Neve:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(253, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Kategória:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Azonosító:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(276, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Leírás";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.create_category_panel);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(799, 425);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // create_category_panel
            // 
            this.create_category_panel.Controls.Add(this.but_new_cat);
            this.create_category_panel.Controls.Add(this.parent_cat_combobox);
            this.create_category_panel.Controls.Add(this.time_combobox);
            this.create_category_panel.Controls.Add(this.txt_cat_desc);
            this.create_category_panel.Controls.Add(this.txt_cat_name);
            this.create_category_panel.Controls.Add(this.label6);
            this.create_category_panel.Controls.Add(this.label10);
            this.create_category_panel.Controls.Add(this.label7);
            this.create_category_panel.Controls.Add(this.label9);
            this.create_category_panel.Controls.Add(this.label8);
            this.create_category_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.create_category_panel.Location = new System.Drawing.Point(3, 3);
            this.create_category_panel.Name = "create_category_panel";
            this.create_category_panel.Size = new System.Drawing.Size(793, 419);
            this.create_category_panel.TabIndex = 5;
            // 
            // but_new_cat
            // 
            this.but_new_cat.Location = new System.Drawing.Point(338, 329);
            this.but_new_cat.Name = "but_new_cat";
            this.but_new_cat.Size = new System.Drawing.Size(143, 23);
            this.but_new_cat.TabIndex = 9;
            this.but_new_cat.Text = "Új kategória rögzítése";
            this.but_new_cat.UseVisualStyleBackColor = true;
            this.but_new_cat.Click += new System.EventHandler(this.but_new_cat_Click);
            // 
            // parent_cat_combobox
            // 
            this.parent_cat_combobox.FormattingEnabled = true;
            this.parent_cat_combobox.Location = new System.Drawing.Point(351, 261);
            this.parent_cat_combobox.Name = "parent_cat_combobox";
            this.parent_cat_combobox.Size = new System.Drawing.Size(121, 23);
            this.parent_cat_combobox.TabIndex = 8;
            // 
            // time_combobox
            // 
            this.time_combobox.FormattingEnabled = true;
            this.time_combobox.Location = new System.Drawing.Point(351, 128);
            this.time_combobox.Name = "time_combobox";
            this.time_combobox.Size = new System.Drawing.Size(121, 23);
            this.time_combobox.TabIndex = 7;
            // 
            // txt_cat_desc
            // 
            this.txt_cat_desc.Location = new System.Drawing.Point(351, 181);
            this.txt_cat_desc.Name = "txt_cat_desc";
            this.txt_cat_desc.Size = new System.Drawing.Size(100, 23);
            this.txt_cat_desc.TabIndex = 6;
            // 
            // txt_cat_name
            // 
            this.txt_cat_name.Location = new System.Drawing.Point(351, 64);
            this.txt_cat_name.Name = "txt_cat_name";
            this.txt_cat_name.Size = new System.Drawing.Size(100, 23);
            this.txt_cat_name.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(338, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Új kategória létrehozása";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(184, 261);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 15);
            this.label10.TabIndex = 4;
            this.label10.Text = "Szülőkategória ( ha van) :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(283, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Neve :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(280, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 15);
            this.label9.TabIndex = 3;
            this.label9.Text = "Leírás :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(199, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "Karbantartási időszak :";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.categorylist_panel);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(799, 425);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // categorylist_panel
            // 
            this.categorylist_panel.Controls.Add(this.cat_list_grid);
            this.categorylist_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categorylist_panel.Location = new System.Drawing.Point(3, 3);
            this.categorylist_panel.Name = "categorylist_panel";
            this.categorylist_panel.Size = new System.Drawing.Size(793, 419);
            this.categorylist_panel.TabIndex = 0;
            // 
            // cat_list_grid
            // 
            this.cat_list_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cat_list_grid.Location = new System.Drawing.Point(0, 0);
            this.cat_list_grid.Name = "cat_list_grid";
            this.cat_list_grid.RowTemplate.Height = 25;
            this.cat_list_grid.Size = new System.Drawing.Size(783, 419);
            this.cat_list_grid.TabIndex = 0;
            // 
            // toolform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tools_tabcontrol);
            this.Name = "toolform";
            this.Text = "toolform";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.toolform_FormClosing);
            this.tools_tabcontrol.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tool_list_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tool_list_datagrid)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.newtool_panel.ResumeLayout(false);
            this.newtool_panel.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.create_category_panel.ResumeLayout(false);
            this.create_category_panel.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.categorylist_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cat_list_grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tools_tabcontrol;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel tool_list_panel;
        private System.Windows.Forms.DataGridView tool_list_datagrid;
        private System.Windows.Forms.Panel newtool_panel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_desc;
        private System.Windows.Forms.TextBox txt_identi;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Button but_createtool;
        private System.Windows.Forms.ComboBox cat_list_combobox;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel create_category_panel;
        private System.Windows.Forms.TextBox txt_cat_desc;
        private System.Windows.Forms.TextBox txt_cat_name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button but_new_cat;
        private System.Windows.Forms.ComboBox parent_cat_combobox;
        private System.Windows.Forms.ComboBox time_combobox;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Panel categorylist_panel;
        private System.Windows.Forms.DataGridView cat_list_grid;
    }
}