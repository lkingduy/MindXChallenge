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
        public DateTime Time { get; set; }
        public string UserId { get; set; }
        public BlogData()
        {

        }
    }
}
