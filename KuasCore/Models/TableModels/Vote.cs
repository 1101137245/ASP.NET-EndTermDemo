namespace EnjoyEatCore.Models
{
    public class Vote
    {
        /// <summary>
        /// 投票編號
        /// </summary>
        public string Vote_ID { get; set; }

        /// <summary>
        /// 投票標題
        /// </summary>
        public string Vote_Title { get; set; }

        /// <summary>
        /// 投票類型
        /// </summary>
        public string Vote_Type { get; set; }

        /// <summary>
        /// 多選
        /// </summary>
        public string Vote_Multi { get; set; }

        /// <summary>
        /// 投票開始時間
        /// </summary>
        public string Vote_Startdatetime { get; set; }

        /// <summary>
        /// 投票結束時間
        /// </summary>
        public string Vote_Enddatetime { get; set; }

        /// <summary>
        /// 投票發起時間
        /// </summary>
        public string Vote_Datetime { get; set; }

        /// <summary>
        /// 社群活動編號
        /// </summary>
        public string SocialActivity_ID { get; set; }
    }
}