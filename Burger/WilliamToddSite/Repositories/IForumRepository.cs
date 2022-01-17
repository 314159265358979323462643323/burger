using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WilliamToddSite.Models
{
    public interface IForumRepository
    {
        IEnumerable<ForumModel> SelectAll();
        ForumModel SelectByID(int id);
        void Insert(ForumModel obj);
        void Update(ForumModel obj);
        void Delete(int id);
      
    }
}
