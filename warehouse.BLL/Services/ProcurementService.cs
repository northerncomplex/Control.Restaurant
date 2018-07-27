using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using warehouse.BLL.Services.FDTO;
using warehouse.DAL.Entities;

namespace warehouse.BLL.Services
{
    class ProcurementService : DTOService<ProcurementDTO>
    {
        private Procurement ToEntity(ProcurementDTO DTO)
        {
            var DTOValue = new Procurement() {
                NameSeller = DTO.NameSeller,
                ContactSeller = DTO.ContactSeller,
                ProductName = DTO.ProductName,
                ProductPrice = DTO.ProductPrice,
            };
            return DTOValue;
        }

        public override bool AddItem(ProcurementDTO DTOItem)
        {
            var item = ToEntity(DTOItem);
            return ;
        }

        public override bool AddItems(IEnumerable<ProcurementDTO> DTOItems)
        {
            throw new NotImplementedException();
        }

        public override bool ChangeItem(ProcurementDTO DTOItem)
        {
            throw new NotImplementedException();
        }

        public override bool DeleteItem(Guid Id)
        {
            throw new NotImplementedException();
        }

        public override ProcurementDTO GetItem(Guid Id)
        {
            throw new NotImplementedException();
        }

        public override bool SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
