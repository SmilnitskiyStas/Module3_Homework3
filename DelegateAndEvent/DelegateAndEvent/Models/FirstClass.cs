﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DelegateAndEvent.Models
{
    public delegate void FirstDelegate(bool b);

    internal class FirstClass
    {
        public FirstClass()
        {
            // Не працює, (No overload for 'Show' matches delegate 'FirstDelegate'
            FirstDelegate firstDelegate = new Starter().Show;
        }

        /// <summary>
        /// Перемноження вхідних чисел.
        /// </summary>
        /// <param name="x">Перше число.</param>
        /// <param name="y">Друге число.</param>
        /// <returns>Результат множення.</returns>
        public int Pow(int x, int y)
        {
            return x * y;
        }
    }
}
