namespace EnjoyEatCore.Models
{
    public class Comment
    {
        /// <summary>
        /// 評論編號
        /// </summary>
        public string Comment_ID { get; set; }

        /// <summary>
        /// 標題
        /// </summary>
        public string Comment_Title { get; set; }

        /// <summary>
        /// 內容
        /// </summary>
        public string Comment_Content { get; set; }

        /// <summary>
        /// 分數
        /// </summary>
        public string Comment_Score { get; set; }

        /// <summary>
        /// 日期時間
        /// </summary>
        public string Comment_Datetime { get; set; }

        /// <summary>
        /// 會員編號
        /// </summary>
        public string Member_ID { get; set; }

        /// <summary>
        /// 餐廳編號
        /// </summary>
        public string Restaurant_ID { get; set; }
    }
}