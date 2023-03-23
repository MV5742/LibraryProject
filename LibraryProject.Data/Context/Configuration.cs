using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Data.Context
{
    public static class Configuration
    {
        //Handles the Configuration of the Connection String
        public static IConfiguration GetConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            return builder.Build();
        }

        //Is able to return the Connection string anywhere it is needed
        public static string GetConnectionString(string name)
        {
            return GetConfiguration().GetConnectionString(name);
        }
    }
}
