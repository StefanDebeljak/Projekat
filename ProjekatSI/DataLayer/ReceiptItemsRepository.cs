using Shared.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class ReceiptItemsRepository : IReceiptItemsRepository
    {
        public List<ReceiptItem> GetAllReceiptItems()
        {
            List<ReceiptItem> listOfReceiptItems = new List<ReceiptItem>();

            SqlDataReader sqlDataReader = DBConnection.GetData("SELECT * FROM ReceiptItems");

            while (sqlDataReader.Read())
            {
                ReceiptItem r = new ReceiptItem();
                r.IdArticle = sqlDataReader.GetInt32(0);
                r.IdReceipt = sqlDataReader.GetInt32(1);
                r.Quantity = sqlDataReader.GetInt32(2);
                listOfReceiptItems.Add(r);
            }

            DBConnection.CloseConnection();
            return listOfReceiptItems;
        }
        public int InsertReceiptItem(ReceiptItem r)
        {
            var result = DBConnection.EditData(string.Format("INSERT INTO ReceiptItems VALUES ('{0}',  '{1}', '{2}')", r.IdArticle, r.IdReceipt, r.Quantity));

            DBConnection.CloseConnection();
            return result;
        }
        public int DeleteReceiptItemById(int rId, int aId)
        {
            var result = DBConnection.EditData(string.Format("DELETE FROM ReceiptItems WHERE ReceiptId = '{0}' AND ArticleId = '{1}' ", rId, aId));

            DBConnection.CloseConnection();
            return result;

        }
    }
}
