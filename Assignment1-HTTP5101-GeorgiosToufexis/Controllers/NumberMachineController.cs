using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Web.Http;

namespace Assignment1_HTTP5101_GeorgiosToufexis.Controllers
{
    public class NumberMachineController : ApiController
    {
        [HttpGet]
        [Route("api/NumberMachine/{id}")]


        /// <summary>
        /// Receives an integer, operates four mathematical calculations and returns the result.
        /// </summary>
        /// <returns>
        /// Returns the result of the four calculations.
        /// </returns>
        /// <example>
        /// GET: localhost:xx/api/NumberMachine/10 => (10 / 2) + 10 * (10 - 5) = 5 + 10 * 5 = 5 + 50 => 55
        /// </example>
        /// <example>
        /// GET: localhost:xx/api/NumberMachine/-5 => (10 / 2) + (-5) * (10 - 5) = 5 + (-5) * 5 = 5 + (-25) => -20
        /// </example>
        /// <example>
        /// GET: localhost:xx/api/NumberMachine/30 => (10 / 2) + 30 * (10 - 5) = 5 + 30 * 5 = 5 + 150 => 155
        /// </example>
        public int Mathematics(int id)
        {
            int x = 5;
            int y = 10;
            int z = 2;
            int result = (y / z) + id * (y - x);
            return result;

        }
    }
}
