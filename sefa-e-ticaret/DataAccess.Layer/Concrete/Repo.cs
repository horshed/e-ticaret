using DataAccessLayer.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Repository<etic> : IRepo<etic> where etic : class
    {
        Context c = new Context();
        DbSet<etic> _object;
        public Repository()
        {
            _object = c.Set<etic>();
        }
        public int Delete(etic p)
        {
            _object.Remove(p);
            return c.SaveChanges();
        }

        public List<etic> List()
        {
            return _object.ToList();
        }

        public etic GetById(int id)
        {
            return _object.Find(id);
        }

        public int Insert(etic p)
        {
            _object.Add(p);
            return c.SaveChanges();
        }

        public int Update(etic p)
        {
            return c.SaveChanges();
        }

        public T Find(Expression<Func<etic, bool>> where)
        {
            return _object.FirstOrDefault(where);
        }

        public List<etic> List(Expression<Func<etic, bool>> where)
        {
            return _object.Where(where).ToList();
        }

        etic IRepo<etic>.Find(Expression<Func<etic, bool>> where)
        {
            throw new NotImplementedException();
        }
    }
    }
