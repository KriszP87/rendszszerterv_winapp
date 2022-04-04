
namespace rendszszerterv_winapp
{
    partial class eduform
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
            this.edu_tabcontrol = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.edu_list_panel = new System.Windows.Forms.Panel();
            this.edulist_gridview = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.new_edu_panel = new System.Windows.Forms.Panel();
            this.but_edu_create = new System.Windows.Forms.Button();
            this.txt_edu_desc = new System.Windows.Forms.TextBox();
            this.txt_edu_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.add_edu_to_cat_panel = new System.Windows.Forms.Panel();
            this.cat_combobox = new System.Windows.Forms.ComboBox();
            this.edu_combobox = new System.Windows.Forms.ComboBox();
            this.but_connecnt_cat_edu = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.edu_cat_con_list_panel = new System.Windows.Forms.Panel();
            this.oktat_combox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.edu_cat_con_data = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.edu_tabcontrol.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.edu_list_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edulist_gridview)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.new_edu_panel.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.add_edu_to_cat_panel.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.edu_cat_con_list_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edu_cat_con_data)).BeginInit();
            this.SuspendLayout();
            // 
            // edu_tabcontrol
            // 
            this.edu_tabcontrol.Controls.Add(this.tabPage1);
            this.edu_tabcontrol.Controls.Add(this.tabPage2);
            this.edu_tabcontrol.Controls.Add(this.tabPage3);
            this.edu_tabcontrol.Controls.Add(this.tabPage4);
            this.edu_tabcontrol.Controls.Add(this.tabPage5);
            this.edu_tabcontrol.Controls.Add(this.tabPage6);
            this.edu_tabcontrol.Location = new System.Drawing.Point(-1, 12);
            this.edu_tabcontrol.Name = "edu_tabcontrol";
            this.edu_tabcontrol.SelectedIndex = 0;
            this.edu_tabcontrol.Size = new System.Drawing.Size(799, 426);
            this.edu_tabcontrol.TabIndex = 0;
            this.edu_tabcontrol.SelectedIndexChanged += new System.EventHandler(this.edu_tabcontrol_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.edu_list_panel);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(791, 398);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // edu_list_panel
            // 
            this.edu_list_panel.Controls.Add(this.edulist_gridview);
            this.edu_list_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edu_list_panel.Location = new System.Drawing.Point(3, 3);
            this.edu_list_panel.Name = "edu_list_panel";
            this.edu_list_panel.Size = new System.Drawing.Size(785, 392);
            this.edu_list_panel.TabIndex = 0;
            // 
            // edulist_gridview
            // 
            this.edulist_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.edulist_gridview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edulist_gridview.Location = new System.Drawing.Point(0, 0);
            this.edulist_gridview.Name = "edulist_gridview";
            this.edulist_gridview.RowTemplate.Height = 25;
            this.edulist_gridview.Size = new System.Drawing.Size(785, 392);
            this.edulist_gridview.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.new_edu_panel);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(791, 398);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // new_edu_panel
            // 
            this.new_edu_panel.Controls.Add(this.but_edu_create);
            this.new_edu_panel.Controls.Add(this.txt_edu_desc);
            this.new_edu_panel.Controls.Add(this.txt_edu_name);
            this.new_edu_panel.Controls.Add(this.label3);
            this.new_edu_panel.Controls.Add(this.label2);
            this.new_edu_panel.Controls.Add(this.label1);
            this.new_edu_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.new_edu_panel.Location = new System.Drawing.Point(3, 3);
            this.new_edu_panel.Name = "new_edu_panel";
            this.new_edu_panel.Size = new System.Drawing.Size(785, 392);
            this.new_edu_panel.TabIndex = 0;
            // 
            // but_edu_create
            // 
            this.but_edu_create.Location = new System.Drawing.Point(303, 232);
            this.but_edu_create.Name = "but_edu_create";
            this.but_edu_create.Size = new System.Drawing.Size(121, 23);
            this.but_edu_create.TabIndex = 5;
            this.but_edu_create.Text = "Létrehozás";
            this.but_edu_create.UseVisualStyleBackColor = true;
            this.but_edu_create.Click += new System.EventHandler(this.but_edu_create_Click);
            // 
            // txt_edu_desc
            // 
            this.txt_edu_desc.Location = new System.Drawing.Point(317, 149);
            this.txt_edu_desc.Name = "txt_edu_desc";
            this.txt_edu_desc.Size = new System.Drawing.Size(100, 23);
            this.txt_edu_desc.TabIndex = 4;
            // 
            // txt_edu_name
            // 
            this.txt_edu_name.Location = new System.Drawing.Point(317, 83);
            this.txt_edu_name.Name = "txt_edu_name";
            this.txt_edu_name.Size = new System.Drawing.Size(100, 23);
            this.txt_edu_name.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Leírás:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Neve: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(303, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Új képzettség létrehozása";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.add_edu_to_cat_panel);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(791, 398);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // add_edu_to_cat_panel
            // 
            this.add_edu_to_cat_panel.Controls.Add(this.cat_combobox);
            this.add_edu_to_cat_panel.Controls.Add(this.edu_combobox);
            this.add_edu_to_cat_panel.Controls.Add(this.but_connecnt_cat_edu);
            this.add_edu_to_cat_panel.Controls.Add(this.label6);
            this.add_edu_to_cat_panel.Controls.Add(this.label5);
            this.add_edu_to_cat_panel.Controls.Add(this.label4);
            this.add_edu_to_cat_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.add_edu_to_cat_panel.Location = new System.Drawing.Point(3, 3);
            this.add_edu_to_cat_panel.Name = "add_edu_to_cat_panel";
            this.add_edu_to_cat_panel.Size = new System.Drawing.Size(785, 392);
            this.add_edu_to_cat_panel.TabIndex = 0;
            // 
            // cat_combobox
            // 
            this.cat_combobox.FormattingEnabled = true;
            this.cat_combobox.Location = new System.Drawing.Point(329, 132);
            this.cat_combobox.Name = "cat_combobox";
            this.cat_combobox.Size = new System.Drawing.Size(121, 23);
            this.cat_combobox.TabIndex = 5;
            // 
            // edu_combobox
            // 
            this.edu_combobox.FormattingEnabled = true;
            this.edu_combobox.Location = new System.Drawing.Point(329, 77);
            this.edu_combobox.Name = "edu_combobox";
            this.edu_combobox.Size = new System.Drawing.Size(121, 23);
            this.edu_combobox.TabIndex = 4;
            // 
            // but_connecnt_cat_edu
            // 
            this.but_connecnt_cat_edu.Location = new System.Drawing.Point(278, 191);
            this.but_connecnt_cat_edu.Name = "but_connecnt_cat_edu";
            this.but_connecnt_cat_edu.Size = new System.Drawing.Size(175, 23);
            this.but_connecnt_cat_edu.TabIndex = 3;
            this.but_connecnt_cat_edu.Text = "Hozzárendel";
            this.but_connecnt_cat_edu.UseVisualStyleBackColor = true;
            this.but_connecnt_cat_edu.Click += new System.EventHandler(this.but_connecnt_cat_edu_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(242, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Kategória:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(242, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Képzettség";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(278, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Képzettség kategórához kapcsolása";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.edu_cat_con_list_panel);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(791, 398);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // edu_cat_con_list_panel
            // 
            this.edu_cat_con_list_panel.Controls.Add(this.oktat_combox);
            this.edu_cat_con_list_panel.Controls.Add(this.label7);
            this.edu_cat_con_list_panel.Controls.Add(this.edu_cat_con_data);
            this.edu_cat_con_list_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edu_cat_con_list_panel.Location = new System.Drawing.Point(3, 3);
            this.edu_cat_con_list_panel.Name = "edu_cat_con_list_panel";
            this.edu_cat_con_list_panel.Size = new System.Drawing.Size(785, 392);
            this.edu_cat_con_list_panel.TabIndex = 0;
            // 
            // oktat_combox
            // 
            this.oktat_combox.FormattingEnabled = true;
            this.oktat_combox.Location = new System.Drawing.Point(344, 22);
            this.oktat_combox.Name = "oktat_combox";
            this.oktat_combox.Size = new System.Drawing.Size(121, 23);
            this.oktat_combox.TabIndex = 2;
            this.oktat_combox.SelectionChangeCommitted += new System.EventHandler(this.oktat_combox_SelectionChangeCommitted);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(257, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Képzettség:";
            // 
            // edu_cat_con_data
            // 
            this.edu_cat_con_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.edu_cat_con_data.Location = new System.Drawing.Point(68, 72);
            this.edu_cat_con_data.Name = "edu_cat_con_data";
            this.edu_cat_con_data.RowTemplate.Height = 25;
            this.edu_cat_con_data.Size = new System.Drawing.Size(642, 320);
            this.edu_cat_con_data.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 24);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(791, 398);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 24);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(791, 398);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "tabPage6";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // eduform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.edu_tabcontrol);
            this.Name = "eduform";
            this.Text = "eduform";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.eduform_FormClosing);
            this.edu_tabcontrol.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.edu_list_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.edulist_gridview)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.new_edu_panel.ResumeLayout(false);
            this.new_edu_panel.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.add_edu_to_cat_panel.ResumeLayout(false);
            this.add_edu_to_cat_panel.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.edu_cat_con_list_panel.ResumeLayout(false);
            this.edu_cat_con_list_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edu_cat_con_data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl edu_tabcontrol;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel edu_list_panel;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView edulist_gridview;
        private System.Windows.Forms.Panel new_edu_panel;
        private System.Windows.Forms.Button but_edu_create;
        private System.Windows.Forms.TextBox txt_edu_desc;
        private System.Windows.Forms.TextBox txt_edu_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel add_edu_to_cat_panel;
        private System.Windows.Forms.ComboBox cat_combobox;
        private System.Windows.Forms.ComboBox edu_combobox;
        private System.Windows.Forms.Button but_connecnt_cat_edu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Panel edu_cat_con_list_panel;
        private System.Windows.Forms.DataGridView edu_cat_con_data;
        private System.Windows.Forms.ComboBox oktat_combox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
    }
}