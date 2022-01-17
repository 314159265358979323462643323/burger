using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WilliamToddSite.Models;

namespace QuizTests
{
    public interface ITestRepository
    {
        IEnumerable<ForumModel> SelectAll();
        ForumModel SelectByID(int id);
        void Insert(ForumModel obj);
        void Update(ForumModel obj);
        void Delete(int id);
    }
}
