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
а) Добавить в программу “Удвоитель” подсчет количества отданных команд удвоителю.
б) Добавить меню и команду “Играть”. При нажатии появляется сообщение, какое число должен
получить игрок. Игрок должен постараться получить это число за минимальное количество
ходов.
в) * Добавить кнопку “Отменить”, которая отменяет последний ход.*/

namespace HomeWork
{
    public partial class fmMain : Form
    {
        public fmMain()
        {
            InitializeComponent();
        }

        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        /// <summary>
        /// Обработчик кнопки +1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPlus_Click(object sender, EventArgs e)
        {
            lblCount.Text = Action_btn.Plus(lblCount.Text);
        }
        /// <summary>
        /// Обработчик кнопки *2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMult_Click(object sender, EventArgs e)
        {
            lblCount.Text = Action_btn.Multi(lblCount.Text);
        }
    }
}
