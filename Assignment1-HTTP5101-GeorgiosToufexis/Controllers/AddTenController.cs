using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_HTTP5101_GeorgiosToufexis.Controllers
{
    public class AddTenController : ApiController
    {


        /// <summary>
        /// Receives an input number and returns it increased by 10.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>
        /// The number increased by 10.
        /// </returns>
        /// <example>
        /// GET: localhost:xx/api/AddTen/21 => 31
        /// </example>
        /// /// <example>
        /// GET: localhost:xx/api/AddTen/0 => 10
        /// </example>
        /// /// <example>
        /// GET: localhost:xx/api/AddTen/-9 => 1
        /// </example>
        public int Get(int id)
        {
            int result = id + 10;
            return result;
        }
    }
}
