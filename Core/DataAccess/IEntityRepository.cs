
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //<T> generics
    //generic constraint
    //class: referans tip
    //IEntity: IEntity olabilir veya IEntity implemente eden bir nesne olabilir.
    //new(): newlenebilir olmalı..
    public interface IEntityRepository<T> where T:class,IEntity,new() //sınır koyuldu.. 
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null); //Tüm Listede Filtreleme için
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

        
    }
}
