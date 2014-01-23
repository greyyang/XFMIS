using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISLogic.Interface
{
    public interface ICommonLogic<T, IdT>
    {
        IdT Create(T entity);

        int Update(T entity);

        int Delete(IdT entityId);

        T FindByID(IdT entityid);

        IList<T> FindAll();

        IList<T> FindAll(Hashtable table);

        int FindCount(Hashtable table);
    }
}
