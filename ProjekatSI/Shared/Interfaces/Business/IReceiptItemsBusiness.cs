using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces.Business
{
    public interface IReceiptItemsBusiness
    {
        public List<ReceiptItem> GetAllReceiptItems();
        public bool InsertReceiptItem(ReceiptItem r);
        public bool DeleteReceiptItemById(int rId, int pId);
        public List<ReceiptItem> GetReceiptItemByReceiptId(int receiptId);
    }
}
