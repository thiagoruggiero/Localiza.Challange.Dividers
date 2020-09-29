using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Localiza.Challange.Dividers.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Localiza.Challange.Dividers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DividersController : ControllerBase
    {
        private readonly IDividersService _dividersService;

        public DividersController(IDividersService dividersService)
        {
            _dividersService = dividersService;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetDividers([FromQuery] int number)
        {
            var responseDividers = _dividersService.GetDividers(number);

            if (responseDividers.FoundAnswer)
                return Ok(responseDividers);
            else
                return NoContent();
        }
    }
}
