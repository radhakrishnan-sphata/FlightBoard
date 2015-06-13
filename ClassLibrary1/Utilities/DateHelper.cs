using System;
using System.Globalization;

namespace FlightBoard.Core.Utilities
{
    public static class DateHelper
    {
        public static DateTime ConverStringToDateTimeFormat(string date, string format)
        {
            DateTime dateTime = new DateTime();
            try
            {
                if (date != "")
                    dateTime = DateTime.ParseExact(date, "MM/dd/yyyy", (IFormatProvider)CultureInfo.InvariantCulture);
                return dateTime;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
