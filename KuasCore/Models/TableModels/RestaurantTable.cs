namespace EnjoyEatCore.Models
{
    public class RestaurantTable
    {
        /// <summary>
        /// 桌位編號
        /// </summary>
        public string RestaurantTable_ID { get; set; }

        /// <summary>
        /// 桌位名稱
        /// </summary>
        public string RestaurantTable_Name { get; set; }

        /// <summary>
        /// 人數
        /// </summary>
        public string RestaurantTable_People { get; set; }

        /// <summary>
        /// 靠窗與否
        /// </summary>
        public string RestaurantTable_Window { get; set; }

        /// <summary>
        /// 餐廳編號
        /// </summary>
        public string Restaurant_ID { get; set; }
    }
}