using Shared.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class WorkerRepository : IWorkerRepository
    {
        public List<Worker> GetAllWorkers()
        {
            List<Worker> results = new List<Worker>();

            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM Workers";

                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Worker w = new Worker();
                    w.WorkerId = sqlDataReader.GetInt32(0);
                    w.FirstName = sqlDataReader.GetString(1);
                    w.LastName = sqlDataReader.GetString(2);
                    w.Password = sqlDataReader.GetString(3);

                    results.Add(w);
                }
            }

            return results;
        }
    }
}
