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
    public class UsersController : ControllerBase
    {
        public UsersController()
        {
        }

        [HttpGet]
        public IEnumerable<User> Get()
        {
            return new[]
            {
                new User
                {
                    Id = Guid.NewGuid(),
                    Name = "Boris Blade",
                    Role = new Role
                    {
                        Id = Guid.NewGuid(),
                        Name = "Owner",
                        Created = DateTime.UtcNow,
                        Updated = DateTime.UtcNow
                    },
                    Created = DateTime.UtcNow,
                    Updated = DateTime.UtcNow
                }
            };
        }
    }
}
