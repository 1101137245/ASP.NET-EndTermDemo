namespace EnjoyEatCore.Models
{
    public class Company
    {
        /// <summary>
        /// 總公司編號
        /// </summary>
        public string Company_ID { get; set; }

        /// <summary>
        /// 名稱
        /// </summary>
        public string Company_Name { get; set; }

        /// <summary>
        /// 簡稱
        /// </summary>
        public string Company_Shortname { get; set; }

        /// <summary>
        /// 地址郵遞區號
        /// </summary>
        public string Company_Addresszip { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        public string Company_Address { get; set; }

        /// <summary>
        /// 負責人姓名
        /// </summary>
        public string Company_PICName { get; set; }

        /// <summary>
        /// 負責人手機
        /// </summary>
        public string Company_PICMobile { get; set; }

        /// <summary>
        /// 電話區碼
        /// </summary>
        public string Company_Telephonearea { get; set; }

        /// <summary>
        /// 電話
        /// </summary>
        public string Company_Telephone { get; set; }

        /// <summary>
        /// 電話分機
        /// </summary>
        public string Company_Telephoneext { get; set; }

        /// <summary>
        /// 傳真區碼
        /// </summary>
        public string Company_Faxarea { get; set; }

        /// <summary>
        /// 傳真
        /// </summary>
        public string Company_Fax { get; set; }

        /// <summary>
        /// 傳真分機
        /// </summary>
        public string Company_Faxext { get; set; }

        /// <summary>
        /// 管理員帳號
        /// </summary>
        public string Company_Adminname { get; set; }

        /// <summary>
        /// 管理員密碼
        /// </summary>
        public string Company_Adminpasswd { get; set; }
    }
}