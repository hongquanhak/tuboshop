using System;

namespace TuboShop.Data.Infrastructure
{
    //mot giao tiep de khoi tao cac doi tuong entity
    public interface IDbFactory : IDisposable
    {
        TuboShopDbContext Init(); //can 1 phuong thuc de Init DbContext
    }
}