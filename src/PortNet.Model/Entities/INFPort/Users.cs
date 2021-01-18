using Microsoft.AspNetCore.Identity;
using System;

namespace PortNet.Model.Entities.INFPort
{
    public class Users : IdentityUser
    {
        public string UserId { get; set; }
        public string Password { get; set; }
        public DateTime? Birthday { get; set; } = DateTime.Now;
        public bool? Sex { get; set; } = true;
        public string Address { get; set; }
        public string Street { get; set; }
        public long? Ward { get; set; }
        public long? District { get; set; }
        public long? City { get; set; }
        public string Identify { get; set; }
        public string Telephone { get; set; }
        public string HandPhone { get; set; }
        public string PicturePath { get; set; }
        public string BranchId { get; set; }
        public string LocationId { get; set; }
        public int? Sale { get; set; }
        public string Part { get; set; }
    }
}