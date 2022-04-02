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
using System.Windows;

namespace rendszszerterv_winapp
{
    public partial class eduform : Form
    {
        toolcategory.Rootobject catlist;
        edulist.Rootobject edlist;
        edu_cat_rel.Rootobject connectlist;

        public eduform()
        {
            InitializeComponent();
            list_edu();


            edu_tabcontrol.TabPages[0].Text = "Oktatások listázás";
            edu_tabcontrol.TabPages[1].Text = "Új oktatás hozzáadása";
            edu_tabcontrol.TabPages[2].Text = "Oktatás eszközhöz rendelése";
            edu_tabcontrol.TabPages[3].Text = "Eszköz oktatás kapcsoaltok listázása";
         
         
        }

        private void edu_tabcontrol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (edu_tabcontrol.SelectedIndex == 0)
            {
                list_edu();
            }
            else if (edu_tabcontrol.SelectedIndex == 1)
            {
                
            }
            else if (edu_tabcontrol.SelectedIndex == 2)
            {

                list_cat();

                List<comb_item> catl = new List<comb_item>();
                catl.Add(new comb_item() { Text = "Kérem válasszon", Value = "-1" });
                for (int i = 0; i < catlist.items.Length; i++)
                {
                 

                    catl.Add(new comb_item() { Text = catlist.items[i].category.ToString(), Value = catlist.items[i].id.ToString() });
                }

                cat_combobox.DataSource = catl;
                cat_combobox.DisplayMember = "Text";
                cat_combobox.ValueMember = "Value";


                list_edu();

                List<comb_item> edul = new List<comb_item>();
                edul.Add(new comb_item() { Text = "Kérem válasszon", Value = "-1" });
                for (int i = 0; i < edlist.items.Length; i++)
                {
                 
                    edul.Add(new comb_item() { Text = edlist.items[i].name.ToString(), Value = edlist.items[i].id.ToString() });
                }

                edu_combobox.DataSource = edul;
                edu_combobox.DisplayMember = "Text";
                edu_combobox.ValueMember = "Value";



            }
            else if (edu_tabcontrol.SelectedIndex == 3)
            {
                list_edu();

                List<comb_item> edul2 = new List<comb_item>();
                edul2.Add(new comb_item() { Text = "Kérem válasszon", Value = "-1" });
                for (int i = 0; i < edlist.items.Length; i++)
                {
                    

                    edul2.Add(new comb_item() { Text = edlist.items[i].name.ToString(), Value = edlist.items[i].id.ToString() });
                }

                oktat_combox.DataSource = edul2;
                oktat_combox.DisplayMember = "Text";
                oktat_combox.ValueMember = "Value";

            }
        }

        public void conn_list(int id)
        {
            using (var client = new WebClient())
            {
                client.Headers.Add("Content-Type:application/json");
                client.Headers.Add("Accept:application/json");

                var result = client.DownloadString("http://localhost:8080/rel-education-tool-category/list?search=");

                connectlist = JsonConvert.DeserializeObject<edu_cat_rel.Rootobject>(result);

                List<edu_cat_rel.Toolcategory> temp = new List<edu_cat_rel.Toolcategory>();
                for (int i = 0; i < connectlist.items.Length; i++)
                {
                    if (id== connectlist.items[i].education.id)
                    {
                        temp.Add(connectlist.items[i].toolCategory);
                    }
                }



                // edu_cat_con_data.DataSource = temp;


                edu_cat_con_data.Columns.Clear();
                edu_cat_con_data.Rows.Clear();
                edu_cat_con_data.Columns.Add("id", "Id");
                edu_cat_con_data.Columns.Add("category", "Kategória neve");
                edu_cat_con_data.Columns.Add("maintenanceInterval", "Karbantartási időszak");
                edu_cat_con_data.Columns.Add("description", "Leírás");
                edu_cat_con_data.Columns.Add("parentCategory", "Szülő kategória");

                for (int i = 0; i < temp.Count; i++)
                {
                    DataGridViewRow row = (DataGridViewRow)edu_cat_con_data.Rows[0].Clone();
                    row.Cells[0].Value = temp[i].id;
                    row.Cells[1].Value = temp[i].category;
                    row.Cells[2].Value = temp[i].maintenanceInterval;
                    row.Cells[3].Value = temp[i].description;
                    if (temp[i].parentCategory is not null)
                    {
                        row.Cells[4].Value = temp[i].parentCategory.category;

                    }
                    else
                    {
                        row.Cells[4].Value = "";
                    }


                    edu_cat_con_data.Rows.Add(row);



                }


   



            }
        }



        public void list_edu()
        {
            using (var client = new WebClient())
            {
                client.Headers.Add("Content-Type:application/json");
                client.Headers.Add("Accept:application/json");

                var result = client.DownloadString("http://localhost:8080/education/list?search=");

                edlist = JsonConvert.DeserializeObject<edulist.Rootobject>(result);

                edulist_gridview.DataSource = edlist.items;
                edulist_gridview.Refresh();


            }
        }

        private void eduform_FormClosing(object sender, FormClosingEventArgs e)
        {
            menu Check = new menu();
            Check.Show();
            Hide();
        }

        private async void but_edu_create_Click(object sender, EventArgs e)
        {
            savedu(txt_edu_name.Text.ToString(), txt_edu_desc.Text.ToString());
            txt_edu_name.Text = "";
            txt_edu_desc.Text = "";

        }

        static async Task savedu(string name, string desc)
        {
                string json = "{\"param\": {\"name\" : \"" + name + "\",\"description\" : \"" + desc + "\"}}";

        
            


            string path = @"c:\temp\fuckyou24522.json";
            using (var tw = new StreamWriter(path, true))
            {
                tw.WriteLine(json.ToString());
                tw.Close();

            }

            //JObject jsonObject = JObject.Parse(json);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = null;
            using (var client = new HttpClient())
            {

                response = await client.PostAsync("http://localhost:8080/education/save", content);


                if (response.IsSuccessStatusCode)
                {


                    MessageBox.Show("Oktatás sikeresen rögzítve", "Üzenet");



                }
                else
                {
                    MessageBox.Show("Az oktazás rögzítése nem sikerült", "Üzenet");
                }



            }

        }

        private async void but_connecnt_cat_edu_Click(object sender, EventArgs e)
        {
            int eduid = Convert.ToInt32(edu_combobox.SelectedValue);
            int catid = Convert.ToInt32(cat_combobox.SelectedValue);
            connect_edu_cat(eduid, catid);

        }

        public void list_cat()
        {
            using (var client = new WebClient())
            {
                client.Headers.Add("Content-Type:application/json");
                client.Headers.Add("Accept:application/json");

                var result = client.DownloadString("http://localhost:8080/tool-category/list?search=");

                catlist = JsonConvert.DeserializeObject<toolcategory.Rootobject>(result);

            }
        }


        public class comb_item
        {
            public comb_item() { }

            public string Value { set; get; }
            public string Text { set; get; }
        }



        static async Task connect_edu_cat(int eduid, int catid)
        {
            string json = "{\"param\": {\"education\" : {\"id\" :" + eduid + "},\"toolCategory\" : { \"id\" :" + catid + "}}}";

         
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = null;
            using (var client = new HttpClient())
            {

                response = await client.PostAsync("http://localhost:8080/rel-education-tool-category/save", content);


                if (response.IsSuccessStatusCode)
                {


                    MessageBox.Show("Kapcsolat rögzítve", "Üzenet");



                }
                else
                {
                    MessageBox.Show("A kapcsolat rögzítése nem sikerült", "Üzenet");
                }



            }

        }

        private void oktat_combox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int eid = Convert.ToInt32(oktat_combox.SelectedValue);
            conn_list(eid);
        }
    }
}
