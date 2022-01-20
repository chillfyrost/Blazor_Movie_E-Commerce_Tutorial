using MyBlazorApp.CoreBusiness.Models;

namespace MyBlazorApp.CoreBusiness.Services
{
    public interface ICustomerService
    {
        string UId { get; set; }

        Customer GetCustomerById(int id);
    }
}