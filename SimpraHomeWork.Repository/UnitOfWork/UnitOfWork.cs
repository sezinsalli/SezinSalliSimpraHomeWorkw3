﻿using Microsoft.EntityFrameworkCore;
using SimpraHomeWork.Core.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpraHomeWork.Repository.UnitOfWork
{
    public class UnitOfWork : IUnitofWork
    {
        private bool disposed;
        private readonly AppDbContext _context;
        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }
        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }

        public async Task CompleteWithTransactionAsync()
        {
            await using (var dbDcontextTransaction = await _context.Database.BeginTransactionAsync())
            {
                try
                {
                    await _context.SaveChangesAsync();
                    await dbDcontextTransaction.CommitAsync();
                }
                catch (Exception ex)
                {
                    // logging
                    await dbDcontextTransaction.RollbackAsync();
                }
            }
        }

        private void Clean(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }

            disposed = true;
            GC.SuppressFinalize(this);
        }

        public void Dispose()
        {
            Clean(true);
        }
    }
}
