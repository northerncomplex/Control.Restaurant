using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using warehouse.DAL.EF.AllegedAbstractions.Entities;

namespace warehouse.DAL.Entities
{
    [Table("Customer")]
    public class Customer : DbEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        new public Guid Id { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
        public Order InfOrder { get; set; }
    }
}
