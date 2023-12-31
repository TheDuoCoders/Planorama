﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Food
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(20)]

        public string Name { get; set; }

        [ForeignKey("FoodCategory")]
        public int FoodCategory {  get; set; }

        [Required]
        [StringLength(20)]

        public string Picture { get; set; }

        [Required]
        [StringLength(200)]

        public string Description { get; set; }

        [Required]

        public double Price { get; set; }

        [Required]

        public int TimesSelected { get; set; }


    }
}
