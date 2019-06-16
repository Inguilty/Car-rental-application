using System.Diagnostics;

namespace AspNetIdentity.Data.Core
{
    public static class ContextUtil
    {
        public static CarRentalDbEntities Context
        {
            get
            {
                var context = new CarRentalDbEntities();
                context.Configuration.LazyLoadingEnabled = false;
                context.Database.Log = msg => Trace.TraceInformation(msg);
                return context;
            }
        }
    }
}
