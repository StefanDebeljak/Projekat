using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces.Repository
{
    public interface IReceiptRepository
    {
        public List<Receipt> GetAllReceipts();
        public int InsertReceipts(Receipt r);
        public int UpdateReceipt(Receipt r);
    }
}
