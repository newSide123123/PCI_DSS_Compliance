﻿using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ProductStorage.Service.Interfaces;
using System.Threading.Tasks;
using ProductStorage.Service.Response;
using ProductStorage.Service.Models.Customer;

namespace ProductStorage_WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var response = (BaseResponse<IEnumerable<CustomerModel>>)await _customerService.GetCustomers();
            if (response.Data == null)
            { 
                return NotFound(response.Description);
            }
            return Ok(response.Data);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var response = (BaseResponse<CustomerModel>)await _customerService.GetById(id);
            if (response.Data == null)
            {
                return NotFound(response.Description);
            }
            return Ok(response.Data);
        }

        [HttpGet("[action]/{name}")]
        public async Task<IActionResult> GetByName(string name)
        {
            var response = (BaseResponse<CustomerModel>)await _customerService.GetByName(name);
            if (response.Data == null)
            {
                return NotFound(response.Description);
            }
            return Ok(response.Data);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]CustomerModel customer)
        {
            var response = (BaseResponse<bool>) await _customerService.Create(customer);

            if (response.Data)
            {
                return Ok("Customer record has been created.");
            }
            else
            {
                return NotFound(response.Description);
            }

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
           var response = (BaseResponse<bool>)await _customerService.Delete(id);

           if(response.Data)
           {
                return Ok("User has been deleted.");
           }
           else
           {
                return NotFound(response.Description);
           }
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> Patch(int id, CustomerModel product)
        {
            var response = (BaseResponse<bool>)await _customerService.Update(id, product);

            if (response.Data)
            {
                return Ok("Customer has been updated.");
            }
            else
            {
                return NotFound(response.Description);
            }
        }
    }    
}        
