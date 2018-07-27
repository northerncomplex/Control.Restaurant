using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using warehouse.DAL.EF.AllegedAbstractions.Entities;

namespace warehouse.DAL.Entities
{
    [Table("Stock")]
    public class Stock : DbEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        new public Guid Id { get; set; }
        public List<Procurement> Product { get; set; }
        public ProductType Class { get; set; }
    }
}
