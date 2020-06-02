using Civia.Data.BusinessLogic;
using Civia.Data.DataAccess;
using Civia.Data.DataRepository;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Civia.Test.BusinessLogic
{
    public class CustomerBLTest
    {
        private Mock<IEntityRepository<Customer>> customerRepositiry;
        private List<Customer> customers;

        [SetUp]
        public void SetUp()
        {
            customerRepositiry = new Mock<IEntityRepository<Customer>>();
            customers = new List<Customer>();
            customers.Add(new Customer() { Id = 1, FirstName = "Cus1", CustomerId = "C001", IsDeleted = false, LastName = "Tomer1" });
            customers.Add(new Customer() { Id = 2, FirstName = "Cus2", CustomerId = "C002", IsDeleted = true, LastName = "Tomer2" });
            customers.Add(new Customer() { Id = 1, FirstName = "Cus3", CustomerId = "C003", IsDeleted = false, LastName = "Tomer3" });
        }

        [Test]
        public void TestGetActiveRecords()
        {
            customerRepositiry.Setup(a => a.GetAllQueryable()).Returns(customers.AsQueryable());

            var customerBL = new CustomerBL(customerRepositiry.Object);
            var customerList = customerBL.GetActiveCustomers();

            Assert.IsTrue(customerList.Count == 2);
            Assert.IsTrue(customerList.All(s => s.IsDeleted == false));
        }
    }
}
