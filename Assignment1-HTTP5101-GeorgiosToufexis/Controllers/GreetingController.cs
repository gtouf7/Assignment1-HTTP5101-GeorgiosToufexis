using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_HTTP5101_GeorgiosToufexis.Controllers
{
    public class GreetingController : ApiController
    {
        /// <summary>
        /// Receives a POST request string and returns it using the command prompt.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>
        /// The string is shown on the command prompt.
        /// </returns>
        /// <example>
        /// POST: curl -d "" localhost:xx/api/Greeting => "Hello World!"
        /// </example>
        public string Post()
        {
            return "Hello World!";
        }



        /// <summary>
        /// Receives an integer value and then returns a string greeting.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>
        /// A string greeting of (number) of people where (number) is an integer.
        /// </returns>
        /// <example>
        /// GET: localhost:xx/api/Greeting/3 => "Greetings to 3 people!"
        /// </example>
        /// <example>
        /// GET: localhost:xx/api/Greeting/6 => "Greetings to 6 people!"
        /// </example>
        /// <example>
        /// GET: localhost:xx/api/Greeting/0 => "Greetings to 0 people!"
        /// </example>
        public string Get(int id)
        {
            return "Greetings to " + id + " people!";
        }
    }

       
}