using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces.Repository
{
    public interface IReceiptItemsRepository
    {
        public List<ReceiptItem> GetAllReceiptItems();
        public int InsertReceiptItem(ReceiptItem r);
        public int DeleteReceiptItemById(int rId, int aId);
    }
}
