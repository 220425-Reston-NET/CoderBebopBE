using Microsoft.AspNetCore.Mvc;
using CoderBebopBL;
using Microsoft.Data.SqlClient;
using CoderBebopModel;

namespace CoderbebopApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoneyMarketAccountController : ControllerBase
    {
        private iMarketBL _marketBL;
        public MoneyMarketAccountController(iMarketBL m_marketBL)
        {
            _marketBL = m_marketBL;
        }

        // [HttpGet("ViewMoneyMarketAccount")]
        // public IActionResult ViewMoneyMarketAccount([FromQuery] int c_mAccId)
        // {
        //     return Ok(_marketBL.ViewMoneyMarketAccount(c_mAccId));
        // }

        [HttpPost("Deposit")]
        public IActionResult UpdateDeposit([FromBody] int p_balance, int p_balance1)
        {
            try
            {
                _marketBL.UpdateDeposit(p_balance, p_balance1);

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
                _marketBL.UpdateWithdraw(p_balance, p_balance1);

                return Created("Your money has been withdrawn!", p_balance);
            }
            catch (SqlException)
            {
                
                return Conflict();
            }
        }
    }
}