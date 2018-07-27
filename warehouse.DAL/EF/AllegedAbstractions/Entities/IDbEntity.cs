using System;
using System.ComponentModel.DataAnnotations;

namespace warehouse.DAL.EF.AllegedAbstractions.Entities
{
    public interface IDbEntity
    {
        [Key]
        Guid Id { get; set; }
    }
}
