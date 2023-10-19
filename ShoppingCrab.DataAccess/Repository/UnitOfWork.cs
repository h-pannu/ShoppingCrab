﻿using ShoppingCrab.DataAccess.Data;
using ShoppingCrab.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCrab.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public ICategoryRepository CategoryRepository {  get; private set; }

        public UnitOfWork(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
            CategoryRepository = new CategoryRepository(_context);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
