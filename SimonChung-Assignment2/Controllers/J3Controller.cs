using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SimonChung_Assignment2.Controllers
{
    //2021 J3 Problem
    public class J3Controller : ApiController
    {
        /// <summary>
        /// This method is supposed to return the directions to turn and the number of steps to take in those directions given
        /// some 5 digit integers in order to find the location of a secret formula for a biofuel.
        /// The first 2 digits of each integer inputed indicate the direction to turn. If the sum of the first 2 digits are:
        /// odd -> the person is to turn left
        /// even and not zero-> the person is to turn right
        /// zero -> the person is to turn in the same direction as the previous direction.
        /// The last 3 digits of each integer inputed are the number of steps to take in that direction.
        /// If "n" number of integers are inputed, "n" number of lines of output are outputed with an additional "n + 1th" line
        /// that returns "99999" which indicates that no more integers are expected.
        /// </summary>
        /// <param name="id1"></param>
        /// <param name="id2"></param>
        /// <param name="id3"></param>
        /// <param name="id4"></param>
        /// <param name="id5"></param>
        /// <returns></returns>
        [HttpGet]

        public IEnumerable<string> Directions(int id1, int id2, int id3, int id4)
        {
            
            // converts inputs to strings
            string a1 = id1.ToString();
            string a2 = id2.ToString();
            string a3 = id3.ToString();
            string a4 = id4.ToString();


            //extracts 1st and 2nd digits using substring method
            string b1 = a1.Substring(0, 1);
            string c1 = a1.Substring(1, 1);

            string b2 = a2.Substring(0, 1);
            string c2 = a2.Substring(1, 1);

            string b3 = a3.Substring(0, 1);
            string c3 = a3.Substring(1, 1);

            string b4 = a4.Substring(0, 1);
            string c4 = a4.Substring(1, 1);


            //converts extracted 1st and 2nd digits into integers
            int d1 = Int32.Parse(b1);
            int e1 = Int32.Parse(c1);

            int d2 = Int32.Parse(b2);
            int e2 = Int32.Parse(c2);

            int d3 = Int32.Parse(b3);
            int e3 = Int32.Parse(c3);

            int d4 = Int32.Parse(b4);
            int e4 = Int32.Parse(c4);


            //IF statements to check if the sum of the first 2 digits of each input
            //are odd, even and not zero, or zero
            //IF the sum of the first 2 digits are odd, create a string variable with value "left"
            //IF even and not zero, string variable has value "right"
            //IF equal to zero, string variable has value of previous input

            string f1;
            string f2;
            string f3;
            string f4;

            if ((d1 + e1) % 2 != 0)
            {
                f1 = "left";
            }
            else if ((d1 + e1) % 2 == 0 && (d1 + e1) != 0))
            {
                f1 = "right";
            }


            if ((d2 + e2) % 2 != 0)
            {
                f2 = "left";
            }
            else if ((d2 + e2) % 2 == 0 && (d2 + e2) != 0))
            {
                f2 = "right";
            }
            else if ((d2 + e2) == 0))
            {
                f2 = f1;
            }


            if ((d3 + e3) % 2 != 0)
            {
                f3 = "left";
            }
            else if ((d3 + e3) % 2 == 0 && (d3 + e3) != 0))
            {
                f3 = "right";
            }
            else if ((d3 + e3) == 0))
            {
                f3 = f2;
            }


            if ((d4 + e4) % 2 != 0)
            {
                f4 = "left";
            }
            else if ((d4 + e4) % 2 == 0 && (d4 + e4) != 0))
            {
                f4 = "right";
            }
            else if ((d4 + e4) == 0))
            {
                f4 = f3;
            }


            //extract last 3 digits of each input
            string g1 = a1.Substring(2, 3);
            string g2 = a2.Substring(2, 3);
            string g3 = a3.Substring(2, 3);
            string g4 = a4.Substring(2, 3);

            //return outputs
            string h1 =  f1 + g1;
            string h2 =  f2 + g2;
            string h3 =  f3 + g3;
            string h4 =  f4 + g4;
            return new string[] { h1, h2, h3, h4, "99999"};
        }

    }
}
