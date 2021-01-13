using Shared.Interfaces.Business;
using Shared.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    class WorkerBusiness : IWorkerBusiness
    {
        private readonly IWorkerRepository workerRepository;
        public WorkerBusiness(IWorkerRepository _workerRepository)
        {
            this.workerRepository = _workerRepository;
        }

        public List<Worker> GetAllWorker()
        {
            return this.workerRepository.GetAllWorkers();
        }

        public Worker GetWorkerById(int id)
        {
            return this.workerRepository.GetAllWorkers().FirstOrDefault(w => w.WorkerId == id);
        }

        public Worker GetWorkerByNameAndPass(string workerName, string workerPass)
        {
            return this.workerRepository.GetAllWorkers().FirstOrDefault(w => w.FirstName == workerName && w.Password == workerPass);
        }
    }
}
