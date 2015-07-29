namespace EnjoyEatCore.Models
{
    public class MemberFeedbackForm
    {
        /// <summary>
        /// 會員意見回饋表編號
        /// </summary>
        public string MemberFeedbackForm_ID { get; set; }

        /// <summary>
        /// 填寫日期時間
        /// </summary>
        public string MemberFeedbackForm_Datetime { get; set; }

        /// <summary>
        /// 點餐單編號
        /// </summary>
        public string Order_ID { get; set; }
    }
}