using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.Data;
using Supermarket_mvp.Models;
using System.Data;

namespace Supermarket_mvp._Repositories
{
    internal class DetailRepository : BaseRepository, IDetailRepository
    {
        public CategorieRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public void Add(DetailModel detail)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(DetailModel detail)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DetailModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DetailModel> GetByValue(string value)
        {
            throw new NotImplementedException();
        }
    }
}
