using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KuasWebApp.data
{
    public partial class data : System.Web.UI.Page
    {
        List<string> AboardNorth = new List<string>() { "臺北轉運站", "三重站", "南崁站", "板橋站", "中和站", "市府轉運站", "三峽站", "景美站", "新店站" };
        List<string> AboardTaichung = new List<string>() { "豐原站", "東勢站", "台中車站", "水湳站", "朝馬站" };



        protected void Page_Load(object sender, EventArgs e)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            var responseEntities = new List<Person>()
        {
            new Person{ Aboard="臺北轉運站", Getoff="豐原站",Number="1001"},
            new Person{ Aboard="臺北轉運站", Getoff="豐原站",Number="1002"},
            new Person{ Aboard="臺北轉運站", Getoff="豐原站",Number="1003"},
            new Person{ Aboard="臺北轉運站", Getoff="東勢站",Number="1004"},
            new Person{ Aboard="臺北轉運站", Getoff="東勢站",Number="1005"},
            new Person{ Aboard="臺北轉運站", Getoff="東勢站",Number="1005"},
            new Person{ Aboard="臺北轉運站", Getoff="台中車站",Number="1006"},
            new Person{ Aboard="臺北轉運站", Getoff="台中車站",Number="1007"},
            new Person{ Aboard="臺北轉運站", Getoff="台中車站",Number="1007"},
            new Person{ Aboard="臺北轉運站", Getoff="台中車站",Number="1008"},
            new Person{ Aboard="臺北轉運站", Getoff="台中車站",Number="1009"},
      
        };

            var result = serializer.Serialize(responseEntities);
            Response.Write(result);
            Response.End();
        }
    }
    public class Person
    {
        public string Aboard { get; set; }
        public string Getoff { get; set; }
        public string Number { get; set; }
    }
}

