using Repository_Patern.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository_Patern.DataAccess.Abstract
{
    interface IRepository<TEntity>
    {
        TEntity GetById(int dal);

        void Update(TEntity entity);

        void Creat(TEntity entity);

        void Delete(int id);

    }
}
