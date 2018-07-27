using System.Collections.Generic;
using warehouse.BLL.DTO.AllegedAbstraction.Entities;

namespace warehouse.DAL.Entities
{
    public class StockDTO : DTOItem
    {
        public List<ProcurementDTO> Product { get; set; }
        public ProductTypeDTO Class { get; set; }
    }
}
