using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_HTTP5101_GeorgiosToufexis.Controllers
{


    public class SquareController : ApiController
    {
        /// <summary>
        /// Receives an input number (either positive or negative) and returns its square.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>
        /// The number squared.
        /// </returns>
        /// <example>
        /// GET: localhost:xx/api/Square/2 => 4
        /// </example>
        /// /// <example>
        /// GET: localhost:xx/api/Square/-2 => 4
        /// </example>
        /// /// <example>
        /// GET: localhost:xx/api/Square/10 => 100
        /// </example>
        public int Get(int id)
        {
            int result = id * id;
            return result;
        }
    }
}
