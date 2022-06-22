using CoderBebopBL;
using CoderBebopModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Serilog;

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

        [HttpPost("AddCustomer")]
        public IActionResult AddCustomer( decimal c_checking, decimal c_savings, decimal c_market, [FromBody] Customer c_cust)
        {
            try
            {
                Log.Information("User created an account.");

                _checkBL.AddCheckingAcc(c_checking);
                Log.Information(c_checking + " has been opened.");
                _marketBL.AddMarketAcc(c_market);
                Log.Information(c_market + " has been opened.");
                _savingsBL.AddSavingsAcc(c_savings);
                Log.Information(c_savings + " has been opened.");

                _custBL.AddCus(c_cust);
                
                Log.Information("User is now a Customer.");

                

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
                Log.Information("Customer match has been found for Card Number: " + cardNumber + " and PIN: " + Pin);
                return Ok(_custBL.Search(cardNumber,Pin));
            }
            catch (System.AccessViolationException)
            {
                
                return Conflict();
            }
        }
    }
}