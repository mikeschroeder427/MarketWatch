using System;
using SecuritiesCommon;
using System.Configuration;

namespace SecuritiesDAL {

    class Program
    {
        static void Main(string[] args) {

            var appSettings = ConfigurationManager.ConnectionStrings["MarketWatch"].ConnectionString;

            using (var db = new Models.ExchangeContext()) {

                db.Exchange.Add(new SecuritiesCommon.Exchanges.Exchange
                {
                });               
                var count = db.SaveChanges();

            }
        }
    }
}
