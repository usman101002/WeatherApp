using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;


namespace WeatherApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            WebRequest request = WebRequest.Create("http://api.openweathermap.org/data/2.5/find?q=Novosibirsk,RU&type=like&APPID=51f5cb510e27f23f867cc7bfa5d499ea");
            request.Method = "POST";
            request.ContentType = "application/x-www-urlencoded";
            WebResponse responce = await request.GetResponseAsync();

            string answer = string.Empty;

            using (Stream s = responce.GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(s))
                {
                    answer = await reader.ReadToEndAsync();
                }
            }

            richTextBox1.Text = answer;

            OpenWeather.OpenWeather ow = JsonConvert.DeserializeObject<OpenWeather.OpenWeather>(answer);
            MessageBox.Show("ахаххаха");


            

        }

        
    }
}
