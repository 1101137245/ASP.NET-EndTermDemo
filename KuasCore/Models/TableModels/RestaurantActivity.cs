using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnjoyEatCore.Models
{
    public class RestaurantActivity
    {
        /// <summary>
        /// 餐廳活動
        /// </summary>
        public string RestaurantActivity_ID { get; set; }

        /// <summary>
        /// 餐廳活動標題
        /// </summary>
        public string RestaurantActivity_Title { get; set; }

        /// <summary>
        /// 餐廳活動內容
        /// </summary>
        public string RestaurantActivity_Content { get; set; }

        /// <summary>
        /// 餐廳活動圖片
        /// </summary>
        public string RestaurantActivity_Picture { get; set; }

        /// <summary>
        /// 餐廳活動開始時間
        /// </summary>
        public string RestaurantActivity_Startdatetime { get; set; }

        /// <summary>
        /// 餐廳活動結束時間
        /// </summary>
        public string RestaurantActivity_Enddatetime { get; set; }

        /// <summary>
        /// 餐廳活動其他
        /// </summary>
        public string RestaurantActivity_Other { get; set; }

        /// <summary>
        /// 餐廳活動發布日期
        /// </summary>
        public string RestaurantActivity_Datetime { get; set; }

        /// <summary>
        /// 公司編號
        /// </summary>
        public string Company_ID { get; set; }
    }
}