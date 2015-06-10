using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KuasWebApp.data
{
    public partial class data : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)//Get Method
            {
                //準備資料
                string number = "5487";
          
                string name = "test";
                string time = "15:16.2342";
                List<string> ids = new List<string>() { "4", "8", "15", "16", "23", "42" };


                //開始拼接字串
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("{");
                sb.AppendLine("\"number\":\"" + number + "\",");
                sb.AppendLine("\"data\":{");
                sb.AppendLine("\"name\":\"" + name + "\",");
                sb.AppendLine("\"time\":\"" + time + "\"");
                sb.AppendLine("},");
                sb.AppendLine("\"registration_ids\":[");
                foreach (string item in ids)
                {
                    sb.Append("\"" + item + "\",");
                }
                sb = new StringBuilder(sb.ToString().TrimEnd(','));//移除最後一個「,」字元
                sb.AppendLine("]");
                sb.AppendLine("}");

                //輸出結果
                Response.Write(sb.ToString());
            }
        }
    }
}