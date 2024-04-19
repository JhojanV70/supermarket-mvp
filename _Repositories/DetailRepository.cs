using Supermarket_mvp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Supermarket_mvp._Repositories
{
    internal class DetailRepository : BaseRepository, IDetailRepository
    {
        public DetailRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public void Add(DetailModel detailModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO Detail VALUES (@quantity, @price)";
                command.Parameters.Add("@quantity", SqlDbType.NVarChar).Value = detailModel.Quantity;
                command.Parameters.Add("@price", SqlDbType.NVarChar).Value = detailModel.Price;
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE FROM Detail WHERE Detail_Id = id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }

        public void Edit(DetailModel detailModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"UPDATE Detail
                                       SET Detail_Quantity = @quantity,
                                       Detail_Price = @price
                                        WHERE Detail_Id = @id";
                command.Parameters.Add("@quantity", SqlDbType.NVarChar).Value = detailModel.Quantity;
                command.Parameters.Add("@price", SqlDbType.NVarChar).Value = detailModel.Price;
                command.Parameters.Add("@id", SqlDbType.NVarChar).Value = detailModel.Id;
                command.ExecuteNonQuery();
            }
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
