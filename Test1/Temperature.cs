using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test1
{
    public class Temperature
    {
        private double ftemp;

        public Temperature()
        {
            ftemp = 0;
        }

        public Temperature(double f)
        {
            ftemp = f;
        }

        public void setFahrenheit(double f)
        {
            ftemp = f;
        }

        public double getFahrenheit()
        {
            return ftemp;
        }

        public double getCelsius()
        {
            return (5.0 / 9.0) * (ftemp - 32);
        }

        public double getKelvin()
        {
            return (5.0 / 9.0) * (ftemp - 32) + 273;
        }

        public override string ToString()
        {
            return "Fahrenheit: " + ftemp + " Celsius: " + getCelsius() + " Kelvin: " + getKelvin();
        }
    }
}