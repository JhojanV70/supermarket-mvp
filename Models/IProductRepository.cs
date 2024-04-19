using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Models
{
    internal interface IProductRepository
    {
        void Add(ProductModel productModel);
        void Edit(DetailModel productModel);
        void Delete(int id);
        IEnumerable<DetailModel> GetAll();
        IEnumerable<DetailModel> GetByValue(string value);
    }
}
