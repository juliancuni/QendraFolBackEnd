using System;

namespace BackEnd.Extensions
{
    public static class DateTimeExtensions
    {
        public static int LlogaritMoshen(this DateTime ditelindja) {
            var sot = DateTime.Today;
            var mosha = sot.Year - ditelindja.Year;
            if(ditelindja.Date > sot.AddYears(mosha)) mosha--;
            return mosha;
        }
    }
}