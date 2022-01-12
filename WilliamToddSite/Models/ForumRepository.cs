using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WilliamToddSite.Models
{
    public class ForumRepository : IForumRepository
    {
        private ForumContext db;
/*
        public ForumRepository()
        {
            this.db = new ForumContext();
        }
*/
        public ForumRepository(ForumContext db)
        {
            this.db = db;
        }
        public IEnumerable<ForumModel> SelectAll()
        {
            return db.Forum.ToList();
        }

        public ForumModel SelectByID(int id)
        {
            return db.Forum.Find(id);
        }

        public void Delete(int id)
        {
            ForumModel existing = db.Forum.Find(id);
            db.Forum.Remove(existing);
            db.SaveChanges();
        }

        public void Insert(ForumModel obj)
        {
            db.Forum.Add(obj);
            db.SaveChanges();
        }
        public void Update(ForumModel obj)
        {
            db.Entry(obj).State = EntityState.Modified;
            db.SaveChanges();
        }
        /*
        public void Save()
        {
            db.SaveChanges();
        }

        */

        
    }
}
