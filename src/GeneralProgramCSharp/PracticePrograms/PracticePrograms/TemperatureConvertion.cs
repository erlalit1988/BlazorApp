using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms
{
    public class TemperatureConvertion
    {
        // celsius to fahrenheit ft=ct*9/5+32
        public double CelesiusToFahrenheit(string celsiusTemp)
        {
            double celsius = double.Parse(celsiusTemp);
            double fahrenheit = (celsius * 9 / 5) + 32;
            return fahrenheit;
        }
        //fahrenheit to celsius ct=(ft-32)*5/9
        public double FahrenheitToCelesius(string FahrenheitTemp)
        {
            double fahrenheit = double.Parse(FahrenheitTemp);
            double celcius = (fahrenheit - 32)*5/9;
            return celcius;
        }
    }
}
