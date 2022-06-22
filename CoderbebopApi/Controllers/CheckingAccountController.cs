using Microsoft.AspNetCore.Mvc;
using CoderBebopBL;
using Microsoft.Data.SqlClient;
using CoderBebopModel;

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

        [HttpPost("Deposit")]
        public IActionResult UpdateDeposit([FromBody] int p_balance, int p_balance1)
        {
            try
            {
                _checkingBL.UpdateDeposit(p_balance, p_balance1);

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
                _checkingBL.UpdateWithdraw(p_balance, p_balance1);

                return Created("Your money has been withdrawn!", p_balance);
            }
            catch (SqlException)
            {
                
                return Conflict();
            }
        }
    }
}