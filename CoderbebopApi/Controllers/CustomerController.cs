using CoderBebopBL;
using CoderBebopModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace CoderbebopApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase {

        private readonly iMarketBL _marketBL;
        private readonly iSavingsBL _savingsBL;
        private readonly iCheckingBL _checkBL;
        private readonly iCustomerBL _custBL;

        public CustomerController(iMarketBL marketBL, iSavingsBL savingsBL, iCheckingBL checkBL, iCustomerBL custBL)
        {
            _marketBL = marketBL;
            _savingsBL = savingsBL;
            _checkBL = checkBL;
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
        public IActionResult AddCustomer( decimal c_checking, decimal c_savings, decimal c_market, [FromBody] Customer c_cust)
        {
            try
            {
                _checkBL.AddCheckingAcc(c_checking);
                _marketBL.AddMarketAcc(c_market);
                _savingsBL.AddSavingsAcc(c_savings);

                _custBL.AddCus(c_cust);

                return Created("New Customer has been entered into the databse.", c_cust);
            }
            catch (System.AccessViolationException)
            {
                
                return Conflict();
            }
        }

        [HttpGet("SearchCustomer")]
        public IActionResult SearchCustomer(decimal cardNumber, int Pin)
        {
            try
            {
                return Ok(_custBL.Search(cardNumber,Pin));
            }
            catch (System.AccessViolationException)
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