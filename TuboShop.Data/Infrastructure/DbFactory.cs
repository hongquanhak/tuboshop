namespace TuboShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private TuboShopDbContext dbContext;

        public TuboShopDbContext Init()
        {
            return dbContext ?? (dbContext = new TuboShopDbContext()); //neu null thi new, khoi tao mot doi tuong cho DbContext
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)  //neu khac null thi dispose
                dbContext.Dispose();
        }
    }
}