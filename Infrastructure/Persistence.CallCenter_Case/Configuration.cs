using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.CallCenter_Case
{
    public static class Configuration
    {
        static public string ConnectionString
        {
            get
            {
                
                ConfigurationManager configurationManager = new();
                //microsoft.extensions.configuration.json ekle
                configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/CallCenter_Case.API"));
                configurationManager.AddJsonFile("appsettings.json");
                return configurationManager.GetConnectionString("SqlServer");
            }
        }
    }
}
