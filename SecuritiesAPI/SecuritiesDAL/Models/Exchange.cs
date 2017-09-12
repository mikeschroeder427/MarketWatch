using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Configuration;

namespace SecuritiesDAL.Models
{
    class ExchangeContext : DbContext
    {
        public DbSet<SecuritiesCommon.Exchanges.Exchange> Exchange { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            Console.WriteLine(ConfigurationManager.ConnectionStrings["MarketWatch"].ConnectionString);

            //optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["MarketWatch"].ConnectionString);
            optionsBuilder.UseSqlServer(@"Server = (localdb)\v11.0; Database = EFCore.MarketWatch; Trusted_Connection = True;");
            
        }



    }


}
