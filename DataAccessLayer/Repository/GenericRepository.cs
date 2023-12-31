﻿using System;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;

namespace DataAccessLayer.Repository
{
	public class GenericRepository<T> : IGenericDal<T> where T : class
	{
		public GenericRepository()
		{
		}

        public void Delete(T t)
        {
            using var c = new Context();
            c.Remove(t);
            c.SaveChanges();
        }

        public List<T> GetList()
        {
            using var c = new Context();
            return c.Set<T>().ToList();
        }

        public void Insert(T t)
        {
            using var c = new Context();
            c.Add(t);
        }

        public void Update(T t)
        {
            using var c = new Context();
            c.Update(t);
        }
    }
}