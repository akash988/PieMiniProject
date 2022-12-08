using PieMiniProject.ModelAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PieMiniProject.DataAccess.Repository.IRepository
{
    public interface IPieRepository:IRepository<Pie>
    {
        void Update(Pie obj);
    }
}
