using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormUI
{
    public class Employee
    {
        public int Id { get; set; }
        public DateTimeOffset? BirthDate { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Gender { get; set; }
        public DateTimeOffset? HireDate { get; set; }

        public string FullInfo
        {
            get 
            { 
                return $"{FirstName} {LastName} ({HireDate})"; 
            }
        }

    }
}
