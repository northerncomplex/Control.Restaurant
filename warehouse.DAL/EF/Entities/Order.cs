using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using warehouse.DAL.EF.AllegedAbstractions.Entities;

namespace warehouse.DAL.Entities
{
    [Table("Orders")]
    public class Order : DbEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        new public Guid Id { get; set; }
        public virtual List<Stock> Product { get; set; }
    }
}
