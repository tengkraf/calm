
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;
using DAL.Interfaces;

namespace DAL
{
    public interface IUnitOfWork
    {
        IRepository<T> T { get; }

    }

}