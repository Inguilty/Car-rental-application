using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AspNetIdentity.Data.Core;

namespace AspNetIdentity.Logic.Core.Repositories
{
    /// <summary>
    /// Abstract base class for all repositories.
    /// </summary>
    public abstract class BaseRepository : IDisposable
    {
        #region member vars

        private readonly Lazy<CarRentalDbEntities> _dbContextFactory = new Lazy<CarRentalDbEntities>(() => ContextUtil.Context);

        private bool _disposed;

        #endregion

        #region explicit interfaces

        /// <inheritdoc />
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion

        #region methods

        /// <summary>
        /// Releases the unmanaged resources that are used by the object and, optionally, releases the managed resources.
        /// </summary>
        /// <param name="disposing">
        /// true to release both managed and unmanaged resources; false to release only unmanaged
        /// resources.
        /// </param>
        protected virtual void Dispose(bool disposing)
        {
            if (_disposed || !disposing)
            {
                return;
            }
            if (_dbContextFactory.IsValueCreated)
            {
                _dbContextFactory.Value.Dispose();
            }
            _disposed = true;
        }

        /// <summary>
        /// Central exception handler for all repositories.
        /// </summary>
        /// <param name="ex"></param>
        protected virtual void HandleException(Exception ex)
        {
            Trace.TraceError(ex.Message);
        }

        ~BaseRepository()
        {
            Dispose(false);
        }

        #endregion

        #region properties

        /// <summary>
        /// The entity context.
        /// </summary>
        protected CarRentalDbEntities DbContext => _dbContextFactory.Value;

        #endregion
    }
}
