using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace simple_webapi.Controllers
{
	/// <summary>
	/// This is the Values controller class.
	/// </summary>
	/// <remarks>
	/// URL (sans endpoint) is {baseurl}/api.
	/// </remarks>
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
		/// <summary>
		/// Get all values.
		/// </summary>
		/// <returns>IEnumerable string list.</returns>
		/// <example>
		/// Call the endpoint as follows:
		/// <code>
		/// GET {baseurl}/api/values
		/// </code>
		/// </example>
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

		/// <summary>
		/// Get a single value.
		/// </summary>
		/// <param name="id">Value to get.</param>
		/// <returns>A single String value.</returns>
		/// <example>
		/// Call the endpoint as follows:
		/// <code>
		/// GET {baseurl}/api/values/{value_id}
		/// </code>
		/// </example>
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }
    }
}
