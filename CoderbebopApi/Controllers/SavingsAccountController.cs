using Microsoft.AspNetCore.Mvc;
using CoderBebopBL;
using Microsoft.Data.SqlClient;
using CoderBebopModel;

namespace CoderbebopApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SavingsAccountController : ControllerBase
    {
        private iSavingsBL _savingsBL;
        public SavingsAccountController(iSavingsBL s_atmBL)
        {
            _savingsBL = s_atmBL;
        }

        // [HttpGet("ViewSavingsAccount")]
        // public IActionResult ViewSavingsAccount([FromQuery] int c_sAccId)
        // {
        //     return Ok(_savingsBL.ViewCheckingAccount(c_sAccId));
        // }

        [HttpPost("Deposit")]
        public IActionResult UpdateDeposit([FromBody] int p_balance, int p_balance1)
        {
            try
            {
                _savingsBL.UpdateDeposit(p_balance, p_balance1);

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