using warehouse.BLL.DTO.AllegedAbstraction.Entities;

namespace warehouse.DAL.Entities
{
    public class ProcurementDTO : DTOItem
    {
        public string NameSeller { get; set; }
        public string ContactSeller { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
    }
}
