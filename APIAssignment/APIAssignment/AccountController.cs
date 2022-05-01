using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIAssignment
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        [HttpPost]
        
        public IActionResult AddData(CreateAccountEntity account, CustomerDetailsEntity customer)
        {
            APIAssignmentServices services = new APIAssignmentServices();
            services.CreateAccount(account, customer);
            return Ok();
        }
    }
}
