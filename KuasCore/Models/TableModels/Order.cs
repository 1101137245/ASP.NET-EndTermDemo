namespace EnjoyEatCore.Models
{
    public class Order
    {
        /// <summary>
        /// 點餐單編號
        /// </summary>
        public string Order_ID { get; set; }

        /// <summary>
        /// 付款方式
        /// </summary>
        public string Order_Paymentmethod { get; set; }

        /// <summary>
        /// 其他需求
        /// </summary>
        public string Order_Other { get; set; }

        /// <summary>
        /// 提早送餐需求
        /// </summary>
        public string Order_Earlyserving { get; set; }

        /// <summary>
        /// 提早送餐時間
        /// </summary>
        public string Order_Earlyservingtime { get; set; }

        /// <summary>
        /// 點餐單完成時間
        /// </summary>
        public string Order_Datetime { get; set; }

        /// <summary>
        /// 會員編號
        /// </summary>
        public string Member_ID { get; set; }

        /// <summary>
        /// 訂位單編號
        /// </summary>
        public string Reservation_ID { get; set; }
    }
}