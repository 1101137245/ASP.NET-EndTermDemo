namespace EnjoyEatCore.Models
{
    public class CommentLike
    {
        /// <summary>
        /// 評論按讚編號
        /// </summary>
        public string CommentLike_ID { get; set; }

        /// <summary>
        /// 評論編號
        /// </summary>
        public string Comment_ID { get; set; }

        /// <summary>
        /// 會員編號
        /// </summary>
        public string Member_ID { get; set; }
    }
}