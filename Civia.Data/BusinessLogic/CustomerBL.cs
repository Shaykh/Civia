using Civia.Data.DataAccess;
using Civia.Data.DataRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Civia.Data.BusinessLogic
{
    public class CustomerBL
    {
        private IEntityRepository<Customer> _customerRepository { get; set; }
        public CustomerBL(IEntityRepository<Customer> customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public List<Customer> GetActiveCustomers()
        {
            var result = new List<Customer>();

            result = _customerRepository.GetAllQueryable().Where(c => c.IsDeleted == false).ToList();

            return result;
        }

        public bool GetActiveCustomers(Customer customer)
        {
            var isAdded = false;

            try
            {
                _customerRepository.Insert(customer);
                isAdded = true;
            }
            catch (Exception e)
            {
                isAdded = false;
            }

            return isAdded;
        }
    }
}
