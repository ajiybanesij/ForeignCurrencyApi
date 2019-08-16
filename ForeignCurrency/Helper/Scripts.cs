using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ForeignCurrency.Helper
{
    public class Scripts
    {
        public string NameControl(string name)
        {
            return name
                .Replace("ÅŸ", "ş")
                .Replace("Ä±", "i")
                .Replace("Ä°", "İ")
                .Replace("Ã§", "ç")
                .Replace("Ã¼", "ü")
                .Replace("Åž", "Ş")
                .Replace("Ãœ", "Ü")
                .Replace("Ã‡", "Ç")
                .Replace("â‚º", "₺")
                .Replace("ÄŸ", "ğ")    
                .Replace("Ã–", "Ö")    
                .Replace("Dolari", "Doları")
                .Replace("Randi", "Randı")
                .Replace("Dinari", "Dinarı")
                .Replace("Korunasi", "Korunası")
                .Replace("Yuani", "Yuanı")
                .Replace("Manati", "Manatı")
                .Replace("Marki", "Markı")
                .Replace("Lirasi", "Lirası")
                .Replace("Kunasi", "Kunası")
                .Replace("Kronasi", "Kronası")
                .Replace("Grivnasi", "Grivnası")
                .Replace("Frangi", "Frangı")
                .Replace("Hirvat", "Hırvat")
                .Replace("Sirbistan", "Sırbistan")
                .Replace("Misir", "Mısır")
                .Replace("Altini", "Altını")
                .Replace("Altin", "Altın")
                .Replace("irlik", "ırlık")
                .Replace("Bazli", "Bazlı")
                .Replace("Sinirlamali", "Sınırlamalı")
                ;
        }

        public List<string> BankNames()
        {
            List<string> bankNamesList = new List<string>
            {
                "akbank",
                "denizbank",
                "qnb-finansbank",
                "hsbc",
                "isbankasi",
                "merkez-bankasi",
                "sekerbank",
                "vakifbank",
                "yapikredi"
            };

            return bankNamesList.ToList();
        }
    }
}