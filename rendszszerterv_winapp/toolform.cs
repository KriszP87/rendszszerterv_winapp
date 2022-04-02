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
    public partial class toolform : Form
    {
        tools.Rootobject toollist;
        toolcategory.Rootobject catlist;
        public toolform()
        {
            InitializeComponent();

           

            tools_tabcontrol.TabPages[0].Text = "Eszközök listázás";
            tools_tabcontrol.TabPages[1].Text = "Eszköz hozzáadása";
            tools_tabcontrol.TabPages[2].Text = "Kategória hozzáadása";
            tools_tabcontrol.TabPages[3].Text = "Kategóriák listázása";
            list_tools();

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

        public class comb_item {
            public comb_item() { }

            public string Value { set; get; }
            public string Text { set; get; }
        }
        public void comboadditems( ComboBox dd_lista)
        {

            List<comb_item> catl = new List<comb_item>();
            catl.Add(new comb_item() { Text = "Kérem válasszon", Value = "-1" });
            for (int i = 0; i < catlist.items.Length; i++)
            {
             
                catl.Add(new comb_item() { Text = catlist.items[i].category.ToString(), Value = catlist.items[i].id.ToString() });
            }

            dd_lista.DataSource = catl;
            dd_lista.DisplayMember = "Text";
            dd_lista.ValueMember = "Value";
        }

            public void list_tools()
        {
            using (var client = new WebClient()) 
            {
                client.Headers.Add("Content-Type:application/json");  
                client.Headers.Add("Accept:application/json");

                var result = client.DownloadString("http://localhost:8080/tool/list?search="); 
                                                                                     
                toollist = JsonConvert.DeserializeObject<tools.Rootobject>(result);

            }
            tool_list_datagrid.Rows.Clear();
            tool_list_datagrid.Columns.Clear();
            tool_list_datagrid.Columns.Add("id", "Id");
            tool_list_datagrid.Columns.Add("name", "Név");
            tool_list_datagrid.Columns.Add("identifier", "Azonosító");
            tool_list_datagrid.Columns.Add("toolCategory", "Kategória");
           
            for (int i = 0; i < toollist.items.Length; i++)
            {
                DataGridViewRow row = (DataGridViewRow)tool_list_datagrid.Rows[0].Clone();
                row.Cells[0].Value = toollist.items[i].id;
                row.Cells[1].Value = toollist.items[i].name;
                row.Cells[2].Value = toollist.items[i].identifier;
                row.Cells[3].Value = toollist.items[i].toolCategory.category;

                tool_list_datagrid.Rows.Add(row);
              


            }
            tool_list_datagrid.Refresh();

            


        }

        private async void but_createtool_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(cat_list_combobox.SelectedValue);
            savetool(txt_name.Text.ToString(), txt_identi.Text.ToString(), txt_desc.Text.ToString(),id );
           
            txt_name.Text = "";
            txt_identi.Text = "";
            txt_desc.Text = "";
        }

        static async Task savetool(string name, string iden, string desc, int id)
        {
          
               string  json = "{\"param\": {\"name\" : \"" + name + "\",\"identifier\" : \"" + iden + "\",\"description\" : \"" + desc + "\", \"toolCategory\": { \"id\" : "+id+"}}}";

           


          
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = null;
            using (var client = new HttpClient())
            {

                response = await client.PostAsync("http://localhost:8080/tool/save", content);


                if (response.IsSuccessStatusCode)
                {

                    
                        MessageBox.Show("Eszköz sikeresen rögzítve", "Üzenet");
                    
                
                }
                else
                {
                    MessageBox.Show("Az eszköz rögzítése nem sikerült", "Üzenet");
                }



            }

        }

        private void tools_tabcontrol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tools_tabcontrol.SelectedIndex==0)
            {
                list_tools();
            }
            else if (tools_tabcontrol.SelectedIndex == 1)
            {
                list_cat();
                comboadditems(cat_list_combobox);
            }
            else if (tools_tabcontrol.SelectedIndex == 2)
            {
                list_cat();
                comboadditems(parent_cat_combobox);
                List<comb_item> catl = new List<comb_item>();

                catl.Add(new comb_item() { Text = "Éves", Value = "YEAR" });
                catl.Add(new comb_item() { Text = "Féléves", Value = "HALF_YEAR" });
                catl.Add(new comb_item() { Text = "Negyedves", Value = "QUARTER" });
                catl.Add(new comb_item() { Text = "Havi", Value = "MONTH" });
                catl.Add(new comb_item() { Text = "Heti", Value = "WEEK" });


                time_combobox.DataSource = catl;
                time_combobox.DisplayMember = "Text";
                time_combobox.ValueMember = "Value";

            }

            else if (tools_tabcontrol.SelectedIndex == 3)
            {
                list_cat();
                cat_list_grid.Columns.Clear();
                cat_list_grid.Rows.Clear();
                cat_list_grid.Columns.Add("id", "Id");
                cat_list_grid.Columns.Add("category", "Név");
                cat_list_grid.Columns.Add("maintenanceInterval", "Karbantartási időszak");
                cat_list_grid.Columns.Add("description", "Leírás");
                cat_list_grid.Columns.Add("parentCategory", "Szülő kategória");
               
                for (int i = 0; i < catlist.items.Length; i++)
                {
                    DataGridViewRow row = (DataGridViewRow)cat_list_grid.Rows[0].Clone();
                    row.Cells[0].Value = catlist.items[i].id;
                    row.Cells[1].Value = catlist.items[i].category;
                    row.Cells[2].Value = catlist.items[i].maintenanceInterval;
                    row.Cells[3].Value = catlist.items[i].description;
                    if (catlist.items[i].parentCategory is not null)
                    {
                        row.Cells[4].Value = catlist.items[i].parentCategory.category;
                      
                    }
                    else
                    {
                        row.Cells[4].Value = "";
                    }


                    cat_list_grid.Rows.Add(row);



                }
                tool_list_datagrid.Refresh();

            }
        }

        private async void but_new_cat_Click(object sender, EventArgs e)
        {
            int parid = Convert.ToInt32(parent_cat_combobox.SelectedValue);
            savecat(txt_cat_name.Text.ToString(), time_combobox.SelectedValue.ToString(), txt_cat_desc.Text.ToString(), parid);

            txt_cat_desc.Text = "";
            txt_cat_name.Text = "";
           
        }


        static async Task savecat(string name, string interval, string desc, int id)
        {
            string json;

            if (id==-1)
            {
                json = "{\"param\": {\"category\" : \"" + name + "\",\"maintenanceInterval\" : \"" + interval + "\",\"description\" : \"" + desc + "\"}}";

            }
            else
            {

           
             json = "{\"param\": {\"category\" : \"" + name + "\",\"maintenanceInterval\" : \"" + interval + "\",\"description\" : \"" + desc + "\", \"parentCategory\": { \"id\" : " + id + "}}}";
             
            }



            //JObject jsonObject = JObject.Parse(json);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = null;
            using (var client = new HttpClient())
            {

                response = await client.PostAsync("http://localhost:8080/tool-category/save", content);


                if (response.IsSuccessStatusCode)
                {

                
                    
                        MessageBox.Show("Kategória sikeresen rögzítve", "Üzenet");
                    
                   

                }
                else
                {
                    MessageBox.Show("Az kategória rögzítése nem sikerült", "Üzenet");
                }



            }

        }

        private void toolform_FormClosing(object sender, FormClosingEventArgs e)
        {
            eduform Check = new eduform();
            Check.Show();
            Hide();
        }
    }
}
