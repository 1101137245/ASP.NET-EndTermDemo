namespace EnjoyEatCore.Models
{
    public class RestaurantClassification
    {
        /// <summary>
        /// 餐廳分類編號
        /// </summary>
        public string RestaurantClassification_ID { get; set; }

        /// <summary>
        /// 餐廳分類中文名稱
        /// </summary>
        public string RestaurantClassification_Name { get; set; }

        /// <summary>
        /// 餐廳分類英文名稱
        /// </summary>
        public string RestaurantClassification_EName { get; set; }
    }
}