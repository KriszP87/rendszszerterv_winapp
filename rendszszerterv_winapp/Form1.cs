using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text.RegularExpressions;
using System.Net;
using System.IO;

namespace rendszszerterv_winapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            user_tabcontrol.TabPages[0].Text = "Felhasználók listázás";
            user_tabcontrol.TabPages[1].Text = "Felhasználó hozzáadása";

            listuser();
        }

 

        public void userlist_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listuser();
        }

        public void listuser() { 
            using (var client = new WebClient()) //WebClient  
            {
                client.Headers.Add("Content-Type:application/json"); 
                client.Headers.Add("Accept:application/json");

                var result = client.DownloadString("http://localhost:8080/user/list"); 
                                                                                      
                user.userlist = JsonConvert.DeserializeObject<user.Rootobject>(result);
               
            }
            userlist_datagrid.DataSource = user.userlist.items;
            userlist_datagrid.Refresh();
        

        }

        private void edu_datagrid_SelectionChanged(object sender, EventArgs e)
        {
   
          
        }

        private void userlist_datagrid_SelectionChanged(object sender, EventArgs e)
        {
            edu_datagrid.DataSource = user.userlist.items[userlist_datagrid.CurrentCell.RowIndex].educations;
 
      
           
        }

        private void newuser_ToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private async void but_crerateuser_Click(object sender, EventArgs e)
        {
            string type="";
            if (((RadioButton)rbut_admin).Checked)
            {
                type = "ADMIN";
            }
            else if (((RadioButton)rad_eszkoz).Checked)
            {
                type = "TOOL_MANAGER";
            }        
            else if (((RadioButton)rad_karban).Checked)
            {
                type = "REPAIRMAN";
            }    
            else if (((RadioButton)rad_op).Checked)
            {
                type = "OPERATOR";
            }
            string name = txt_username.Text.ToString();
            string pw = txt_password.Text.ToString();
            saveuser(name, type, pw, -1);
            txt_username.Text = "";
            txt_password.Text = "";
            txt_newpass.Text = "";
            
        }

        static async Task saveuser(string username, string usertype, string password, int id)
        {
            string json;
            if (id==-1)
            {
               json = "{\"param\": {\"username\" : \"" + username + "\",\"password\" : \"" + password + "\",\"userType\" : \"" + usertype + "\"}}";

            }
            else
            {
                json = "{\"param\": {\"id\" : " + id + ",\"username\" : \"" + username + "\",\"password\" : \"" + password + "\",\"userType\" : \"" + usertype + "\"}}";

            }


            //JObject jsonObject = JObject.Parse(json);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = null;
            using (var client = new HttpClient())
            {

                response = await client.PostAsync("http://localhost:8080/user/save", content);


                if (response.IsSuccessStatusCode)
                {
               
                    if (id==-1)
                    {
                            MessageBox.Show("Felhasználó sikeresen létrejött", "Üzenet");
                    }
                    else
                    {
                        MessageBox.Show("Felhasználó adatai módosítva", "Üzenet");
                    }
                    
                }
                else
                {
                    MessageBox.Show("A felhasználó létrehozása nem sikerült", "Üzenet");
                }

                

            }

        }

        private async void user_tabcontrol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (user_tabcontrol.SelectedIndex ==0)
            {
                listuser();
            }
            else if (user_tabcontrol.SelectedIndex == 1)
            {
             
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            menu Check = new menu();
            Check.Show();
            Hide();
        }

      
    }
}
