using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HawkTest.Models
{
    public class ContactDetail
    {
        public int Id { get; set; }
        [Required]
        [StringLength(10)]
        public string NumberDetail { get; set; }
        public string Type { get; set; }

    }
}