﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1n01075532.Controllers
{
    public class SquareController : ApiController
    {

        //GET return = square of the integer (id)

        public int Get(int id)
        {
            int square = id * id;
            return square;
        }


    }
}
