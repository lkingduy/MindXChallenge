// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace MindXChallenge.Data
{
    public partial class Comment
    {
        public int Id { get; set; }
        public int? BlogId { get; set; }
        public string UserId { get; set; }
        public string Contents { get; set; }
        public string UpdYmd { get; set; }
        public string UpdHms { get; set; }

        public virtual Blog Blog { get; set; }
    }
}