using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces.Business
{
    public interface IWorkerBusiness
    {
        public List<Worker> GetAllWorker();
        public Worker GetWorkerById(int id);
        public Worker GetWorkerByNameAndPass(string workerName, string workerPass);
    }
}
