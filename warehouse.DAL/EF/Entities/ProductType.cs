using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using warehouse.DAL.EF.AllegedAbstractions.Entities;

namespace warehouse.DAL.Entities
{
    [Table("Type of Product")]
    public class ProductType : DbEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        new Guid Id { get; set; }
        public string TypeName { get; set; }
        public string Description { get; set; }

        public List<Stock> Product { get; set; }
    }
}
