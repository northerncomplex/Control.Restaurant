using System;
using System.Collections.Generic;
using System.Linq;
using warehouse.DAL.EF.AllegedAbstractions.Entities;
using warehouse.DAL.EF.AllegedAbstractions.Repositories;

namespace warehouse.DAL.Repositories
{
    public class EFUnitOfWork<T> : IUnitOfWork<T>
        where T : class, IDbEntity
    {
        private StockDbContext _db;
        public EFUnitOfWork(string connStr)
        {
            _db = new StockDbContext(connStr);
        }

        public IQueryable<T> AllItems
        {
            get
            {
                return _db.Set<T>();
            }
        }

        public bool AddItem(T item)
        {
            _db.Set<T>().Add(item);
            return SaveChanges();
        }

        public bool AddItems(IEnumerable<T> items)
        {
            _db.Set<T>().AddRange(items);
            return SaveChanges();
        }

        public bool ChangeItem(T item)
        {
            T changed = GetItem(item.Id);
            changed = item;
            return SaveChanges();
        }

        public bool DeleteItem(Guid id)
        {
            T item = GetItem(id);
            if (item == null)
                return false;
            _db.Set<T>().Remove(item);
            return true;
        }

        public T GetItem(Guid id)
        {
            return AllItems.FirstOrDefault(x => x.Id.Equals(id));
        }

        public bool SaveChanges()
        {
            try
            {
                _db.SaveChanges();
                return true;
            }
#pragma warning disable 0168
            catch (Exception e)
#pragma warning restore 0168
            {
                return false;
            }
        }
    }
}
