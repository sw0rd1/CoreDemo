using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class BlogRepository : IBlogDAL
    {
        Context c = new Context();


        public void Delete(Blog t)
        {
            c.Remove(t);
            c.SaveChanges();
        }

        public Blog GetId(int id)
        {
            return c.Blogs.Find(id);

        }

        public List<Blog> GetListAll()
        {
            return c.Blogs.ToList();
        }

        public void Insert(Blog t)
        {
            c.Add(t);
            c.SaveChanges();
        }

        public void Update(Blog t)
        {
            c.Update(t);
            c.SaveChanges();
        }

    }
}
