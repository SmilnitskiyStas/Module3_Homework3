using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DelegateAndEvent.Models;

namespace DelegateAndEvent
{
    internal class Starter
    {
        public void Run()
        {
            FirstDelegate firstDelegate = Show;

            PowDelegate powDelegate = new FirstClass().Pow;

            ResultDelegate resultDelegate = new SecondClass().Calc(powDelegate, 2, 5);

            firstDelegate(resultDelegate);
        }

        /// <summary>
        /// Виводить результат роботи методу Result.
        /// </summary>
        /// <param name="resultDelegate">Делегат який викликає метод Result.</param>
        public void Show(ResultDelegate resultDelegate)
        {
            Console.WriteLine($"Result - {resultDelegate.Method.ReturnParameter}");
        }
    }
}
