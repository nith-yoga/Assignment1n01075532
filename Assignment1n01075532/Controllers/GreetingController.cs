using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Web.Http;

namespace Assignment1n01075532.Controllers
{
    public class GreetingController : ApiController
    {

        public string Get()
        {
            return "Hello World!";
        }


    //GET api/Greeting/{id}
    public string Get(int id)
        {
           return "Greetings to " + id + " people!" ;
        }
    }
}
