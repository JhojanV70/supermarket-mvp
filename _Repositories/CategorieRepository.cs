using Supermarket_mvp.Models;
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
    internal class CategorieRepository : BaseRepository, ICategorieRepository
    {
        public CategorieRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
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
            var categorieList = new List<CategorieModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Categorie ORDER BY Categorie_Id DESC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var categorieModel = new CategorieModel();
                        categorieModel.Id = (int)reader["Categorie_Id"];
                        categorieModel.Name = reader["Categorie_Name"].ToString();
                        categorieModel.Description = reader["Categorie_Description"].ToString();
                        categorieList.Add(categorieModel);
                    }
                }
            }
            return categorieList;
        }

        public IEnumerable<CategorieModel> GetByValue(string value)
        {
            throw new NotImplementedException();
        }
    }
}
