namespace EnjoyEatCore.Models
{
    public class MealClassification
    {
        /// <summary>
        /// 餐點分類編號
        /// </summary>
        public string MealClassification_ID { get; set; }

        /// <summary>
        /// 中文名稱
        /// </summary>
        public string MealClassification_Name { get; set; }

        /// <summary>
        /// 英文名稱
        /// </summary>
        public string MealClassification_EName { get; set; }
    }
}