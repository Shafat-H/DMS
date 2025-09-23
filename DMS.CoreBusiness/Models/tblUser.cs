using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DMS.CoreBusiness.Models
{
    public class tblUser
    {
        public long AccountId { get; set; }
        public long BranchId { get; set; }
        public long UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string confirmPassword { get; set; }
        public string Mobile { get; set; }
    }
}
