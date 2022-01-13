using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WilliamToddSite.Models;

namespace QuizTests
{
    public class TestRepository<T> : ITestRepository<T> where T:class
    {
        private List<T> data = new List<T>();

        public IEnumerable<T> SelectAll()
        {
            return data;
        }
        public T SelectByID(object id)
        {
            return data.FirstOrDefault();     
        }
        public void Insert(T obj)
        {
            data.Add(obj);
        }
        public void Update(T obj)
        {
            T existing = data.FirstOrDefault();
            existing = obj;
        }
        public void Delete(object id)
        {
            data.RemoveAt(0);
        }
        public void Save()
        {
         
        }

        

        

        
    }
}
