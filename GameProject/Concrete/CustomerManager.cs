using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private ICustomerCheckService _customerCheckService;

        public CustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }
        public void Add(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                Console.WriteLine("Customer Added" + " " + customer.Id + " " + customer.NationalityId + " " + customer.FirstName + " " +
                customer.LastName + " " + customer.DateOfBirth);
            }
            else
            {
                Console.WriteLine("Not a valid person");
            }

        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Customer Deleted" + " " + customer.Id + " " + customer.NationalityId + " " + customer.FirstName + " " +
                customer.LastName + " " + customer.DateOfBirth);
        }

        public void Update(Customer customer)
        {
            Console.WriteLine("Customer Updated" + " " + customer.Id + " " + customer.NationalityId + " " + customer.FirstName + " " +
                customer.LastName + " " + customer.DateOfBirth);
        }
    }
}
