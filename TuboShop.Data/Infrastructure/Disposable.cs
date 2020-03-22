using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuboShop.Data.Infrastructure
{
    public class Disposable : IDisposable //cai dat cac phuong thuc de tu dong huy 
    {
        private bool isDisposed;

        ~Disposable()
        {
            Dispose(false);
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        private void Dispose(bool disposing)
        {
            if(!isDisposed && disposing)
            {
                DisposeCore();
            }
            isDisposed = true;
        }

        //Override this to dispose custom object
        protected virtual void DisposeCore()
        {

        }
    }
}
