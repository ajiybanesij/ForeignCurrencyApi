using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ForeignCurrency.Models.Source1
{
    public class Type1ListModel
    {
        public string BankName { get; set; }
        public List<Type1Model> CurrencyList { get; set; }
    }
}