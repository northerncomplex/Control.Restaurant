using System;
using System.Collections.Generic;

namespace warehouse.BLL.Interfaces
{
    interface IDTOInterface<T>
    {
        bool AddItem(T DTOItem);
        bool AddItems(IEnumerable<T> DTOitems);
        bool ChangeItem(T DTOitem);
        bool DeleteItem(Guid id);
        T GetItem(Guid id);
        bool SaveChanges();
    }
}
