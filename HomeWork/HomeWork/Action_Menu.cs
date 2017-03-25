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
            LastAction.Reset();
            LastAction.LoadLast();
            //MessageBox.Show(value);
        }
        /// <summary>
        /// сбрасывает ходы и счет
        /// </summary>
        public static void Restart()
        {
            LastAction.Reset();
            LastAction.LoadLast();
        }
        /// <summary>
        /// отменяет последний ход
        /// </summary>
        /// <param name="last_action">аргумент определяющий было ли действие</param>
        public static void Cancel(string last_action)
        {
            if (last_action == "full")
                LastAction.LoadLast();
        }
        /// <summary>
        /// выводит правила на экран
        /// </summary>
        public static void Rule()
        {
            MessageBox.Show("rule of game", "Rules");
        }

    }
}
