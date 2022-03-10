using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QuirkyBookRental.Extensions
{
    public class DateRangeAttribute : RangeAttribute
    {
        public DateRangeAttribute(string mininumValue) : base(typeof(DateTime), mininumValue, DateTime.Now.ToShortDateString())
        {

        }
    }

}