﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4.Models
{
    public class Movie
    {

        [Key]
        [Required]
        public int MovieID { get; set; }

        

        [Required]
        public string title { get; set; }

        [Required]
        public int year { get; set; }

        [Required]
        public string director { get; set; }

        [Required]
        public string rating { get; set; }

        public bool edited { get; set; }
        public string lentTo { get; set; }
        [MaxLength(25)]
        public string notes { get; set; }

        [Required]
        public int categoryID { get; set; }
        public Categories category { get; set; }
    }
}
