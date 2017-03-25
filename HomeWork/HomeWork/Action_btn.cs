using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork
{
    /// <summary>
    /// класс обработчик кнопок
    /// </summary>
    class Action_btn : fmMain
    {
        public static int forsave = 0;
        /// <summary>
        /// метод сложения
        /// </summary>
        public static void Plus ()
        {
            if (Convert.ToInt32(lblTurns.Text) > forsave)
            {
                lblLast_Action.Text = "full";
                forsave++;
                LastAction.SaveLast();
            }
            lblTurns.Text = (1 + Convert.ToInt32(lblTurns.Text)).ToString();
            lblCount.Text = (1 + Convert.ToInt32(lblCount.Text)).ToString();

            if (lblCount.Text == lblValue.Text)
            {
                MessageBox.Show($"победа в {lblTurns.Text} шагов", "Победа");
                Action_Menu.Play();
            }
            else if (Convert.ToInt32(lblValue.Text) < Convert.ToInt32(lblCount.Text))
            {
                MessageBox.Show($"=(", "Перебор");
                Action_Menu.Restart();
            }

        }
        /// <summary>
        /// метод умножения
        /// </summary>
        public static void Multi()
        {
            if (Convert.ToInt32(lblTurns.Text) > forsave)
            {
                lblLast_Action.Text = "full";
                forsave++;
                LastAction.SaveLast();
            }
            lblTurns.Text = (1 + Convert.ToInt32(lblTurns.Text)).ToString();
            lblCount.Text = (Convert.ToInt32(lblCount.Text) * 2).ToString();
            if (lblCount.Text == lblValue.Text)
            {
                MessageBox.Show($"победа в {lblTurns.Text} шагов", "Победа");
                Action_Menu.Play();
            }
            else if (Convert.ToInt32(lblValue.Text) < Convert.ToInt32(lblCount.Text))
            {
                MessageBox.Show($"=(", "Перебор");
                Action_Menu.Restart();
            }

        }
        /// <summary>
        ///  метод сброса
        /// </summary>
        public static void Reset()
        {
            if (Convert.ToInt32(lblTurns.Text) > forsave)
            {
                lblLast_Action.Text = "full";
                forsave++;
                LastAction.SaveLast();
            }
            lblTurns.Text = (1 + Convert.ToInt32(lblTurns.Text)).ToString();
            lblCount.Text = "1";
            if (lblCount.Text == lblValue.Text)
            {
                MessageBox.Show($"победа в {lblTurns.Text} шагов", "Победа");
                Action_Menu.Play();
            }
            else if (Convert.ToInt32(lblValue.Text) < Convert.ToInt32(lblCount.Text))
            {
                MessageBox.Show($"=(", "Перебор");
                Action_Menu.Restart();
            }
        }

    }
}
