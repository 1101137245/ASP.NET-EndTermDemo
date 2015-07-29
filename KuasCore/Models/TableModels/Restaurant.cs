namespace EnjoyEatCore.Models
{
    public class Restaurant
    {
        /// <summary>
        /// 餐廳編號
        /// </summary>
        public string Restaurant_ID { get; set; }

        /// <summary>
        /// 餐廳名稱
        /// </summary>
        public string Restaurant_Name { get; set; }

        /// <summary>
        /// 餐廳分店名
        /// </summary>
        public string Restaurant_BranchName { get; set; }

        /// <summary>
        /// 餐廳郵遞區號
        /// </summary>
        public string Restaurant_Addresszip { get; set; }

        /// <summary>
        /// 餐廳地址
        /// </summary>
        public string Restaurant_Address { get; set; }

        /// <summary>
        /// 餐廳電話區碼
        /// </summary>
        public string Restaurant_Telephonearea { get; set; }

        /// <summary>
        /// 餐廳電話
        /// </summary>
        public string Restaurant_Telephone { get; set; }

        /// <summary>
        /// 餐廳官方網站
        /// </summary>
        public string Restaurant_Officialwebsite { get; set; }

        /// <summary>
        /// 容納人數
        /// </summary>
        public string Restaurant_Capacity { get; set; }

        /// <summary>
        /// 停車場有無
        /// </summary>
        public string Restaurant_Parking { get; set; }

        /// <summary>
        /// 信用卡
        /// </summary>
        public string Restaurant_Creditcard { get; set; }

        /// <summary>
        /// 無障礙空間
        /// </summary>
        public string Restaurant_Accessible { get; set; }

        /// <summary>
        /// WIFY無線網路
        /// </summary>
        public string Restaurant_Wifi { get; set; }

        /// <summary>
        /// 最高消費
        /// </summary>
        public string Restaurant_Costmax { get; set; }

        /// <summary>
        /// 最低消費
        /// </summary>
        public string Restaurant_Costmin { get; set; }

        /// <summary>
        /// 平均消費
        /// </summary>
        public string Restaurant_Costavg { get; set; }

        /// <summary>
        /// 低消
        /// </summary>
        public string Restaurant_Mincharge { get; set; }

        /// <summary>
        /// 餐廳簡介
        /// </summary>
        public string Restaurant_Summary { get; set; }

        /// <summary>
        /// 交通資訊
        /// </summary>
        public string Restaurant_Trafficinformation { get; set; }

        /// <summary>
        /// 公司編號
        /// </summary>
        public string Company_ID { get; set; }

        /// <summary>
        /// 地區編號
        /// </summary>
        public string Region_ID { get; set; }
    }
}