using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using fitProTrackerTecTest.Models;
namespace fitProTrackerTecTest.Controllers
{
    public class FptController : Controller
    {
        public void AddCustomer() {
            Customer newCustomer = new Customer();

        }
        public List<Object> ListCustomers() {
            List<Object> lista = new List<Object>();
            return lista;
        }
        public string DeleteCustomer(string customerName) {
            return " ";
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
