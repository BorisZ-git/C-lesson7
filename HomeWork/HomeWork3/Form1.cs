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
 * * Реализовать программу из предыдущего урока с шаблоном документа на отпуск в Windows
Forms. Сделать несколько текстовых полей(TextBox), куда человек вводит данные, а по нажатии
кнопки “Сделать” ­ видит готовое заявление на отпуск.*/
/* Вопрос: Как оптимизировать передачу данных в другую форму, чтобы не передавать
 * значения по десять раз, как у меня в методах? 
*/

namespace HomeWork3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Обработчик кнопки Do it!
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDoIt_Click(object sender, EventArgs e)
        {
            Form2.fmShow(txbToName.Text,txbToLastName.Text,
                txbFromName.Text,txbFromLastName.Text,
                dtFrom.Text,dtTo.Text,dtTime.Text,txbSign.Text);     
            
        }
    }
}
