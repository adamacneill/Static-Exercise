using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    internal static class TempConverter
    {
        public static double FarenheitToCelcius(double farTemp)
        {
            // C = (F - 32) * 5 / 9;
            return ( farTemp - 32) * 5 / 9;
        }

        public static double CelciusToFarenheit (double celcTemp)
        {
            return (celcTemp * 9) / 5 + 32;
        }
    }
}
