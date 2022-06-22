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

        [HttpPost("Deposit")]
        public IActionResult UpdateDeposit([FromBody] int p_balance, int p_balance1)
        {
            try
            {

                Log.Information("Customer has deposited $" + p_balance1 + " into Money Market Account.");
                
                _marketBL.UpdateDeposit(p_balance, p_balance1);

                Log.Information("New Money Market Account Balance is $" + p_balance + ".");

                return Created("Your money has been deposited!", p_balance);
            }
            catch (SqlException)
            {
                
                return Conflict();
            }
        }

        [HttpPost("Withdraw")]
        public IActionResult UpdateWithdraw([FromBody] int p_balance, int p_balance1 )
        {
            try
            {

                Log.Information("Customer has withdrew $" + p_balance1 + " from Money Market Account.");

                _marketBL.UpdateWithdraw(p_balance, p_balance1);

                Log.Information("New Money Market Account Balance is $" + p_balance + ".");

                return Created("Your money has been withdrawn!", p_balance);
            }
            catch (SqlException)
            {
                
                return Conflict();
            }
        }
    }
}