using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/* Boris Z
 * Используя Windows Forms, разработать игру “Угадай число”.
 * Компьютер загадывает число от 1 до 100, 
 * а человек пытается его угадать за минимальное число попыток.
 * Для ввода данных от человека используется элемент TextBox.*/

namespace HomeWork2
{
    public partial class fmMain : Form
    {
        public fmMain()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Обработчик для кнопки Make a Number
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNumber_Click(object sender, EventArgs e)
        {
            lblTurn.Text = Number.MaNumber();
        }
        /// <summary>
        /// Обработчик кнопки Answer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnswer_Click(object sender, EventArgs e)
        {
            Number.CheckAnswer(txbAnswer.Text);
            lblTurn.Text = (Convert.ToInt32(lblTurn.Text) + 1).ToString();
        }
    }
}
