using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MindXChallenge.Data.Models
{
    public class BlogData
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Contents { get; set; }
        public DateTime Time { get; set; } = DateTime.Now;
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string TimeString { get; set; }
        public BlogData()
        {

        }
    }
}
