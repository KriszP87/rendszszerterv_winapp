using System;
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
    public partial class Login : Form
    {

 
        public Login()
        {
            InitializeComponent();
         
        }

        private async void but_login_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text.ToString();
            string password = txt_password.Text.ToString();

            await Task.Run(async () =>
            {
                await login(username, password);
            });

           



            if (variables.returncode=="OK")
            {
                menu Check = new menu();
                Check.Show();
                Hide();
             
            }
            else
            {
                lab_retunr.Text = variables.returncode;
              
            }


        }

     

        static async Task login(string username, string password)
        {
            
            string json = "{\"param\": {\"username\" : \"" + username + "\",\"password\" : \"" + password + "\"}}";
         

            //JObject jsonObject = JObject.Parse(json);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = null;
            using (var client = new HttpClient())
            {

                response = await client.PostAsync("http://localhost:8080/user/login", content);


                if (response.IsSuccessStatusCode)
                {

                 

                    var result = await  response.Content.ReadAsStringAsync();


                 
                    variables.Rootobject record = JsonConvert.DeserializeObject<variables.Rootobject>(result);


                

                     variables.currentuser = record;

         
                    variables.returncode = response.StatusCode.ToString();
                

                }
                else
                {
                    variables.returncode = response.StatusCode.ToString();
                }
             

            }

        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }
    }
}
