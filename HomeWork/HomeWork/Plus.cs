using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    /// <summary>
    /// Класс сложения
    /// </summary>
    class Plus
    {
        /// <summary>
        /// метод сложения
        /// </summary>
        /// <param name="count">текущий счет, как аргумент</param>
        /// <returns>текущий счет + 1</returns>
        public static string Init (string count)
        {
            return count = (1 + Convert.ToInt32(count)).ToString();
        }
    }
}
