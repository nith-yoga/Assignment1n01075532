using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1n01075532.Controllers
{
    public class NumberMachineController : ApiController
    {
        public (int, int, int, int) Get(int id)
        {
            int sum = id + id;
            int subtraction = id - 5;
            int multiply = id * id;
            int division = id / 2;
            return (sum, subtraction, multiply, division);
        }
    }
}
