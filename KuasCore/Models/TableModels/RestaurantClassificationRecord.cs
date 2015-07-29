namespace EnjoyEatCore.Models
{
    public class RestaurantClassificationRecord
    {
        /// <summary>
        /// 餐廳分類紀錄編號
        /// </summary>
        public string RestaurantClassificationRecord_ID { get; set; }

        /// <summary>
        /// 餐廳分類紀錄時間
        /// </summary>
        public string RestaurantClassificationRecord_Datetime { get; set; }

        /// <summary>
        /// 餐廳編號
        /// </summary>
        public string Restaurant_ID { get; set; }

        /// <summary>
        /// 餐廳分類編號
        /// </summary>
        public string RestaurantClassification_ID { get; set; }
    }
}