using System;

namespace IAM.WebAPI.Models
{
    public class User
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public Role Role { get; set; }

        public DateTime Created { get; set; }

        public DateTime Updated { get; set; }
    }
}
