using System;
using System.Runtime.Serialization;

namespace BoooooJu.Service.DPModels
{ 
    [DataContract]
    public partial class Article
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Content { get; set; }

        [DataMember]
        public DateTime PublishTime { get; set; }

        [DataMember]
        public string ReferUrl { get; set; }

        [DataMember]
        public string ReferName { get; set; }

        [DataMember]
        public int LikeCount { get; set; }

        [DataMember]
        public int LookCount { get; set; }

        [DataMember]
        public int DisLikeCount { get; set; }

        [DataMember]
        public string KeyWords { get; set; }

        [DataMember]
        public int UserId { get; set; }
    }
}
