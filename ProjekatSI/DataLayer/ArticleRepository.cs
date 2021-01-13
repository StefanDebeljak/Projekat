using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class ArticleRepository
    {
        public List<Article> GetAll()
        {
            List<Article> results = new List<Article>();

            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM Articles WHERE InStock = 'true'";

                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Article a = new Article();
                    a.ArticleId = sqlDataReader.GetInt32(0);
                    a.ArticleName = sqlDataReader.GetString(1);
                    a.Price = sqlDataReader.GetDecimal(2);
                    a.InStock = sqlDataReader.GetBoolean(3);

                    results.Add(a);
                }
            }

            return results;
        }
    }
}
