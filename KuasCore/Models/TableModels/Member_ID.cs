namespace EnjoyEatCore.Models
{
    public class Member
    {
        /// <summary>
        /// 會員編號
        /// </summary>
        public string Member_ID { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        public string Member_Name { get; set; }

        /// <summary>
        /// 手機
        /// </summary>
        public string Member_Mobile { get; set; }

        /// <summary>
        /// 電話區碼
        /// </summary>
        public string Member_Telephonearea { get; set; }

        /// <summary>
        /// 電話
        /// </summary>
        public string Member_Telephone { get; set; }

        /// <summary>
        /// 性別
        /// </summary>
        public string Member_Gender { get; set; }

        /// <summary>
        /// 生日
        /// </summary>
        public string Member_Birth { get; set; }

        /// <summary>
        /// Google編號
        /// </summary>
        public string Member_GoogleID { get; set; }

        /// <summary>
        /// FB編號
        /// </summary>
        public string Member_FacebookID { get; set; }
    }
}