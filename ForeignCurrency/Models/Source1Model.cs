using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ForeignCurrency.Models
{
    public class Source1Model
    {
        public string Name { get; set; }
        public string Buyin { get; set; }
        public string Sales { get; set; }
        public string Change { get; set; }
        public string ChangeUpDown { get; set; }
        public string  UpdateTime { get; set; }
    }
}