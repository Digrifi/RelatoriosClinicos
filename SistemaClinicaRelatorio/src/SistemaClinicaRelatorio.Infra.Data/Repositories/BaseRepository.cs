using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaClinicaRelatorio.Infra.Data.Repositories
{
    public class BaseRepository<T>
    {

        public IQueryable<T> FindAll()
        {
            return this._context.Set<T>();
        }
    }
}
