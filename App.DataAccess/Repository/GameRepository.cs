using App.DataAccess.Data;
using App.DataAccess.Repository.IRepository;
using App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace App.DataAccess.Repository
{
    public class GameRepository : Repository<Game>, IGameRepository
    {
        private ApplicationDbContext _db;
        public GameRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Game obj)
        {
            _db.Games.Update(obj);
        }
    }
}
