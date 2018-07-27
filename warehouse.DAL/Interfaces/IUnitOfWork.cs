using System;
using System.Collections.Generic;
using System.Linq;
using warehouse.DAL.EF.AllegedAbstractions.Entities;

namespace warehouse.DAL.EF.AllegedAbstractions.Repositories
{
    public interface IUnitOfWork<T>
        where T : class, IDbEntity
    {
        bool AddItem(T item);
        bool AddItems(IEnumerable<T> items);
        IQueryable<T> AllItems { get; }
        bool ChangeItem(T item);
        bool DeleteItem(Guid id);
        T GetItem(Guid id);
        bool SaveChanges();

        //IEnumerable<T> GetAll();
        //T Get(int id);
        //void Create(T item);
        //void Update(T item);
        //void Delete(int id);
    }
}
