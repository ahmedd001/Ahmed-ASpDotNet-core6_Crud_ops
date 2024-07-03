﻿using CustomerAPI.Models;

namespace CustomerAPI.Services.Interfaces
{
    public interface ICustomerTypeServices
    {
        Task<List<CustomerType>> GetCustomerTypes();
        Task<CustomerType> GetCustomerTypeById(int id);
        Task<CustomerType> AddCustomerType(CustomerType customerType);
        Task<CustomerType> UpdateCustomerType(CustomerType customerType);
        Task<CustomerType> DeleteCustomerType(CustomerType customerType);
    }
}
