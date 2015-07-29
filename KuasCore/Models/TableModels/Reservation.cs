namespace EnjoyEatCore.Models
{
    public class Reservation
    {
        /// <summary>
        /// 訂位單
        /// </summary>
        public string Reservation_ID { get; set; }

        /// <summary>
        /// 訂位時間
        /// </summary>
        public string Reservation_Reservedatetime { get; set; }

        /// <summary>
        /// 訂位人數
        /// </summary>
        public string Reservation_Peoplenumber { get; set; }

        /// <summary>
        /// 用餐目的
        /// </summary>
        public string Reservation_Purpose { get; set; }

        /// <summary>
        /// 其他需求
        /// </summary>
        public string Reservation_Otherrequirement { get; set; }

        /// <summary>
        /// 邀請碼
        /// </summary>
        public string Reservation_Invitationcode { get; set; }

        /// <summary>
        /// 訂位單完成時間
        /// </summary>
        public string Reservation_Datetime { get; set; }

        /// <summary>
        /// 餐廳編號
        /// </summary>
        public string Restaurant_ID { get; set; }

        /// <summary>
        /// 訂位人編號
        /// </summary>
        public string Member_ID { get; set; }
    }
}