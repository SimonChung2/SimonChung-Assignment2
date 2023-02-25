using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SimonChung_Assignment2.Controllers
{
    //2006 J2 Problem
    public class J2Controller : ApiController
    {
        /// <summary>
        /// This method returns a string stating 
        /// the total possible number of combinations of tens when 2 dice are rolled with 1 die having:
        /// {m} number of faces and the other die having
        /// {n} number of faces
        /// </summary>
        /// <param name="id1"></param>
        /// <param name="id2"></param>
        /// <returns>The total possible number of combinations of tens</returns>
        /// <example>
        /// GET api/J2/DiceGame/3/1 -> "There are 0 total ways to get the sum 10."
        /// GET api/J2/DiceGame/5/8 -> "There are 4 total ways to get the sum 10."
        /// GET api/J2/DiceGame/9/1 -> "There is 1 total way to get the sum 10."
        /// </example>
        [HttpGet]
        public string DiceGame(int id1,int id2)
        {
            int m = id1;
            int n = id2;
            int totalTen = 0;                   //counts the number of times m>= 10 -n for each value of n
            for(int i = 1; i <= n; i ++)        //loops from 1 to n
            {
                if(m >= (10-i) && i<10)     //checks to see if m+n= 10 or greater,  or if m >= 10-n. Also, checks if n<10
                                            //because increasing n past 10 shouldn't increase the totalTen counter
                                            //The number of totalTens should max out at m=9,n=9.
                {
                    totalTen = totalTen+ 1;     //For every value of n where m >= 10-n, adds 1 to the totalTen counter.
                }
            }
            if (totalTen != 1)
            {
                return "There are " + Convert.ToString(totalTen) + " total ways to get the sum 10.";
            } 
            else
            { return "There is " + Convert.ToString(totalTen) + " way to get the sum 10."; }
        }
    }
}
