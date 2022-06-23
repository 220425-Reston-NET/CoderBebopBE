using Microsoft.AspNetCore.Mvc;
using CoderBebopBL;
using Microsoft.Data.SqlClient;
using CoderBebopModel;
using Serilog;

namespace CoderbebopApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CheckingAccountController : ControllerBase
    {
        private readonly iCheckingBL _checkingBL;
        public CheckingAccountController(iCheckingBL p_accBL)
        {
            _checkingBL = p_accBL;
        }

        [HttpPut("Deposit")]
        public IActionResult UpdateDeposit([FromQuery] int p_balance, int p_ID)
        {
            try
            {
                Log.Information("Customer has deposited $" + p_balance + " into Checkings Account.");
                

                _checkingBL.UpdateDeposit(p_balance, p_ID);

                Log.Information("New Checking Account Balance is $" + p_balance + ".");

                return Ok("Your money has been deposited! " + p_balance);
            }
            catch (SqlException)
            {
                
                return Conflict();
            }
        }

        [HttpPut("Withdraw")]
        public IActionResult UpdateWithdraw([FromQuery] int p_balance, int p_ID )
        {
            try
            {
                Log.Information("Customer has withdrew $" + p_balance + " from Checkings Account.");
                

                _checkingBL.UpdateWithdraw(p_balance, p_ID);

                Log.Information("New Checking Account Balance is $" + p_balance + ".");

                return Ok("Your money has been withdrawn! " + p_balance);
            }
            catch (SqlException)
            {
                
                return Conflict();
            }
        }
    }
}