using Microsoft.AspNetCore.Mvc;
using CoderBebopBL;
using Microsoft.Data.SqlClient;
using CoderBebopModel;
using Serilog;

namespace CoderbebopApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SavingsAccountController : ControllerBase
    {
        private readonly iSavingsBL _savingsBL;
        public SavingsAccountController(iSavingsBL s_atmBL)
        {
            _savingsBL = s_atmBL;
        }

        [HttpPut("Deposit")]
        public IActionResult UpdateDeposit([FromQuery] int p_balance, int p_ID)
        {
            try
            {

                Log.Information("Customer has deposited $" + p_balance + " into Savings Account.");
                
                
                _savingsBL.UpdateDeposit(p_balance, p_ID);

                Log.Information("New Savings Account Balance is $" + p_balance + ".");

                return Ok("Your money has been deposited!");
            }
            catch (SqlException)
            {
                
                return Conflict();
            }
        }

        [HttpPut("Withdraw")]
        public IActionResult UpdateWithdraw([FromQuery] int p_balance, int p_ID)
        {
            try
            {

                Log.Information("Customer has withdrew $" + p_balance + " from Savings Account.");

                _savingsBL.UpdateWithdraw(p_balance, p_ID);

                

                return Ok("Your money has been withdrawn!");
            }
            catch (SqlException)
            {
                
                return Conflict();
            }
        }
    }
}