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
            var detailList = new List<DetailModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Detail ORDER BY Detail_Id DESC";
                using (var reader = command.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        var detailModel = new DetailModel();
                        detailModel.Id = (int)reader["Detail_Id"];
                        detailModel.Quantity = reader["Detail_Quantity"].ToString();
                        detailModel.Price = reader["Detail_Price"].ToString();
                        detailList.Add(detailModel);
                    }
                }
            }
            return detailList;
        }

        public IEnumerable<DetailModel> GetByValue(string value)
        {
            var detailList = new List<DetailModel>();
            int detailId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string detailQuantity = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Categorie
                                        WHERE Detail_Id=@id or Detail_Quantity LIKE @quantity+ '%'
                                        ORDER By Detail_Id DESC";
                command.Parameters.Add("@id", SqlDbType.Int).Value = detailId;
                command.Parameters.Add("@quantity", SqlDbType.NVarChar).Value = detailQuantity;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var detailModel = new DetailModel();
                        detailModel.Id = (int)reader["Detail_Id"];
                        detailModel.Quantity = reader["Detail_Quantity"].ToString();
                        detailModel.Price = reader["Detail_Description"].ToString();
                        detailList.Add(detailModel);
                    }
                }
            }
            return detailList;
        }
    }
}
