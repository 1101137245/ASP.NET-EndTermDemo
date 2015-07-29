namespace EnjoyEatCore.Models
{
    public class SocialActivity
    {
        /// <summary>
        /// 社群活動編號
        /// </summary>
        public string SocialActivity_ID { get; set; }

        /// <summary>
        /// 標題
        /// </summary>
        public string SocialActivity_Title { get; set; }

        /// <summary>
        /// 內容
        /// </summary>
        public string SocialActivity_Content { get; set; }

        /// <summary>
        /// 活動日
        /// </summary>
        public string SocialActivity_Activedate { get; set; }

        /// <summary>
        /// 活動時間
        /// </summary>
        public string SocialActivity_Activetime { get; set; }

        /// <summary>
        /// 發起時間
        /// </summary>
        public string SocialActivity_Datetime { get; set; }

        /// <summary>
        /// 發起人
        /// </summary>
        public string SocialActivity_Sponsor { get; set; }
    }
}