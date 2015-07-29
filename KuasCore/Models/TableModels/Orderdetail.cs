namespace EnjoyEatCore.Models
{
    public class Orderdetail
    {
        /// <summary>
        /// 點餐明細編號
        /// </summary>
        public string Orderdetail_ID { get; set; }

        /// <summary>
        /// 餐點數量
        /// </summary>
        public string Orderdetail_Quantity { get; set; }

        /// <summary>
        /// 其他餐點需求
        /// </summary>
        public string Orderdetail_Other { get; set; }

        /// <summary>
        /// 點餐單編號
        /// </summary>
        public string Order_ID { get; set; }

        /// <summary>
        /// 餐點編號
        /// </summary>
        public string Meal_ID { get; set; }
    }
}