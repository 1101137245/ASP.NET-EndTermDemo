namespace EnjoyEatCore.Models
{
    public class RestaurantPicture
    {
        /// <summary>
        /// 餐廳圖片編號
        /// </summary>
        public string RestaurantPicture_ID { get; set; }

        /// <summary>
        /// 餐廳圖片位址
        /// </summary>
        public string RestaurantPicture_Url { get; set; }

        /// <summary>
        /// 餐廳編號
        /// </summary>
        public string Restaurant_ID { get; set; }
    }
}