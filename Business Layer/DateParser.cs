using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
    public static class DateParser
    {
        public static DateTime? ParseDate(string dateString)
        {
            DateTime parsedDate;
            if (dateString == "") return null;
            if (DateTime.TryParseExact(dateString, "dd.MM.yyyy.", null, System.Globalization.DateTimeStyles.None, out parsedDate))
            {
                return parsedDate;
            }
            throw new Exception();
        }
    }
}
