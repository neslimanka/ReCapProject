using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTO
{
    public class ConsumerForLoginDto : IDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
