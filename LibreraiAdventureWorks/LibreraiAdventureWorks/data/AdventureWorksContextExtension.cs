using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorksNS.Data
{
    public static class AdventureWorksContextExtension
    {
        public static IServiceCollection AdventureWorksDBContext(
            this IServiceCollection services, 
            string strCnx = "Data Source=DESKTOP-K0P85KI;Initial Catalog=AdventureWorksLT2017;Integrated Security=false;User=usuario1;Password=1234;")
        {
            services.AddDbContext<AdventureWorksDB>(options => options.UseSqlServer(strCnx));
            return services;
        }
    }
}
