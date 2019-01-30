using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TesteBackendT4W.Validation
{

    /// <summary>
    /// Validate if a date is greater than or equal to today
    /// </summary>
    public class MyDateAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)// Return a boolean value: true == IsValid, false != IsValid
        {
            DateTime d = Convert.ToDateTime(value);
            return d >= DateTime.Now; //Dates Greater than or equal to today are valid (true)

        }
    }
    
}