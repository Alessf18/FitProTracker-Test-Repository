using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fitProTrackerTecTest.Models
{
    public class Customer
    {
        private string customerName;
        private string phone;
        private string email;
        private string notes;

        public string CustomerName { get => customerName; set => customerName = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }
        public string Notes { get => notes; set => notes = value; }
       
    }
}
