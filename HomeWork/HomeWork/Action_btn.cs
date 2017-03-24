using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    /// <summary>
    /// класс обработчик кнопок
    /// </summary>
    class Action_btn : fmMain
    {
        /// <summary>
        /// метод сложения
        /// </summary>
        public static void Plus ()
        {
            lblTurns.Text = (1 + Convert.ToInt32(lblTurns.Text)).ToString();
            lblCount.Text = (1 + Convert.ToInt32(lblCount.Text)).ToString();
        }
        /// <summary>
        /// метод умножения
        /// </summary>
        public static void Multi()
        {
            lblTurns.Text = (1 + Convert.ToInt32(lblTurns.Text)).ToString();
            lblCount.Text = (Convert.ToInt32(lblCount.Text) * 2).ToString();
        }
        /// <summary>
        ///  метод сброса
        /// </summary>
        public static void Reset()
        {
            lblTurns.Text = (1 + Convert.ToInt32(lblTurns.Text)).ToString();
            lblCount.Text = "1";
        }

    }
}
