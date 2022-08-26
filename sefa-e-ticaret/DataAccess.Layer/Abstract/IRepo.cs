using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepo<etic>
    {
        int Insert(etic p);
        int Update(etic p);
        int Delete(etic p);
        List<etic> List();
        etic GetById(int id);

        etic Find(Expression<Func<etic, bool>> where);
        List<etic> List(Expression<Func<etic, bool>> where);
    }
}
