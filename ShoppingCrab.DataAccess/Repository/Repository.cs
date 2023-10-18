﻿using Microsoft.EntityFrameworkCore;
using ShoppingCrab.DataAccess.Data;
using ShoppingCrab.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;


namespace ShoppingCrab.DataAccess.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;
        internal DbSet<T> table;
        public Repository(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
            this.table = _context.Set<T>();
        }
        public void Add(T entity)
        {
            table.Add(entity);

            //_context.Add<T>(entity);
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            IQueryable<T> query = table;
            query = query.Where(filter);
            return query.FirstOrDefault();

            //return _context.Find<T>(filter);
        }

        public IEnumerable<T> GetAll()
        {
            IQueryable<T> query = table;
            return query.ToList();

            //return _context..ToList();
        }

        public void Remove(T entity)
        {
            table.Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            table.RemoveRange(entities);
        }
    }
}
