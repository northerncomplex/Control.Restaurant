using System;
using System.Collections.Generic;
using warehouse.BLL.DTO.AllegedAbstraction.Entities;
using warehouse.BLL.Interfaces;

namespace warehouse.BLL.Services.FDTO
{
    public abstract class DTOService<T> : IDTOInterface<T>
        where T : class, IDTOItem
    {
        public abstract bool AddItem(T DTOItem);
        public abstract bool AddItems(IEnumerable<T> DTOItems);
        public abstract bool ChangeItem(T DTOItem);
        public abstract bool DeleteItem(Guid Id);
        public abstract T GetItem(Guid Id);
        public abstract bool SaveChanges();
    }
}
