using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ForeignCurrency.Models
{
    public class ResultModel<T>
    {
        public string _Title { get; set; }
        public string _DateTime { get; set; }
        public int _Count { get; set; }
        public List<T> _Result { get; set; }
    }
}