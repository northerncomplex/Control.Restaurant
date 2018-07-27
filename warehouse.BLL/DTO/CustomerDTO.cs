using warehouse.BLL.DTO.AllegedAbstraction.Entities;

namespace warehouse.DAL.Entities
{
    public class CustomerDTO : DTOItem
    {
        public string Name { get; set; }
        public string Contact { get; set; }
        public Order InfOrder { get; set; }
    }
}
