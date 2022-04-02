﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rendszszerterv_winapp
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
            lab_user.Text += variables.currentuser.item.username.ToString();
            lab_usertype.Text += variables.currentuser.item.userType.ToString();
        }

        private void but_tools_Click(object sender, EventArgs e)
        {
            toolform Check = new toolform();
            Check.Show();
            Hide();
        }

        private void but_users_Click(object sender, EventArgs e)
        {
            Form1 Check = new Form1();
            Check.Show();
            Hide();
        }

        private void menu_FormClosing(object sender, FormClosingEventArgs e)
        {

            variables.currentuser = null;
            Login Check = new Login();
            Check.Show();
            Hide();
        }

        private void but_edu_Click(object sender, EventArgs e)
        {
            eduform Check = new eduform();
            Check.Show();
            Hide();
        }
    }
}
