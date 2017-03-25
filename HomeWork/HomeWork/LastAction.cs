using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    /// <summary>
    /// класс о последних действиях
    /// </summary>
    class LastAction : fmMain
    {
        static string LastValue;
        public static string LastTurn;
        static string LastCount;
        /// <summary>
        /// сохраняет последнее значение
        /// </summary>
        public static void SaveLast()
        {
            LastCount = lblCount.Text;
            LastTurn = lblTurns.Text;
            LastValue = lblValue.Text;
        }
        /// <summary>
        /// загружает последнее значение
        /// </summary>
        public static void LoadLast()
        {
            lblCount.Text = LastCount;
            lblTurns.Text = LastTurn;
            lblValue.Text = LastValue;
        }
        /// <summary>
        /// сброс последнего значения
        /// </summary>
        public static void Reset()
        {
            Action_btn.forsave = 0;
            LastCount = "1";
            LastTurn = "0";
            LastValue = lblValue.Text;
        }
    }
}
