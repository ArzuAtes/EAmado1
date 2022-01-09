using Eamado.DAL.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EAmado.BL.Repositories
{
    public class SqlRepo<T> where T : class
    {

        SqlContext db;
        public SqlRepo(SqlContext _db)
        {
            db = _db;
        }
        public IQueryable<T> GetAll()
        {
            return db.Set<T>();
        }
        public IQueryable<T> GetAll(Expression<Func<T, Boolean>> expr)//  IQueryable sorgulanabilir olma durumunu içeririr.
        {
            return db.Set<T>().Where(expr);
        }
    }
}
