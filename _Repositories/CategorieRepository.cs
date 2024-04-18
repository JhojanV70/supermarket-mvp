using Supermarket_mvp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp._Repositories
{
    internal class CategorieRepository : BaseRepository, ICategorieRepository
    {
        public void Add(CategorieModel categorieModel)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(CategorieModel categorieModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CategorieModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CategorieModel> GetByValue(string value)
        {
            throw new NotImplementedException();
        }
    }
}
