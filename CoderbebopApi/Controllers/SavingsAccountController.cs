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

        [HttpPost("Deposit")]
        public IActionResult UpdateDeposit([FromBody] int p_balance, int p_balance1)
        {
            try
            {

                Log.Information("Customer has deposited $" + p_balance1 + " into Savings Account.");
                
                
                _savingsBL.UpdateDeposit(p_balance, p_balance1);

                Log.Information("New Savings Account Balance is $" + p_balance + ".");

                return Created("Your money has been deposited!", p_balance);
            }
            catch (SqlException)
            {
                
                return Conflict();
            }
        }

        [HttpPost("Withdraw")]
        public IActionResult UpdateWithdraw([FromBody] int p_balance, int p_balance1)
        {
            try
            {

                Log.Information("Customer has withdrew $" + p_balance1 + " from Savings Account.");

                _savingsBL.UpdateWithdraw(p_balance, p_balance1);

                

                return Created("Your money has been withdrawn!", p_balance);
            }
            catch (SqlException)
            {
                
                return Conflict();
            }
        }
    }
}