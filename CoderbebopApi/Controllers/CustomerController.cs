using CoderBebopBL;
using CoderBebopModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace CoderbebopApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase {
        private iCustomerBL _custBL;

        public CustomerController(iCustomerBL custBL)
        {
            _custBL = custBL;
        }

        // [HttpGet("GetAllCustomer")]
        // public async Task<IActionResult> GetAllCustomer(){
        //     try
        //     {
        //         List<Customer> listOfCurrentCustomers = await _custBL.GetAllCustomerAsync();

        //         return Ok(listOfCurrentCustomers);
        //     }
        //     catch (SqlException)
        //     {
                
        //         return NotFound("Error: Customer Directory Not Present")
        //     }
        // }

        [HttpPost("AddCustomer")]
        public IActionResult AddCustomer([FromBody] Customer c_cust)
        {
            try
            {
                _custBL.AddCus(c_cust);

                return Created("New Customer has been entered into the databse.", c_cust);
            }
            catch (SqlException)
            {
                
                return Conflict();
            }
        }

        // [HttpGet("SearchCustomerByName")]
        // public IActionResult SearchCustomer([FromQuery] string custName){
        //     try
        //     {
        //         return Ok(_custBL.SearchCustomerByName(custName));
        //     }
        //     catch (SqlException)
        //     {
                
        //         return Conflict;
        //     }
        // }
    }
}