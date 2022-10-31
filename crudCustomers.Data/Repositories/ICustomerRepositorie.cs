using crudCustomers.Model;
using System.Threading.Tasks;


namespace crudCustomers.Data.Repositories
{
    public interface ICustomerRepositorie
    {
        Task<IEnumerable <Customer>> GetAllCustomers();
        Task<Customer> GetCustomerById(int id); 
        Task<bool> CreateCustomer(Customer customer);
        Task<bool> UpdateCustomer(Customer customer);
        Task<bool> DeleteCustomer(Customer customer);
    }
}
