﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockManagment.Models
{
    [Table("Brokers")]
    public class Broker
    {

        public int BrokerId { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public ICollection<Person> People { get; set; }

        public ICollection<Order> Orders { get; set; }

        public ICollection<PeopleBrokers> PeopleBrokers { get; set; }

    }
}
