using System.Collections.Generic;
using warehouse.BLL.DTO.AllegedAbstraction.Entities;

namespace warehouse.DAL.Entities
{
    public class ProductTypeDTO : DTOItem
    {
        public string TypeName { get; set; }
        public string Description { get; set; }

        public List<Stock> Product { get; set; }
    }
}
