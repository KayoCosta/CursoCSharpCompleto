﻿namespace MembrosEstaticosParte2
{
    internal class Calculadora
    {
        public static double Pi = 3.14;

        public static double Circunferencia(double r)
        {
            return r * Pi * 2.0;
        }

        public static double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * r * r * r;
        }
    }

}
