﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KuasWebApp.data
{
    public partial class data : System.Web.UI.Page
    {
        List<string> AboardNorth = new List<string>() { "臺北轉運站", "三重站", "南崁站", "板橋站", "中和站", "市府轉運站", "三峽站", "景美站", "新店站" };
        List<string> AboardTaichung = new List<string>() { "豐原站", "東勢站", "台中車站", "水湳站", "朝馬站" };
        List<string> AboardChanghua = new List<string>() { "彰化交流道站", "彰化站", "員林站", "溪湖站", "二林站" };
        List<string> AboardYunlin = new List<string>() { "北港站", "虎尾站", "西螺站", "嘉義轉運站", "嘉義北港路站", "大林站" };
        List<string> AboardSouth = new List<string>() { "北門站", "鹽行站", "新營站", "麻豆站", "仁德站", "建國站", "中華站", "中正站", "楠梓站", "岡山站", "屏東站","麟洛站" };

        protected void Page_Load(object sender, EventArgs e)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            var responseEntities = new List<ClassBus>()
        {

            new ClassBus{ Aboard="臺北轉運站", Getoff="豐原站",Number="1001",Price="210",Class1="120",Class2="60",Class3="60",Class4="60"},
            new ClassBus{ Aboard="臺北轉運站", Getoff="東勢站",Number="1001",Price="210",Class1="120",Class2="60",Class3="60",Class4="60"},
            new ClassBus{ Aboard="臺北轉運站", Getoff="台中車站",Number="1001",Price="210",Class1="120",Class2="60",Class3="60",Class4="60"},
            new ClassBus{ Aboard="臺北轉運站", Getoff="水湳站",Number="1001",Price="210",Class1="120",Class2="60",Class3="60",Class4="60"},
            new ClassBus{ Aboard="臺北轉運站", Getoff="朝馬站",Number="1001",Price="200",Class1="120",Class2="60",Class3="60",Class4="60"},
           
            new ClassBus{ Aboard="臺北轉運站", Getoff="彰化交流道站",Number="1002",Price="280",Class1="120",Class2="60",Class3="60",Class4="30"},
            new ClassBus{ Aboard="臺北轉運站", Getoff="彰化站",Number="1002",Price="280",Class1="120",Class2="60",Class3="60",Class4="60"},
            new ClassBus{ Aboard="臺北轉運站", Getoff="員林站",Number="1002",Price="280",Class1="120",Class2="60",Class3="60",Class4="60"},
            new ClassBus{ Aboard="臺北轉運站", Getoff="溪湖站",Number="1002",Price="280",Class1="120",Class2="60",Class3="60",Class4="60"},
            new ClassBus{ Aboard="臺北轉運站", Getoff="二林站",Number="1002",Price="280",Class1="120",Class2="60",Class3="60",Class4="60"},

            new ClassBus{ Aboard="臺北轉運站", Getoff="北港站",Number="1013",Price="380",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="臺北轉運站", Getoff="虎尾站",Number="1013",Price="380",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="臺北轉運站", Getoff="西螺站",Number="1013",Price="380",Class1="120",Class2="60",Class3="30",Class4="60"},
            new ClassBus{ Aboard="臺北轉運站", Getoff="嘉義轉運站",Number="1013",Price="380",Class1="120",Class2="60",Class3="30",Class4="60"},
            new ClassBus{ Aboard="臺北轉運站", Getoff="嘉義北港路站",Number="1013",Price="380",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="臺北轉運站", Getoff="大林站",Number="1013",Price="380",Class1="120",Class2="60",Class3="30",Class4="30"},

            new ClassBus{ Aboard="臺北轉運站", Getoff="北門站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="臺北轉運站", Getoff="鹽行站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="臺北轉運站", Getoff="新營站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="臺北轉運站", Getoff="仁德站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="臺北轉運站", Getoff="建國站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="臺北轉運站", Getoff="楠梓站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="臺北轉運站", Getoff="中華站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="臺北轉運站", Getoff="中正站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="臺北轉運站", Getoff="岡山站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="臺北轉運站", Getoff="屏東站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="臺北轉運站", Getoff="麟洛站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="臺北轉運站", Getoff="麻豆站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},

            new ClassBus{ Aboard="三重站", Getoff="豐原站",Number="1001",Price="210",Class1="120",Class2="60",Class3="60",Class4="60"},
            new ClassBus{ Aboard="三重站", Getoff="東勢站",Number="1001",Price="210",Class1="120",Class2="60",Class3="60",Class4="60"},
            new ClassBus{ Aboard="三重站", Getoff="台中車站",Number="1001",Price="210",Class1="120",Class2="60",Class3="60",Class4="60"},
            new ClassBus{ Aboard="三重站", Getoff="水湳站",Number="1001",Price="210",Class1="120",Class2="60",Class3="60",Class4="60"},
            new ClassBus{ Aboard="三重站", Getoff="朝馬站",Number="1001",Price="200",Class1="120",Class2="60",Class3="60",Class4="60"},

            new ClassBus{ Aboard="三重站", Getoff="彰化交流道站",Number="1002",Price="280",Class1="120",Class2="60",Class3="60",Class4="30"},
            new ClassBus{ Aboard="三重站", Getoff="彰化站",Number="1002",Price="280",Class1="120",Class2="60",Class3="60",Class4="60"},
            new ClassBus{ Aboard="三重站", Getoff="員林站",Number="1002",Price="280",Class1="120",Class2="60",Class3="60",Class4="60"},
            new ClassBus{ Aboard="三重站", Getoff="溪湖站",Number="1002",Price="280",Class1="120",Class2="60",Class3="60",Class4="60"},
            new ClassBus{ Aboard="三重站", Getoff="二林站",Number="1002",Price="280",Class1="120",Class2="60",Class3="60",Class4="60"},

            new ClassBus{ Aboard="三重站", Getoff="北港站",Number="1013",Price="380",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="三重站", Getoff="虎尾站",Number="1013",Price="380",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="三重站", Getoff="西螺站",Number="1013",Price="380",Class1="120",Class2="60",Class3="30",Class4="60"},
            new ClassBus{ Aboard="三重站", Getoff="嘉義轉運站",Number="1013",Price="380",Class1="120",Class2="60",Class3="30",Class4="60"},
            new ClassBus{ Aboard="三重站", Getoff="嘉義北港路站",Number="1013",Price="380",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="三重站", Getoff="大林站",Number="1013",Price="380",Class1="120",Class2="60",Class3="30",Class4="30"},

            new ClassBus{ Aboard="三重站", Getoff="北門站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="三重站", Getoff="鹽行站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="三重站", Getoff="新營站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="三重站", Getoff="仁德站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="三重站", Getoff="建國站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="三重站", Getoff="楠梓站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="三重站", Getoff="中華站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="三重站", Getoff="中正站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="三重站", Getoff="岡山站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="三重站", Getoff="屏東站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="三重站", Getoff="麟洛站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="三重站", Getoff="麻豆站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},

            new ClassBus{ Aboard="南崁站", Getoff="豐原站",Number="1001",Price="210",Class1="120",Class2="60",Class3="60",Class4="60"},
            new ClassBus{ Aboard="南崁站", Getoff="東勢站",Number="1001",Price="210",Class1="120",Class2="60",Class3="60",Class4="60"},
            new ClassBus{ Aboard="南崁站", Getoff="台中車站",Number="1001",Price="210",Class1="120",Class2="60",Class3="60",Class4="60"},
            new ClassBus{ Aboard="南崁站", Getoff="水湳站",Number="1001",Price="210",Class1="120",Class2="60",Class3="60",Class4="60"},
            new ClassBus{ Aboard="南崁站", Getoff="朝馬站",Number="1001",Price="200",Class1="120",Class2="60",Class3="60",Class4="60"},

            new ClassBus{ Aboard="南崁站", Getoff="彰化交流道站",Number="1002",Price="280",Class1="120",Class2="60",Class3="60",Class4="30"},
            new ClassBus{ Aboard="南崁站", Getoff="彰化站",Number="1002",Price="280",Class1="120",Class2="60",Class3="60",Class4="60"},
            new ClassBus{ Aboard="南崁站", Getoff="員林站",Number="1002",Price="280",Class1="120",Class2="60",Class3="60",Class4="60"},
            new ClassBus{ Aboard="南崁站", Getoff="溪湖站",Number="1002",Price="280",Class1="120",Class2="60",Class3="60",Class4="60"},
            new ClassBus{ Aboard="南崁站", Getoff="二林站",Number="1002",Price="280",Class1="120",Class2="60",Class3="60",Class4="60"},

            new ClassBus{ Aboard="南崁站", Getoff="北港站",Number="1013",Price="380",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="南崁站", Getoff="虎尾站",Number="1013",Price="380",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="南崁站", Getoff="西螺站",Number="1013",Price="380",Class1="120",Class2="60",Class3="30",Class4="60"},
            new ClassBus{ Aboard="南崁站", Getoff="嘉義轉運站",Number="1013",Price="380",Class1="120",Class2="60",Class3="30",Class4="60"},
            new ClassBus{ Aboard="南崁站", Getoff="嘉義北港路站",Number="1013",Price="380",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="南崁站", Getoff="大林站",Number="1013",Price="380",Class1="120",Class2="60",Class3="30",Class4="30"},

            new ClassBus{ Aboard="南崁站", Getoff="北門站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="南崁站", Getoff="鹽行站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="南崁站", Getoff="新營站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="南崁站", Getoff="仁德站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="南崁站", Getoff="建國站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="南崁站", Getoff="楠梓站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="南崁站", Getoff="中華站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="南崁站", Getoff="中正站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="南崁站", Getoff="岡山站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="南崁站", Getoff="屏東站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="南崁站", Getoff="麟洛站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="南崁站", Getoff="麻豆站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},

            new ClassBus{ Aboard="板橋站", Getoff="豐原站",Number="1001",Price="210",Class1="120",Class2="60",Class3="60",Class4="60"},
            new ClassBus{ Aboard="板橋站", Getoff="東勢站",Number="1001",Price="210",Class1="120",Class2="60",Class3="60",Class4="60"},
            new ClassBus{ Aboard="板橋站", Getoff="台中車站",Number="1001",Price="210",Class1="120",Class2="60",Class3="60",Class4="60"},
            new ClassBus{ Aboard="板橋站", Getoff="水湳站",Number="1001",Price="210",Class1="120",Class2="60",Class3="60",Class4="60"},
            new ClassBus{ Aboard="板橋站", Getoff="朝馬站",Number="1001",Price="200",Class1="120",Class2="60",Class3="60",Class4="60"},

            new ClassBus{ Aboard="板橋站", Getoff="彰化交流道站",Number="1002",Price="280",Class1="120",Class2="60",Class3="60",Class4="30"},
            new ClassBus{ Aboard="板橋站", Getoff="彰化站",Number="1002",Price="280",Class1="120",Class2="60",Class3="60",Class4="60"},
            new ClassBus{ Aboard="板橋站", Getoff="員林站",Number="1002",Price="280",Class1="120",Class2="60",Class3="60",Class4="60"},
            new ClassBus{ Aboard="板橋站", Getoff="溪湖站",Number="1002",Price="280",Class1="120",Class2="60",Class3="60",Class4="60"},
            new ClassBus{ Aboard="板橋站", Getoff="二林站",Number="1002",Price="280",Class1="120",Class2="60",Class3="60",Class4="60"},

            new ClassBus{ Aboard="板橋站", Getoff="北港站",Number="1013",Price="380",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="板橋站", Getoff="虎尾站",Number="1013",Price="380",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="板橋站", Getoff="西螺站",Number="1013",Price="380",Class1="120",Class2="60",Class3="30",Class4="60"},
            new ClassBus{ Aboard="板橋站", Getoff="嘉義轉運站",Number="1013",Price="380",Class1="120",Class2="60",Class3="30",Class4="60"},
            new ClassBus{ Aboard="板橋站", Getoff="嘉義北港路站",Number="1013",Price="380",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="板橋站", Getoff="大林站",Number="1013",Price="380",Class1="120",Class2="60",Class3="30",Class4="30"},

            new ClassBus{ Aboard="板橋站", Getoff="北門站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="板橋站", Getoff="鹽行站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="板橋站", Getoff="新營站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="板橋站", Getoff="仁德站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="板橋站", Getoff="建國站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="板橋站", Getoff="楠梓站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="板橋站", Getoff="中華站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="板橋站", Getoff="中正站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="板橋站", Getoff="岡山站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="板橋站", Getoff="屏東站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="板橋站", Getoff="麟洛站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="板橋站", Getoff="麻豆站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},

            new ClassBus{ Aboard="中和站", Getoff="豐原站",Number="1001",Price="210",Class1="120",Class2="60",Class3="60",Class4="60"},
            new ClassBus{ Aboard="中和站", Getoff="東勢站",Number="1001",Price="210",Class1="120",Class2="60",Class3="60",Class4="60"},
            new ClassBus{ Aboard="中和站", Getoff="台中車站",Number="1001",Price="210",Class1="120",Class2="60",Class3="60",Class4="60"},
            new ClassBus{ Aboard="中和站", Getoff="水湳站",Number="1001",Price="210",Class1="120",Class2="60",Class3="60",Class4="60"},
            new ClassBus{ Aboard="中和站", Getoff="朝馬站",Number="1001",Price="200",Class1="120",Class2="60",Class3="60",Class4="60"},

            new ClassBus{ Aboard="中和站", Getoff="彰化交流道站",Number="1002",Price="280",Class1="120",Class2="60",Class3="60",Class4="30"},
            new ClassBus{ Aboard="中和站", Getoff="彰化站",Number="1002",Price="280",Class1="120",Class2="60",Class3="60",Class4="60"},
            new ClassBus{ Aboard="中和站", Getoff="員林站",Number="1002",Price="280",Class1="120",Class2="60",Class3="60",Class4="60"},
            new ClassBus{ Aboard="中和站", Getoff="溪湖站",Number="1002",Price="280",Class1="120",Class2="60",Class3="60",Class4="60"},
            new ClassBus{ Aboard="中和站", Getoff="二林站",Number="1002",Price="280",Class1="120",Class2="60",Class3="60",Class4="60"},

            new ClassBus{ Aboard="中和站", Getoff="北港站",Number="1013",Price="380",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="中和站", Getoff="虎尾站",Number="1013",Price="380",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="中和站", Getoff="西螺站",Number="1013",Price="380",Class1="120",Class2="60",Class3="30",Class4="60"},
            new ClassBus{ Aboard="中和站", Getoff="嘉義轉運站",Number="1013",Price="380",Class1="120",Class2="60",Class3="30",Class4="60"},
            new ClassBus{ Aboard="中和站", Getoff="嘉義北港路站",Number="1013",Price="380",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="中和站", Getoff="大林站",Number="1013",Price="380",Class1="120",Class2="60",Class3="30",Class4="30"},

            new ClassBus{ Aboard="中和站", Getoff="北門站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="中和站", Getoff="鹽行站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="中和站", Getoff="新營站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="中和站", Getoff="仁德站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="中和站", Getoff="建國站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="中和站", Getoff="楠梓站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="中和站", Getoff="中華站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="中和站", Getoff="中正站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="中和站", Getoff="岡山站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="中和站", Getoff="屏東站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="中和站", Getoff="麟洛站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="中和站", Getoff="麻豆站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},

            new ClassBus{ Aboard="市府轉運站", Getoff="豐原站",Number="1001",Price="210",Class1="120",Class2="60",Class3="60",Class4="60"},
            new ClassBus{ Aboard="市府轉運站", Getoff="東勢站",Number="1001",Price="210",Class1="120",Class2="60",Class3="60",Class4="60"},
            new ClassBus{ Aboard="市府轉運站", Getoff="台中車站",Number="1001",Price="210",Class1="120",Class2="60",Class3="60",Class4="60"},
            new ClassBus{ Aboard="市府轉運站", Getoff="水湳站",Number="1001",Price="210",Class1="120",Class2="60",Class3="60",Class4="60"},
            new ClassBus{ Aboard="市府轉運站", Getoff="朝馬站",Number="1001",Price="200",Class1="120",Class2="60",Class3="60",Class4="60"},

            new ClassBus{ Aboard="市府轉運站", Getoff="彰化交流道站",Number="1002",Price="280",Class1="120",Class2="60",Class3="60",Class4="30"},
            new ClassBus{ Aboard="市府轉運站", Getoff="彰化站",Number="1002",Price="280",Class1="120",Class2="60",Class3="60",Class4="60"},
            new ClassBus{ Aboard="市府轉運站", Getoff="員林站",Number="1002",Price="280",Class1="120",Class2="60",Class3="60",Class4="60"},
            new ClassBus{ Aboard="市府轉運站", Getoff="溪湖站",Number="1002",Price="280",Class1="120",Class2="60",Class3="60",Class4="60"},
            new ClassBus{ Aboard="市府轉運站", Getoff="二林站",Number="1002",Price="280",Class1="120",Class2="60",Class3="60",Class4="60"},

            new ClassBus{ Aboard="市府轉運站", Getoff="北港站",Number="1013",Price="380",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="市府轉運站", Getoff="虎尾站",Number="1013",Price="380",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="市府轉運站", Getoff="西螺站",Number="1013",Price="380",Class1="120",Class2="60",Class3="30",Class4="60"},
            new ClassBus{ Aboard="市府轉運站", Getoff="嘉義轉運站",Number="1013",Price="380",Class1="120",Class2="60",Class3="30",Class4="60"},
            new ClassBus{ Aboard="市府轉運站", Getoff="嘉義北港路站",Number="1013",Price="380",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="市府轉運站", Getoff="大林站",Number="1013",Price="380",Class1="120",Class2="60",Class3="30",Class4="30"},

            new ClassBus{ Aboard="市府轉運站", Getoff="北門站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="市府轉運站", Getoff="鹽行站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="市府轉運站", Getoff="新營站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="市府轉運站", Getoff="仁德站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="市府轉運站", Getoff="建國站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="市府轉運站", Getoff="楠梓站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="市府轉運站", Getoff="中華站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="市府轉運站", Getoff="中正站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="市府轉運站", Getoff="岡山站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="市府轉運站", Getoff="屏東站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="市府轉運站", Getoff="麟洛站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="市府轉運站", Getoff="麻豆站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},


            new ClassBus{ Aboard="三峽站", Getoff="豐原站",Number="1001",Price="210",Class1="120",Class2="60",Class3="60",Class4="60"},
            new ClassBus{ Aboard="三峽站", Getoff="東勢站",Number="1001",Price="210",Class1="120",Class2="60",Class3="60",Class4="60"},
            new ClassBus{ Aboard="三峽站", Getoff="台中車站",Number="1001",Price="210",Class1="120",Class2="60",Class3="60",Class4="60"},
            new ClassBus{ Aboard="三峽站", Getoff="水湳站",Number="1001",Price="210",Class1="120",Class2="60",Class3="60",Class4="60"},
            new ClassBus{ Aboard="三峽站", Getoff="朝馬站",Number="1001",Price="200",Class1="120",Class2="60",Class3="60",Class4="60"},

            new ClassBus{ Aboard="三峽站", Getoff="彰化交流道站",Number="1002",Price="280",Class1="120",Class2="60",Class3="60",Class4="30"},
            new ClassBus{ Aboard="三峽站", Getoff="彰化站",Number="1002",Price="280",Class1="120",Class2="60",Class3="60",Class4="60"},
            new ClassBus{ Aboard="三峽站", Getoff="員林站",Number="1002",Price="280",Class1="120",Class2="60",Class3="60",Class4="60"},
            new ClassBus{ Aboard="三峽站", Getoff="溪湖站",Number="1002",Price="280",Class1="120",Class2="60",Class3="60",Class4="60"},
            new ClassBus{ Aboard="三峽站", Getoff="二林站",Number="1002",Price="280",Class1="120",Class2="60",Class3="60",Class4="60"},

            new ClassBus{ Aboard="三峽站", Getoff="北港站",Number="1013",Price="380",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="三峽站", Getoff="虎尾站",Number="1013",Price="380",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="三峽站", Getoff="西螺站",Number="1013",Price="380",Class1="120",Class2="60",Class3="30",Class4="60"},
            new ClassBus{ Aboard="三峽站", Getoff="嘉義轉運站",Number="1013",Price="380",Class1="120",Class2="60",Class3="30",Class4="60"},
            new ClassBus{ Aboard="三峽站", Getoff="嘉義北港路站",Number="1013",Price="380",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="三峽站", Getoff="大林站",Number="1013",Price="380",Class1="120",Class2="60",Class3="30",Class4="30"},

            new ClassBus{ Aboard="三峽站", Getoff="北門站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="三峽站", Getoff="鹽行站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="三峽站", Getoff="新營站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="三峽站", Getoff="仁德站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="三峽站", Getoff="建國站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="三峽站", Getoff="楠梓站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="三峽站", Getoff="中華站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="三峽站", Getoff="中正站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="三峽站", Getoff="岡山站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="三峽站", Getoff="屏東站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="三峽站", Getoff="麟洛站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="三峽站", Getoff="麻豆站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},

            new ClassBus{ Aboard="新店站", Getoff="豐原站",Number="1001",Price="210",Class1="120",Class2="60",Class3="60",Class4="60"},
            new ClassBus{ Aboard="新店站", Getoff="東勢站",Number="1001",Price="210",Class1="120",Class2="60",Class3="60",Class4="60"},
            new ClassBus{ Aboard="新店站", Getoff="台中車站",Number="1001",Price="210",Class1="120",Class2="60",Class3="60",Class4="60"},
            new ClassBus{ Aboard="新店站", Getoff="水湳站",Number="1001",Price="210",Class1="120",Class2="60",Class3="60",Class4="60"},
            new ClassBus{ Aboard="新店站", Getoff="朝馬站",Number="1001",Price="200",Class1="120",Class2="60",Class3="60",Class4="60"},
  
            new ClassBus{ Aboard="新店站", Getoff="彰化交流道站",Number="1002",Price="280",Class1="120",Class2="60",Class3="60",Class4="30"},
            new ClassBus{ Aboard="新店站", Getoff="彰化站",Number="1002",Price="280",Class1="120",Class2="60",Class3="60",Class4="60"},
            new ClassBus{ Aboard="新店站", Getoff="員林站",Number="1002",Price="280",Class1="120",Class2="60",Class3="60",Class4="60"},
            new ClassBus{ Aboard="新店站", Getoff="溪湖站",Number="1002",Price="280",Class1="120",Class2="60",Class3="60",Class4="60"},
            new ClassBus{ Aboard="新店站", Getoff="二林站",Number="1002",Price="280",Class1="120",Class2="60",Class3="60",Class4="60"},
            
            new ClassBus{ Aboard="新店站", Getoff="北港站",Number="1013",Price="380",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="新店站", Getoff="虎尾站",Number="1013",Price="380",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="新店站", Getoff="西螺站",Number="1013",Price="380",Class1="120",Class2="60",Class3="30",Class4="60"},
            new ClassBus{ Aboard="新店站", Getoff="嘉義轉運站",Number="1013",Price="380",Class1="120",Class2="60",Class3="30",Class4="60"},
            new ClassBus{ Aboard="新店站", Getoff="嘉義北港路站",Number="1013",Price="380",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="新店站", Getoff="大林站",Number="1013",Price="380",Class1="120",Class2="60",Class3="30",Class4="30"},

            new ClassBus{ Aboard="新店站", Getoff="北門站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="新店站", Getoff="鹽行站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="新店站", Getoff="新營站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="新店站", Getoff="仁德站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="新店站", Getoff="建國站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="新店站", Getoff="楠梓站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="新店站", Getoff="中華站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="新店站", Getoff="中正站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="新店站", Getoff="岡山站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="新店站", Getoff="屏東站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="新店站", Getoff="麟洛站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="新店站", Getoff="麻豆站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},


            new ClassBus{ Aboard="市府轉運站", Getoff="豐原站",Number="1001",Price="210",Class1="120",Class2="60",Class3="60",Class4="60"},
            new ClassBus{ Aboard="市府轉運站", Getoff="東勢站",Number="1001",Price="210",Class1="120",Class2="60",Class3="60",Class4="60"},
            new ClassBus{ Aboard="市府轉運站", Getoff="台中車站",Number="1001",Price="210",Class1="120",Class2="60",Class3="60",Class4="60"},
            new ClassBus{ Aboard="市府轉運站", Getoff="水湳站",Number="1001",Price="210",Class1="120",Class2="60",Class3="60",Class4="60"},
            new ClassBus{ Aboard="市府轉運站", Getoff="朝馬站",Number="1001",Price="200",Class1="120",Class2="60",Class3="60",Class4="60"},
      
            new ClassBus{ Aboard="市府轉運站", Getoff="彰化交流道站",Number="1002",Price="280",Class1="120",Class2="60",Class3="60",Class4="30"},
            new ClassBus{ Aboard="市府轉運站", Getoff="彰化站",Number="1002",Price="280",Class1="120",Class2="60",Class3="60",Class4="60"},
            new ClassBus{ Aboard="市府轉運站", Getoff="員林站",Number="1002",Price="280",Class1="120",Class2="60",Class3="60",Class4="60"},
            new ClassBus{ Aboard="市府轉運站", Getoff="溪湖站",Number="1002",Price="280",Class1="120",Class2="60",Class3="60",Class4="60"},
            new ClassBus{ Aboard="市府轉運站", Getoff="二林站",Number="1002",Price="280",Class1="120",Class2="60",Class3="60",Class4="60"},

            new ClassBus{ Aboard="市府轉運站", Getoff="北港站",Number="1013",Price="380",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="市府轉運站", Getoff="虎尾站",Number="1013",Price="380",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="市府轉運站", Getoff="西螺站",Number="1013",Price="380",Class1="120",Class2="60",Class3="30",Class4="60"},
            new ClassBus{ Aboard="市府轉運站", Getoff="嘉義轉運站",Number="1013",Price="380",Class1="120",Class2="60",Class3="30",Class4="60"},
            new ClassBus{ Aboard="市府轉運站", Getoff="嘉義北港路站",Number="1013",Price="380",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="市府轉運站", Getoff="大林站",Number="1013",Price="380",Class1="120",Class2="60",Class3="30",Class4="30"},

            new ClassBus{ Aboard="市府轉運站", Getoff="北門站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="市府轉運站", Getoff="鹽行站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="市府轉運站", Getoff="新營站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="市府轉運站", Getoff="仁德站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="市府轉運站", Getoff="建國站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="市府轉運站", Getoff="楠梓站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="市府轉運站", Getoff="中華站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="市府轉運站", Getoff="中正站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="市府轉運站", Getoff="岡山站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="市府轉運站", Getoff="屏東站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="市府轉運站", Getoff="麟洛站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
            new ClassBus{ Aboard="市府轉運站", Getoff="麻豆站",Number="2053",Price="470",Class1="120",Class2="60",Class3="30",Class4="30"},
   
      
      
        };

            var result = serializer.Serialize(responseEntities);



            Response.Write(result);
            Response.End();
        }
    }
    public class ClassBus
    {
        public string Aboard { get; set; }
        public string Getoff { get; set; }
        public string Number { get; set; } //班次
        public string Price { get; set; }
        public string Class1 { get; set; }
        public string Class2 { get; set; }
        public string Class3 { get; set; }
        public string Class4 { get; set; }
    }
    
}

