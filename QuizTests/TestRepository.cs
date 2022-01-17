using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WilliamToddSite.Models;

namespace QuizTests
{
    public class TestRepository : IForumRepository
    {
        private List<ForumModel> data = new List<ForumModel>();

        IEnumerable<ForumModel> IForumRepository.SelectAll()
        {
            return data;
        }

        public ForumModel SelectByID(int id)
        {
            var comment = data.Find(c => c.CommentId == id);
            return comment;
        }

        public void Insert(ForumModel obj)
        {
            obj.CommentId = data.Count;
            data.Add(obj);
        }

        public void Update(ForumModel obj)
        {
            ForumModel existing = data.FirstOrDefault();
            existing = obj;
        }

        public void Delete(int id)
        {
            data.RemoveAt(id);
            
        }
    }
}
