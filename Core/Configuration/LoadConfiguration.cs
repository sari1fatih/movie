using Microsoft.Extensions.Configuration;

namespace Core.Configuration
{
    public class LoadConfiguration
    {
        public static void Run(IConfiguration _conf)
        {
            MyConfiguration.MsSqlConn = _conf.GetConnectionString("MsSqlServer");
        }
    }
}
