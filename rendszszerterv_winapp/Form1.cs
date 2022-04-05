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
        int edu_number;
        public Form1()
        {
            InitializeComponent();

          

            user_tabcontrol.TabPages[0].Text = "Felhasználók listázás";
            user_tabcontrol.TabPages[1].Text = "Felhasználó hozzáadása";
            user_tabcontrol.TabPages[2].Text = "Felhasználó adatainak módosítása";

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
    
            
        }

         async Task saveuser(string username, string usertype, string password, int id)
        {
            string json;
            if (id==-1)
            {
               json = "{\"param\": {\"username\" : \"" + username + "\",\"password\" : \"" + password + "\",\"userType\" : \"" + usertype + "\"}}";

            }
            else
            {
                json = "{\"param\": {\"id\" : " + id + ",\"username\" : \"" + username + "\",\"password\" : \"" + password + "\",\"userType\" : \"" + usertype + "\", \"educations\":[]} }";
                //for (int i = 0; i < edu_number; i++)
                //{
                //    CheckBox cbox = pan_edu_list.Controls.Find() as CheckBox;
                //    if (chkbox_All != null)
                //        if (i != 0)
                //    {
                //        json += ",";
                //    }
                //    json += "{\"id\": " +  +"}";
                   
                  

                   
                //}
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

        public class comb_item
        {
            public comb_item() { }

            public string Value { set; get; }
            public string Text { set; get; }
        }

        private async void user_tabcontrol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (user_tabcontrol.SelectedIndex ==0)
            {
                listuser();
            }
            else if (user_tabcontrol.SelectedIndex == 2)
            {
                listuser();

                List<comb_item> catl = new List<comb_item>();
                catl.Add(new comb_item() { Text = "Kérem válasszon", Value = "-1" });
                for (int i = 0; i < user.userlist.items.Length; i++)
                {


                    catl.Add(new comb_item() { Text = user.userlist.items[i].username.ToString(), Value = user.userlist.items[i].id.ToString() });
                }

                users_combobox.DataSource = catl;
                users_combobox.DisplayMember = "Text";
                users_combobox.ValueMember = "Value";



                List<comb_item> usrtypes = new List<comb_item>();

                usrtypes.Add(new comb_item() { Text = "Adminisztátor", Value = "ADMIN" });
                usrtypes.Add(new comb_item() { Text = "Eszköz felelős", Value = "TOOL_MANAGER" });
                usrtypes.Add(new comb_item() { Text = "Karbantartó", Value = "REPAIRMAN" });
                usrtypes.Add(new comb_item() { Text = "Operátor", Value = "OPERATOR" });

                edit_usertype_combbox.DataSource = usrtypes;
                edit_usertype_combbox.DisplayMember = "Text";
                edit_usertype_combbox.ValueMember = "Value";
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            menu Check = new menu();
            Check.Show();
            Hide();
        }

        private void users_combobox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (Convert.ToInt32(users_combobox.SelectedValue) != -1)
            {


                int user_id = Convert.ToInt32(users_combobox.SelectedValue);
                int index = 0;
                edu_number = 0;
                while (user_id != user.userlist.items[index].id)
                {
                    index++;
                };
                txt_edit_username.Text = user.userlist.items[index].username;
                txt_edit_pass.Text = "";
                edit_usertype_combbox.SelectedValue = user.userlist.items[index].userType.ToString();
                pan_edu_list.Controls.Clear();
                //for (int i = 0; i < user.userlist.items[index].educations.Length; i++)
                //{
                //    CheckBox cbox = new CheckBox();
                //    cbox.Name = user.userlist.items[index].educations[i].id.ToString();
                //    cbox.Text = user.userlist.items[index].educations[i].name.ToString();
                //    cbox.Checked = true;
                //    cbox.AutoSize = true;
                //    cbox.Location = new Point(10, i * 20);
                //    pan_edu_list.Controls.Add(cbox);
                    
                //    //user_cahnge_tab_layout.Controls.Add(cbox,1, user_cahnge_tab_layout.RowCount - 1);

                //    edu_number++;
                //}

            }
            else
            {
                txt_edit_username.Text = "";
                txt_edit_pass.Text = "";
                pan_edu_list.Controls.Clear();
            }
        }

        private async void but_change_data_Click(object sender, EventArgs e)
        {
            saveuser(txt_edit_username.Text.ToString(), edit_usertype_combbox.SelectedValue.ToString(), txt_edit_pass.Text.ToString(), Convert.ToInt32(users_combobox.SelectedValue));
        }
    }
}
