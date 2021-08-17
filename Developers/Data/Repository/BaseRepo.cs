using Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public abstract class BaseRepo<T> where T : Models.BaseModel
    {
        public void Create(T model)
        {
            using (var context = new DevContext())
            {
                context.Set<T>().Add(model);
                context.SaveChanges();
            }
        }
        public List<T> Read()
        {
            List<T> list = new List<T>();
            using (var context = new DevContext())
            {
                list = context.Set<T>().ToList();
            }
            return list;
        }
        public T Read(int id)
        {
            T model = Activator.CreateInstance<T>();
            using (var context = new DevContext())
            {
                model = context.Set<T>().Find(id);
            }
            return model;
        }
        public void Update(T model)
        {
            using (var context = new DevContext())
            {
                context.Entry<T>(model).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void Delete(T model)
        {
            using (var context = new DevContext())
            {
                context.Entry<T>(model).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
