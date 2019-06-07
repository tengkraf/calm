using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Repositories;
using DAL.Interfaces;
using DAL.Models;

namespace DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        readonly ApplicationDbContext _context;

        
        IRepository<T> _T;
       
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }
       
        public IRepository<T> Ts
        {
            get
            {
                if (_T == null)
                    _T = new Repository<T>(_context);

                return _T;
            }
        }

    

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }
       
    }
}
