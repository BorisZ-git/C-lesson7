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
        /// <summary>
        /// обработчик вкладки Play
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Action_Menu.Play();
        }
        /// <summary>
        /// обработчик вкладки Restart
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiRestart_Click(object sender, EventArgs e)
        {
            Action_Menu.Restart();
        }


        /// <summary>
        /// обработчик кнопки +1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPlus_Click(object sender, EventArgs e)
        {
            Action_btn.Plus();
        }
        /// <summary>
        /// обработчик кнопки *2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMult_Click(object sender, EventArgs e)
        {
            Action_btn.Multi();
        }
        /// <summary>
        /// обработчик кнопки Reset
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            Action_btn.Reset();
        }
        /// <summary>
        /// обработчик вкладки Exit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// обработчик вкладки Cancel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiCancelLastMove_Click(object sender, EventArgs e)
        {
            Action_Menu.Cancel(lblLast_Action.Text);
        }
        /// <summary>
        /// обработчик вкладки Rule
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ruleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Action_Menu.Rule();
        }
    }
}
