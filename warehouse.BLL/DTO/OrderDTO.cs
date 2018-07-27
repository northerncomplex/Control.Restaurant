using System.Collections.Generic;
using warehouse.BLL.DTO.AllegedAbstraction.Entities;

namespace warehouse.DAL.Entities
{
    public class OrderDTO : DTOItem
    {
        public virtual List<Stock> Product { get; set; }
    }
}
