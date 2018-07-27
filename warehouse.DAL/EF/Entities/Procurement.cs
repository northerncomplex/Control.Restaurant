using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using warehouse.DAL.EF.AllegedAbstractions.Entities;

namespace warehouse.DAL.Entities
{
    [Table("Procurement")]
    public class Procurement : DbEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        new Guid Id { get; set; }
        public string NameSeller { get; set; }
        public string ContactSeller { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
    }
}
