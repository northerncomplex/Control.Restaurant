using warehouse.DAL.EF.AllegedAbstractions.Repositories;
using warehouse.DAL.Entities;

namespace warehouse.DAL.Interfaces
{
    public interface IProcurement : IUnitOfWork<Procurement>
    {
    }

    public interface IProductType : IUnitOfWork<ProductType>
    {
    }

    public interface IStock : IUnitOfWork<Stock>
    {
    }

    public interface IOrder : IUnitOfWork<Order>
    {
    }

    public interface ICustomer : IUnitOfWork<Customer>
    {
    }
}
