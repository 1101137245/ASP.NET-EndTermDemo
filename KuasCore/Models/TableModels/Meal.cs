namespace EnjoyEatCore.Models
{
    public class Meal
    {
        /// <summary>
        /// 餐點編號
        /// </summary>
        public string Meal_ID { get; set; }

        /// <summary>
        /// 中文名稱
        /// </summary>
        public string Meal_Name { get; set; }

        /// <summary>
        /// 英文名稱
        /// </summary>
        public string Meal_EName { get; set; }

        /// <summary>
        /// 圖片
        /// </summary>
        public string Meal_Picture { get; set; }

        /// <summary>
        /// 詳細說明
        /// </summary>
        public string Meal_Summary { get; set; }

        /// <summary>
        /// 價格
        /// </summary>
        public string Meal_Price { get; set; }

        /// <summary>
        /// 素食與否
        /// </summary>
        public string Meal_Vegetarian { get; set; }

        /// <summary>
        /// 辣度
        /// </summary>
        public string Meal_Spicy { get; set; }

        /// <summary>
        /// 卡路里
        /// </summary>
        public string Meal_Caloric { get; set; }

        /// <summary>
        /// 食譜
        /// </summary>
        public string Meal_Recipe { get; set; }

        /// <summary>
        /// 推薦度
        /// </summary>
        public string Meal_Recommendation { get; set; }

        /// <summary>
        /// 餐點分類編號
        /// </summary>
        public string MealClassification_ID { get; set; }

        /// <summary>
        /// 餐廳編號
        /// </summary>
        public string Restaurant_ID { get; set; }
    }
}