using DataAccessLayer;
using DataAccessLayer.Concrete;
using EntityLayer;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BooksManager
    {
        Repository<Category> categoryRepo = new Repository<Category>();
        public int CategoryAdd(Category p)
        {
            
            return categoryRepo.Insert(p);
        }
        public int CategoryDell(int p)
        {
            if (p != 0)
            {
                Category b = categoryRepo.Find(x => x.CategoryId == p);
                return categoryRepo.Delete(b);
            }
            else
            {
                return -1;
            }
        }
        public int CategoryUpdate(Category p)
        {
            if (p.CategoryName == "" || p.CategoryName.Length <= 3)
            {
                return -1;
            }
            Category category = categoryRepo.Find(x => x.CategoryId == p.CategoryId);
            category.CategoryName = p.CategoryName;

            return categoryRepo.Update(category);
        }
        public List<Category> GetAll()
        {
            return categoryRepo.List();
        }


    }
}