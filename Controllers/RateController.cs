using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineHotelManagementAPI.Models;
using OnlineHotelManagementAPI.Service;

namespace OnlineHotelManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class RateController : ControllerBase
    {
        private readonly RateService S_rate;

        public RateController(RateService rate)
        {
            S_rate = rate;
        }

        #region InsertRate
        [HttpPost("InsertRate")]
        public IActionResult InsertRate(Rate rate)
        {
            return Ok(S_rate.InsertRate(rate));
        }
        #endregion

        #region UpdateRate
        [HttpPut("UpdateRate")]
        public IActionResult UpdateRate(Rate rate)
        {
            return Ok(S_rate.UpdateRate(rate));
        }
        #endregion

        #region GetAllRate
        [HttpGet("GetAllRate")]
        public IActionResult GetAllRate()
        {
            return Ok(S_rate.GetAllRate());
        }
        #endregion
    }
}
