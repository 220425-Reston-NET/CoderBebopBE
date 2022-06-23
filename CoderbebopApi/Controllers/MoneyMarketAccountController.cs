using Microsoft.AspNetCore.Mvc;
using CoderBebopBL;
using Microsoft.Data.SqlClient;
using CoderBebopModel;
using Serilog;

namespace CoderbebopApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoneyMarketAccountController : ControllerBase
    {
        private readonly iMarketBL _marketBL;
        public MoneyMarketAccountController(iMarketBL m_marketBL)
        {
            _marketBL = m_marketBL;
        }

        [HttpPut("Deposit")]
        public IActionResult UpdateDeposit([FromQuery] int p_balance, int p_ID)
        {
            try
            {

                Log.Information("Customer has deposited $" + p_balance + " into Money Market Account.");
                
                _marketBL.UpdateDeposit(p_balance, p_ID);

                Log.Information("New Money Market Account Balance is $" + p_balance + ".");

                return Ok("Your money has been deposited!");
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

                Log.Information("Customer has withdrew $" + p_balance + " from Money Market Account.");

                _marketBL.UpdateWithdraw(p_balance, p_ID);

                Log.Information("New Money Market Account Balance is $" + p_balance + ".");

                return Ok("Your money has been withdrawn!");
            }
            catch (SqlException)
            {
                
                return Conflict();
            }
        }
    }
}