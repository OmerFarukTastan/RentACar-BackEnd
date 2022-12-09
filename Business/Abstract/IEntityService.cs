using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;

namespace Business.Abstract
{
    public interface IEntityService<T> where T : class, IEntity, new()
    {
        void Add(T entity);
    }
}
