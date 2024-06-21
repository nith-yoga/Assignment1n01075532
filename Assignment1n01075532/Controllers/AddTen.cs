using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1n01075532.Controllers
{
    public class AddTenController : ApiController
    {

        //GET Return = int input + 10
        public int Get(int id)
        {
            int sum = id + 10;
            return sum;
        }


    }
}
