using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;
using System.Net;

namespace ArithmeticMeanCSharp
{

    public class Education
    {
        public string certificate { get; set; }
        public string university { get; set; }
    }

    public class Marriage
    {
        public bool married { get; set; }
    }

    public class OnlineInfo
    {
        public string email { get; set; }
        public string ip_address { get; set; }
        public string ipv6_address { get; set; }
        public string password { get; set; }
        public string password_md5 { get; set; }
        public string user_agent { get; set; }
        public string username { get; set; }
    }

    public class Personal
    {
        public int age { get; set; }
        public string blood { get; set; }
        public object born { get; set; }
        public string born_place { get; set; }
        public string cellphone { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public string eye_color { get; set; }
        public string father_name { get; set; }
        public string gender { get; set; }
        public string height { get; set; }
        public string last_name { get; set; }
        public string name { get; set; }
        public string national_code { get; set; }
        public string religion { get; set; }
        public string system_id { get; set; }
        public int weight { get; set; }
    }

    public class Work
    {
        public string country_code { get; set; }
        public bool insurance { get; set; }
        public string position { get; set; }
        public string salary { get; set; }
    }

    public class Person
    {
        public Education education { get; set; }
        public Marriage marriage { get; set; }
        public OnlineInfo online_info { get; set; }
        public Personal personal { get; set; }
        public Work work { get; set; }
    }

    public class ExamplePerson
    {
        public Person person { get; set; }
    }

    public class RandomPerson
    {
        
        static public string url = "https://pipl.ir/v1/getPerson";

        static public Person Generate()
        {

            string jsonString = string.Empty;

            
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                jsonString = reader.ReadToEnd();
            }

            ExamplePerson EP = JsonSerializer.Deserialize<ExamplePerson>(jsonString);
            return EP.person;

        }
    }

}
