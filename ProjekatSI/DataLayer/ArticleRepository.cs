using Shared.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class ArticleRepository : IArticleRepository
    {
        public List<Article> GetAllArticles()
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
        public int UpdateArticle(Article a)
        {
            var result = DBConnection.EditData(string.Format("UPDATE Articles SET ArticleName = '{0}', Price = '{1}', InStock = '{2}' WHERE Id = '{3}' ", a.ArticleName, a.Price, a.InStock, a.ArticleId));

            DBConnection.CloseConnection();
            return result;

        }

        public int InsertArticle(Article a)
        {
            var result = DBConnection.EditData(string.Format("INSERT INTO Articles VALUES ('{0}',  '{1}', '{2}')", a.ArticleName, a.Price, a.InStock));
            DBConnection.CloseConnection();

            return result;
        }

        public int DeleteArticle(int Id)
        {
            var result = DBConnection.EditData(string.Format("DELETE FROM Articles WHERE ArticleId='{0}'", Id));

            DBConnection.CloseConnection();
            return result;
        }
    }
}
