using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HawkTest.Models
{
    public class Contact
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Last { get; set; }
        public List<ContactDetail> Detail { get; set; }
        
        public string FullName
        {
            get { return Name + " " + Last; }
        }


    }
}