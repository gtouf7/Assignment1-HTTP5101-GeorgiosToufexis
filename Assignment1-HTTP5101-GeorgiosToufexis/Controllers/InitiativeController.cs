using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_HTTP5101_GeorgiosToufexis.Controllers
{
    public class InitiativeController : ApiController
    {

        /// <summary>
        ///     We are using the GET method to input a number of days.
        ///     Depending on the days provided the output will be three strings explaining the cost.
        ///     We will be using the IF statement to specify the final cost.
        /// </summary>
        /// <param name="days"></param>
        /// <returns>
        ///     The code will be returning three strings explaining the final cost.
        ///     The IF will be checking how many days passed from the start of the first fortnight charge.
        ///     0-14 days = 1 fortnight charged.
        ///     15-27 days = 2 fortnights charged.
        ///     28+ days = 3 fortnights charged. (we could check for input validation or charge more, but was not asked in this question :) )
        /// </returns>
        /// <example>
        ///     GET: localhost:xx/api/Initiative/HostingCost/0 =>
        ///     "1 fortnights at $5.50/FN = $5.50CAD"
        ///     "HST 13% = $0.72CAD"
        ///     "Total = $6.22CAD"
        /// </example>
        /// <example>
        ///     GET: localhost:xx/api/Initiative/HostingCost/14
        ///     "2 fortnights at $5.50/FN = $11.00CAD"
        ///     "HST 13% = $1.43CAD"
        ///     "Total = $12.43CAD"
        /// </example>
        /// <example>
        ///     GET: localhost:xx/api/Initiative/HostingCost/15
        ///     "2 fortnights at $5.50/FN = $11.00CAD"
        ///     "HST 13% = $1.43CAD"
        ///     "Total = $12.43CAD"
        /// </example>
        /// <example>
        ///     GET: localhost:xx/api/Initiative/HostingCost/21
        ///     "2 fortnights at $5.50/FN = $11.00CAD"
        ///     "HST 13% = $1.43CAD"
        ///     "Total = $12.43CAD"
        /// </example>
        /// <example>
        ///     GET: localhost:xx/api/Initiative/HostingCost/28
        ///     "3 fortnights at $5.50/FN = $16.50CAD"
        ///     "HST 13% = $2.14CAD"
        ///     "Total = $18.64CAD"
        /// </example>
        [HttpGet]
        [Route("api/Initiative/HostingCost/{days}")]
        public (string, string, string) HostingCost(int days)
        {
            if (days <= 13)
            {
                string fortnightCost = "1 fortnights at $5.50/FN = $5.50CAD";
                string tax = "HST 13% = $0.72CAD";
                string totalCost = "Total = $6.22CAD";
                return (fortnightCost, tax, totalCost);
               
            } else if (days >= 14 && days <= 27)
            {
                string fortnightCost = "2 fortnights at $5.50/FN = $11.00CAD";
                string tax = "HST 13% = $1.43CAD";
                string totalCost = "Total = $12.43CAD";
                return (fortnightCost, tax, totalCost);

            } else
            {
                string fortnightCost = "3 fortnights at $5.50/FN = $16.50CAD";
                string tax = "HST 13% = $2.14CAD";
                string totalCost = "Total = $18.64CAD";
                return (fortnightCost, tax, totalCost);
            }
            
           
        }
    }
}
