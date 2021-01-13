using DataLayer;
using Shared.Interfaces.Business;
using Shared.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    class ReceiptItemsBusiness : IReceiptItemsBusiness
    {
        private readonly IReceiptItemsRepository receiptItemsRepository;
        public ReceiptItemsBusiness(IReceiptItemsRepository _receiptItemRepository)
        {
            this.receiptItemsRepository = _receiptItemRepository;
        }
        public List<ReceiptItem> GetAllReceiptItems()
        {
            return this.receiptItemsRepository.GetAllReceiptItems();
        }
        public bool InsertReceiptItem(ReceiptItem r)
        {
            if (this.receiptItemsRepository.InsertReceiptItem(r) > 0)
            {
                return true;
            }
            return false;
        }
       
        public bool DeleteReceiptItemById(int rId, int pId)
        {
            if (this.receiptItemsRepository.DeleteReceiptItemById(rId, pId) > 0)
            {
                return true;
            }
            return false;
        }
        public List<ReceiptItem> GetReceiptItemByReceiptId(int receiptId)
        {
            return this.receiptItemsRepository.GetAllReceiptItems().Where(r => r.IdReceipt == receiptId).ToList();
        }
    }
}
