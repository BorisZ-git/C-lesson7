using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork
{
    /// <summary>
    /// класс обработки кнопок меню
    /// </summary>
    class Action_Menu : fmMain
    {
        /// <summary>
        /// начинает игру
        /// </summary>
        public static void Play()
        {
            Random r = new Random();
            lblValue.Text = (r.Next(50, 100)).ToString();
            lblTurns.Text = "0";
            lblCount.Text = "1";
            //MessageBox.Show(value);
        }
        /// <summary>
        /// сбрасывает ходы и счет
        /// </summary>
        public static void Restart()
        {
            lblTurns.Text = "0";
            lblCount.Text = "1";
        }

    }
}
