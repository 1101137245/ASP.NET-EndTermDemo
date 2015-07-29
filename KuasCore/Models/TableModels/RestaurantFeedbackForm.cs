namespace EnjoyEatCore.Models
{
    public class RestaurantFeedbackForm
    {
        /// <summary>
        /// 餐廳意見回饋表編號
        /// </summary>
        public string RestaurantFeedbackForm_ID { get; set; }

        /// <summary>
        /// 問題名稱
        /// </summary>
        public string RestaurantFeedbackForm_Name { get; set; }

        /// <summary>
        /// 問題編號
        /// </summary>
        public string RestaurantFeedbackForm_Number { get; set; }

        /// <summary>
        /// 問題類型
        /// </summary>
        public string RestaurantFeedbackForm_Type { get; set; }

        /// <summary>
        /// 餐廳編號
        /// </summary>
        public string Restaurant_ID { get; set; }
    }
}