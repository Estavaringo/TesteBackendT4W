using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TesteBackendT4W.Validation
{

    //used to serialize the object with a specific date format (Newtonsoft)

    /// <summary>
    /// Converts a DateTime to a specific date format
    /// </summary>
    public class DateFormatConverter : IsoDateTimeConverter
    {
        public DateFormatConverter(string format)
        {
            DateTimeFormat = format;
        }
    }
}