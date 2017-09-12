using System;
using System.Collections.Generic;
using System.Text;

namespace SecuritiesCommon.Exchanges
{
    public class Exchange
    {
        public int Id { get; set; }

        public int ExchangeID { get; set; }

        public string Name { get; set; }

        public string Description { get; private set; }

        public string Economy { get; private set; } 

        public string Location { get; private set; }

        public Double MarketCap { get; private set; }

        //public TimeZoneInfo Timezone { get; private set; }

        /// <summary>
        /// Returns UTC DateTime when exchange opens
        /// </summary>
        public DateTime Open { get; private set; }
        /// <summary>
        /// Returns UTC DateTime when exchange closes
        /// </summary>
        public DateTime Close { get; private set; }



    }
}
