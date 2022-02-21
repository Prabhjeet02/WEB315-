using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesComputer.Models
{
    public class Computer
    {
        public int ID { get; set; }
        public string Company { get; set; }

        [Display(Name = "Launch Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Processor { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
    }
}