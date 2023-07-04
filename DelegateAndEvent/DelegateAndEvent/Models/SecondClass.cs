using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEvent.Models
{
    public delegate bool ResultDelegate(int x);

    public delegate int PowDelegate(int x, int y);

    internal class SecondClass
    {
        private int _result = 0;

        /// <summary>
        /// Метод калькуляції.
        /// </summary>
        /// <param name="powDelegate">Делегат, який викликає метод який перемножає два значення.</param>
        /// <param name="x">Перше значення.</param>
        /// <param name="y">Друге значення.</param>
        /// <returns>Повертає делегат який повертає Boolean значення.</returns>
        public ResultDelegate Calc(PowDelegate powDelegate, int x, int y)
        {
            ResultDelegate resultDelegate = Result;

            _result = powDelegate(x, y);

            resultDelegate(_result);

            return resultDelegate;
        }

        /// <summary>
        /// Перевіряє вхідне значення на залишок від ділення.
        /// </summary>
        /// <param name="x">Число після множення.</param>
        /// <returns>Булівське значення, якщо залишов від ділення 0, то повертає true.</returns>
        private bool Result(int x)
        {
            if (x % 2 == 0)
            {
                return true;
            }

            return false;
        }
    }
}
