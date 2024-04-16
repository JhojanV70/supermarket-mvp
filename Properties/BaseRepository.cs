using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.sqlClient;
using Microsoft.Data;
using Supermarket_mvp.Models;
using System.Data;

namespace Supermarket_mvp.Properties
{
    internal class BaseRepository : IPayModeRepository
    {
        protected string connectionString;

        void IPayModeRepository.Add(PayModeModel payModeModel)
        {
            throw new NotImplementedException();
        }

        void IPayModeRepository.Delete(int id)
        {
            throw new NotImplementedException();
        }

        void IPayModeRepository.Edit(PayModeModel payModeModel)
        {
            throw new NotImplementedException();
        }

        IEnumerable<PayModeModel> IPayModeRepository.GetAll()
        {
            throw new NotImplementedException();
        }

        IEnumerable<PayModeModel> IPayModeRepository.GetByValue(string value)
        {
            throw new NotImplementedException();
        }
    }
}
