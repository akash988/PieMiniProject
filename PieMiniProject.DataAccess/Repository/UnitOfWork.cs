using PieMiniProject.DataAccess.Data;
using PieMiniProject.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PieMiniProject.DataAccess.Repository
{
    public class UnitOfWork:IUnitOfWork
    {
        private readonly PieDbContext _db;
        public UnitOfWork(PieDbContext db)
        {
            _db = db;
            Product = new PieRepository(db);
        }

        //public IPieRepository Pie { get; private set; }

        public IPieRepository Product { get; private set; }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
