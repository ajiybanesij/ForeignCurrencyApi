using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ForeignCurrency.Models
{
    public class Source1ListModel
    {
        public string BankName { get; set; }
        public List<Source1Model> CurrencyList { get; set; }
    }
}