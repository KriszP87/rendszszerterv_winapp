
namespace rendszszerterv_winapp
{
    partial class menu
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
            this.but_users = new System.Windows.Forms.Button();
            this.but_tools = new System.Windows.Forms.Button();
            this.lab_user = new System.Windows.Forms.Label();
            this.lab_usertype = new System.Windows.Forms.Label();
            this.but_edu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // but_users
            // 
            this.but_users.Location = new System.Drawing.Point(302, 70);
            this.but_users.Name = "but_users";
            this.but_users.Size = new System.Drawing.Size(158, 32);
            this.but_users.TabIndex = 0;
            this.but_users.Text = "Felhasználók";
            this.but_users.UseVisualStyleBackColor = true;
            this.but_users.Click += new System.EventHandler(this.but_users_Click);
            // 
            // but_tools
            // 
            this.but_tools.Location = new System.Drawing.Point(302, 131);
            this.but_tools.Name = "but_tools";
            this.but_tools.Size = new System.Drawing.Size(158, 29);
            this.but_tools.TabIndex = 1;
            this.but_tools.Text = "Eszközök";
            this.but_tools.UseVisualStyleBackColor = true;
            this.but_tools.Click += new System.EventHandler(this.but_tools_Click);
            // 
            // lab_user
            // 
            this.lab_user.AutoSize = true;
            this.lab_user.Location = new System.Drawing.Point(13, 48);
            this.lab_user.Name = "lab_user";
            this.lab_user.Size = new System.Drawing.Size(77, 15);
            this.lab_user.TabIndex = 2;
            this.lab_user.Text = "Felhasználó : ";
            // 
            // lab_usertype
            // 
            this.lab_usertype.AutoSize = true;
            this.lab_usertype.Location = new System.Drawing.Point(13, 79);
            this.lab_usertype.Name = "lab_usertype";
            this.lab_usertype.Size = new System.Drawing.Size(44, 15);
            this.lab_usertype.TabIndex = 3;
            this.lab_usertype.Text = "Típus : ";
            // 
            // but_edu
            // 
            this.but_edu.Location = new System.Drawing.Point(302, 193);
            this.but_edu.Name = "but_edu";
            this.but_edu.Size = new System.Drawing.Size(158, 28);
            this.but_edu.TabIndex = 4;
            this.but_edu.Text = "Oktatások";
            this.but_edu.UseVisualStyleBackColor = true;
            this.but_edu.Click += new System.EventHandler(this.but_edu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Képzettségek";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(302, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Kijelentkezés";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.but_edu);
            this.Controls.Add(this.lab_usertype);
            this.Controls.Add(this.lab_user);
            this.Controls.Add(this.but_tools);
            this.Controls.Add(this.but_users);
            this.Name = "menu";
            this.Text = "menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.menu_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_users;
        private System.Windows.Forms.Button but_tools;
        private System.Windows.Forms.Label lab_user;
        private System.Windows.Forms.Label lab_usertype;
        private System.Windows.Forms.Button but_edu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}