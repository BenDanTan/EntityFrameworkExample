using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkExample.Models
{
    public class Barrel
    {
        [Key]
        public int Id { get; set; }
        public double radius { get; set; }
    }
}