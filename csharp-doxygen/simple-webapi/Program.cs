using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace simple_webapi
{
	public class Program
	{
		/// <summary>
		/// This is the program entry point.
		/// </summary>
		/// <param name="args"></param>
		/// <remarks>
		/// Call the method <see cref="CreateWebHostBuilder"/> to initialize and run the web host from here.
		/// </remarks>
		public static void Main(string[] args)
		{
			CreateWebHostBuilder(args).Build().Run();
		}

		/// <summary>
		/// Start up an instance of the web host.
		/// </summary>
		/// <param name="args"></param>
		/// <returns></returns>
		public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
			WebHost.CreateDefaultBuilder(args)
				.UseStartup<Startup>();
	}
}
