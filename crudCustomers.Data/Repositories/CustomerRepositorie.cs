using crudCustomers.Model;
using System.Threading.Tasks;

namespace crudCustomers.Data.Repositories
{
    public class CustomerRepositorie : ICustomerRepositorie
    {
        private DataBaseConfiguration _connectionString; 

        public CustomerRepositorie(DataBaseConfiguration connectionString)
        {
            _connectionString  =  connectionString;
        }
        public Task<bool> CreateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Customer>> GetAllCustomers()
        {
            throw new NotImplementedException();
        }

        public Task<Customer> GetCustomerById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
