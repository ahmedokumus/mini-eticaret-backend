using Microsoft.Extensions.Configuration;

namespace Persistence;

static class Configuration
{
    //static public string ConnectionString(string name)
    //{
    //    ConfigurationManager configurationManager = new();
    //    configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/WebAPI"));
    //    configurationManager.AddJsonFile("appsettings.json");

    //    return configurationManager.GetConnectionString(name);
    //}

    static public string ConnectionString
    {
        get
        {
            ConfigurationManager configurationManager = new();
            configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/WebAPI"));
            configurationManager.AddJsonFile("appsettings.json");

            return configurationManager.GetConnectionString("SqlServer");
        }
    }
}