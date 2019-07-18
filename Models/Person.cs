﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockManagment.Models
{
    [Table("People")]
    public class Person
    {
        [Key]
        public int PersonId { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public ICollection<Order> Orders { get; set; }

        public ICollection<PeopleBrokers> PeopleBrokers { get; set; }

    }
}
