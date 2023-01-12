

using System.Reflection;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using READMOREAPI;
using READMOREAPI.Database;
//using READMOREAPI.Services;

[assembly: FunctionsStartup(typeof(READMOREAPI.Startup))]



namespace READMOREAPI

{

    public class Startup : FunctionsStartup

    {

        public override void Configure(IFunctionsHostBuilder builder)
        {
            //builder.Services.AddScoped<IStockService,StockService>(); 
            builder.Services.AddDbContext<AppDbContext>(optionsBuilder =>

            {

                string connString = string.Format("Server={0};Database={1};Port=5432;Username={2};Password={3};SSLMode=Require;Trust Server Certificate=true",
                    GlobalEnv.DBHOST,  GlobalEnv.DBNAME, GlobalEnv.DBUSER, GlobalEnv.DBPASSWORD);


                optionsBuilder
                    // Feature:Logging
                    // .UseLoggerFactory(loggerFactory)
                    .UseNpgsql(connString)
                    .EnableSensitiveDataLogging()
                    .EnableDetailedErrors()
                    .UseSnakeCaseNamingConvention();

            });
              builder.Services.AddAutoMapper(Assembly.GetAssembly(this.GetType()));
        }
    }
}