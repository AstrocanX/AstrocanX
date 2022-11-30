using ProjectLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectLayer.DataAccess
{
    public interface IEntityRepository<T> where T :EntitySign,new()
    {

        public List<T> getEmpI();
        public List<T> getByEmpId();
        public void AddEmpI(T entity);

        public void Update(T entity);

        public void Delete(T entity);




    }
}
