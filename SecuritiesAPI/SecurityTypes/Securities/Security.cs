using System;
using System.Collections.Generic;
using System.Text;
using SecuritiesCommon.Exchanges;

namespace SecuritiesCommon.Securities
{
    abstract class Security
    {
        public string Symbol { get; private set; }

        public Exchange Exchange { get; }

        public virtual void Buy() { }

        public virtual void Sell() { }

    }
}