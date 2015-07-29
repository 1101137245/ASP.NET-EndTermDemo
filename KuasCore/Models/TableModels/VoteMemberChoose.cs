namespace EnjoyEatCore.Models
{
    public class VoteMemberChoose
    {
        /// <summary>
        /// 投票會員選擇編號
        /// </summary>
        public string VoteMemberChoose_ID { get; set; }

        /// <summary>
        /// 會員編號
        /// </summary>
        public string Member_ID { get; set; }

        /// <summary>
        /// 投票編號
        /// </summary>
        public string Vote_ID { get; set; }

        /// <summary>
        /// 投票選項編號
        /// </summary>
        public string VoteOption_ID { get; set; }
    }
}