using Shared.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class ReceiptRepository : IReceiptRepository
    {
        public List<Receipt> GetAllReceipts()
        {
            List<Receipt> listOfReceipts = new List<Receipt>();

            SqlDataReader sqlDataReader = DBConnection.GetData("SELECT * FROM Receipts");

            while (sqlDataReader.Read())
            {
                Receipt r = new Receipt();
                r.ReceiptId = sqlDataReader.GetInt32(0);
                r.Date = sqlDataReader.GetDateTime(1);
                r.TotalPrice= sqlDataReader.GetDecimal(2);
                listOfReceipts.Add(r);
            }

            DBConnection.CloseConnection();
            return listOfReceipts;
        }
        public int InsertReceipts(Receipt r)
        {
            var result = DBConnection.EditData(string.Format("INSERT INTO Receipts VALUES ('{0}',  '{1}', '{2}')", r.ReceiptId, r.Date, r.TotalPrice));

            DBConnection.CloseConnection();
            return result;

        }
        public int UpdateReceipt(Receipt r)
        {
            var result = DBConnection.EditData(string.Format("UPDATE Receipts SET Date = '{0}', TotalPrice = '{1}' WHERE ReceiptId = '{2}'", r.Date, r.TotalPrice, r.ReceiptId));

            DBConnection.CloseConnection();
            return result;

        }
    }
}
