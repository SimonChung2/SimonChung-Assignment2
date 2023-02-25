using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SimonChung_Assignment2.Controllers
{
    //2022 J1 Problem
    public class J1Controller : ApiController
    {
        /// <summary>
        /// This method returns the number of cupcakes that are leftover after buying: 
        /// {R} boxes that contain 8 cupcakes each and
        /// {S} boxes that contain 3 cupcakes each
        /// for a class of 28 students where each student gets 1 cupcake.
        /// </summary>
        /// <param name="id1"></param>
        /// <param name="id2"></param>
        /// <returns>
        /// If the total number of cupcakes bought is greater than or equal to 28, the remaining number of cupcakes is returned as a string.
        /// If the total number of cupcakes bought is less than 28, a string "Need to order more cupcakes!" is returned.
        /// </returns>
        /// <example>
        /// GET api/J1/Leftovers/2/9 -->"15"
        /// GET api/J1/Leftovers/3/5 -->"11"
        /// GET api/J1/Leftovers/3/1 -->"Need to order more cupcakes!"
        /// </example>

        [HttpGet]
        public string Leftovers(int id1, int id2)
        {
            int R = id1;
            int S = id2;
            int students = 28;
            int normalBox = 8;
            int smallBox = 3;
  
            int totalCupcakes = R*normalBox+ S*smallBox;
            int remainder = totalCupcakes - students;
            if(remainder<0)
            {
                return "Need to order more cupcakes!"; 
            }
            else
            {
                return Convert.ToString(remainder); 
            }
        }
    }
}
