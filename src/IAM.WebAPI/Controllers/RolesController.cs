using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IAM.WebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace IAM.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RolesController : ControllerBase
    {
        public RolesController()
        {
        }

        [HttpGet]
        public IEnumerable<Role> Get()
        {
            return new[]
            {
                new Role
                {
                    Id = Guid.NewGuid(),
                    Name = "Owner",
                    Created = DateTime.UtcNow,
                    Updated = DateTime.UtcNow
                }
            };
        }
    }
}
