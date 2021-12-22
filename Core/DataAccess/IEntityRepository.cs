using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    //generic constraint(Tyi sinirlandirma)
    //class:referans tip(olabilir demek)
    //IEntity: IEntity olabilir ya da IEntity implemente eden bir nesne olabilir
    //new(): newlenebilir olmali(IEntity newlenemez cunku interfacetir)
    public interface IEntityRepository<T> where T:class,IEntity, new() //generic repository pattern, T:type
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);  //expression:bizim filtreler yazabilmemizi sagliyor(predicate),delege
        T Get(Expression<Func<T, bool>> filter);                   //refactoring
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    } 
}
