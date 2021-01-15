using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces.Business
{
    public interface IReceiptBusiness
    {
        public List<Receipt> GetAllReceipts();
        public bool UpdateReceipt(Receipt r);
        public List<Receipt> GetReceiptsByDate(DateTime date);
        public Receipt GetReceiptById(int id);
    }
}
