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
            tools_tabcontrol.TabPages[4].Text = "Eszköz szerkesztése";
            tools_tabcontrol.TabPages[5].Text = "Kategória szerkesztése";
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
            savetool(txt_name.Text.ToString(), txt_identi.Text.ToString(), txt_desc.Text.ToString(),id, -1);
           
            txt_name.Text = "";
            txt_identi.Text = "";
            txt_desc.Text = "";
        }

        static async Task savetool(string name, string iden, string desc, int id, int toolid)
        {
            string json;
            if (toolid==-1)
            {
                json = "{\"param\": {\"name\" : \"" + name + "\",\"identifier\" : \"" + iden + "\",\"description\" : \"" + desc + "\", \"toolCategory\": { \"id\" : " + id + "}}}";

            }
            else
            {
                json = "{\"param\": {\"id\" : "+toolid+ ",\"name\" : \"" + name + "\",\"identifier\" : \"" + iden + "\",\"description\" : \"" + desc + "\", \"toolCategory\": { \"id\" : " + id + "}}}";

            }





            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = null;
            using (var client = new HttpClient())
            {

                response = await client.PostAsync("http://localhost:8080/tool/save", content);


                if (response.IsSuccessStatusCode)
                {
                    if (toolid == -1)
                    {

                        MessageBox.Show("Eszköz sikeresen rögzítve", "Üzenet");
                    }
                    else
                    {
                        MessageBox.Show("Eszköz adatai sikeresen módosítva letttek", "Üzenet");
                    }
                
                }
                else
                {
                    MessageBox.Show("Az eszköz rögzítése nem sikerült", "Üzenet");
                }



            }

        }

        private void tools_tabcontrol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tools_tabcontrol.SelectedIndex == 0)
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
            else if (tools_tabcontrol.SelectedIndex == 4)
            {
                list_tools();

                List<comb_item> sel_tool = new List<comb_item>();
                sel_tool.Add(new comb_item() { Text = "Kérem válasszon", Value = "-1" });
                for (int i = 0; i < toollist.items.Length; i++)
                {


                    sel_tool.Add(new comb_item() { Text = toollist.items[i].name.ToString(), Value = toollist.items[i].id.ToString() });
                }

                select_edit_tool_combobox.DataSource = sel_tool;
                select_edit_tool_combobox.DisplayMember = "Text";
                select_edit_tool_combobox.ValueMember = "Value";

                comboadditems(edit_tool_cat_combobox);


            }


            else if (tools_tabcontrol.SelectedIndex == 5)
            {
                list_cat();
                comboadditems(select_edit_cat_combobox); 
                comboadditems(edit_cat_parent_cat_combobox);

                List<comb_item> time = new List<comb_item>();

                time.Add(new comb_item() { Text = "Éves", Value = "YEAR" });
                time.Add(new comb_item() { Text = "Féléves", Value = "HALF_YEAR" });
                time.Add(new comb_item() { Text = "Negyedves", Value = "QUARTER" });
                time.Add(new comb_item() { Text = "Havi", Value = "MONTH" });
                time.Add(new comb_item() { Text = "Heti", Value = "WEEK" });


                edit_cat_select_time_combobox.DataSource = time;
                edit_cat_select_time_combobox.DisplayMember = "Text";
                edit_cat_select_time_combobox.ValueMember = "Value";




            }



        }

        private async void but_new_cat_Click(object sender, EventArgs e)
        {
            int parid = Convert.ToInt32(parent_cat_combobox.SelectedValue);
            savecat(txt_cat_name.Text.ToString(), time_combobox.SelectedValue.ToString(), txt_cat_desc.Text.ToString(), parid,-1);

            txt_cat_desc.Text = "";
            txt_cat_name.Text = "";
           
        }


        static async Task savecat(string name, string interval, string desc, int patentid, int catid)
        {
            string json = "{\"param\": {";
            if (catid != -1)
            {
                json += "\"id\" : " + catid + ",";
            }
            
                json += "\"category\" : \"" + name + "\",\"maintenanceInterval\" : \"" + interval + "\",\"description\" : \"" + desc + "\"";


            if (patentid!=-1)
            {
                json += ", \"parentCategory\": { \"id\" : " + patentid + "}}}";
            }
            else
            {
                json += "}}";
            }
            



            //JObject jsonObject = JObject.Parse(json);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = null;
            using (var client = new HttpClient())
            {

                response = await client.PostAsync("http://localhost:8080/tool-category/save", content);


                if (response.IsSuccessStatusCode)
                {


                    if (catid == -1)
                    {
                        MessageBox.Show("Kategória sikeresen rögzítve", "Üzenet");
                    }
                    else
                    {
                        MessageBox.Show("Kategória sikeresen módosítva", "Üzenet");
                    }
                   

                }
                else
                {
                    MessageBox.Show("Az kategória rögzítése nem sikerült", "Üzenet");
                }



            }

        }

        private void toolform_FormClosing(object sender, FormClosingEventArgs e)
        {
            menu Check = new menu();
            Check.Show();
            Hide();
        }

        private void select_edit_tool_combobox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (Convert.ToInt32(select_edit_tool_combobox.SelectedValue) != -1)
            {

                int toolid = Convert.ToInt32(select_edit_tool_combobox.SelectedValue);
                int index = 0;
          
                while (toolid != toollist.items[index].id)
                {
                    index++;
                };
                txt_edit_tool_name.Text = toollist.items[index].name;
                txt_edit_tool_iden.Text = toollist.items[index].identifier;
                txt_edit_tool_desc.Text = toollist.items[index].description;
               
                edit_tool_cat_combobox.SelectedValue = toollist.items[index].toolCategory.id.ToString();
      

            }
            else
            {
                txt_edit_tool_desc.Text = "";
                txt_edit_tool_iden.Text = "";
                txt_edit_tool_name.Text = "";
            }
        }

        private async void but_edit_tool_Click(object sender, EventArgs e)
        {
            savetool(txt_edit_tool_name.Text.ToString(), txt_edit_tool_iden.Text.ToString(), txt_edit_tool_desc.Text.ToString(), Convert.ToInt32(edit_tool_cat_combobox.SelectedValue), Convert.ToInt32(select_edit_tool_combobox.SelectedValue));
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            savecat(txt_edit_cat_name.Text.ToString(), edit_cat_select_time_combobox.SelectedValue.ToString(), txt_edit_cat_desc.Text.ToString(), Convert.ToInt32(edit_cat_parent_cat_combobox.SelectedValue), Convert.ToInt32(select_edit_cat_combobox.SelectedValue));

        }

        private void select_edit_cat_combobox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (Convert.ToInt32(select_edit_cat_combobox.SelectedValue) != -1)
            {

                int cazid = Convert.ToInt32(select_edit_cat_combobox.SelectedValue);
                int index = 0;

                while (cazid != catlist.items[index].id)
                {
                    index++;
                };
                txt_edit_cat_name.Text = catlist.items[index].category;
                txt_edit_cat_desc.Text = catlist.items[index].description;
       

                edit_cat_select_time_combobox.SelectedValue = catlist.items[index].maintenanceInterval.ToString();
                edit_cat_parent_cat_combobox.SelectedValue = catlist.items[index].parentCategory.id;


            }
            else
            {
                txt_edit_cat_name.Text = "";
                txt_edit_cat_desc.Text = "";
        
            }
        }
    }
}
