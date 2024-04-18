using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Models
{
    internal interface IDetailRepository
    {
        void Add(DetailModel detail);
        void Edit(DetailModel detail);
        void Delete(int id);
        IEnumerable<DetailModel> GetAll();
        IEnumerable<DetailModel> GetByValue(string value);
    }
}
