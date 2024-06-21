using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1n01075532.Controllers
{
    public class HostingCostController : ApiController
    {
        //Define fortnight (fortnight = 14 days)
        const int fortnight = 14;
        //Define base cost (5.50 per Fortnight)
        const decimal baseCost = 5.50M; //Using an 'M' at the end we can indicate that the output is a decimal
        //Define hst (13% or 0.13)
        const decimal hst = 0.13M;

        public decimal GetHostingCost(int id)
        {
            //Define days elapsed (The input {id} is the daysElapsed)
            int daysElapsed = id;

            //To calculate the fortnights elapsed, we divide the daysElapsed by the value 'fortnight' (14)
            int fortnightsElapsed = daysElapsed / fortnight;

            //To find the total cost, multiply the number of fortnights elapsed by the base cost (5.50)
            decimal totalCost = fortnightsElapsed * baseCost;

            //To find the taxes, multiply the total cost by the hst
            decimal taxes = totalCost * hst;

            //To find the total hosting cost, add the taxes to the total cost 
            decimal hostingCost = totalCost + taxes;

            //Return hosting cost
            return hostingCost;

        }





    }
}
