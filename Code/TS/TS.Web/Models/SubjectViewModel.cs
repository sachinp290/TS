using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TS.Web.Models
{
    public class SubjectViewModel
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
    }
}