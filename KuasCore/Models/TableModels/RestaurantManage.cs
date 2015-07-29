namespace EnjoyEatCore.Models
{
    public class RestaurantManage
    {
        /// <summary>
        /// 餐廳管理編號
        /// </summary>
        public string RestaurantManage_ID { get; set; }

        /// <summary>
        /// 餐廳管理人姓名
        /// </summary>
        public string RestaurantManage_Name { get; set; }

        /// <summary>
        /// 餐廳管理帳號
        /// </summary>
        public string RestaurantManage_Username { get; set; }

        /// <summary>
        /// 餐廳管理密碼
        /// </summary>
        public string RestaurantManage_Password { get; set; }

        /// <summary>
        /// 管理權限
        /// </summary>
        public string RestaurantManage_Level { get; set; }

        /// <summary>
        /// 餐廳編號
        /// </summary>
        public string Restaurant_ID { get; set; }
    }
}