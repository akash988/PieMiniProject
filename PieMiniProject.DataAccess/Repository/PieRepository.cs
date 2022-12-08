using PieMiniProject.DataAccess.Data;
using PieMiniProject.DataAccess.Repository.IRepository;
using PieMiniProject.ModelAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PieMiniProject.DataAccess.Repository
{
    public class PieRepository: Repository<Pie>, IPieRepository
    {
        private readonly PieDbContext _db;
        public PieRepository(PieDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Pie obj)
        {
            _db.Update(obj);
        }
    }
}
