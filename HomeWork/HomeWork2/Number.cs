using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork2
{
    class Number
    {
        public static int num;
        /// <summary>
        /// метод загадывающий число и начинающий игру
        /// </summary>
        /// <returns>возвращает параметр Turn = 0</returns>
        public static string MaNumber()
        {
            Random r = new Random();
            num = r.Next(0,100);
            MessageBox.Show("компьютер загадал число");
            return "0";
        }
        /// <summary>
        /// метод сравнивающий введеное число с загаданным
        /// </summary>
        /// <param name="UserAnswer">введенное число юзером</param>
        public static void CheckAnswer(string UserAnswer)
        {
            int usernum = 0;
            DialogResult result = DialogResult.No;
            try
            {
                usernum =  Convert.ToInt32(UserAnswer);
            }
            catch
            {
                MessageBox.Show("нужно ввести число");
                return;
            }
            if (usernum == num)
            {
                result = MessageBox.Show("Играть заново?", "победа", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                    MaNumber();
                else if (result == DialogResult.No)
                    Environment.Exit(0);
            }
            else if (usernum > num)
                MessageBox.Show("перебор");
            else if (usernum < num)
                MessageBox.Show("недобор");
        }
    }
}
