using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class CommentRepository : IGenericDAL<Comment>
    {
        Context c = new Context();
        public void Delete(Comment t)
        {
            c.Remove(t);
            c.SaveChanges();
        
        }
        public Comment GetId(int id)
        {
            return c.Comments.Find(id);
        }

        public List<Comment> GetListAll()
        {
            return c.Comments.ToList();
        }

        public void Insert(Comment t)
        {
            c.Add(t);
            c.SaveChanges();
        }

        public void Update(Comment t)
        {
            c.Comments.Update(t);
            c.SaveChanges();
        }
    }
}
