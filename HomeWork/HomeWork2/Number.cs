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
        public static void MaNumber()
        {
            Random r = new Random();
            num = r.Next(0,100);
            MessageBox.Show("компьютер загадал число");
        }
        public static void CheckAnswer(string UserAnswer)
        {
            int usernum = 0;
            try
            {
                usernum =  Convert.ToInt32(UserAnswer);
            }
            catch
            {
                MessageBox.Show("нужно ввести число");
            }
            if (usernum == num)
                MessageBox.Show("Продолжить или выйти", "победа", MessageBoxButtons.YesNo);
            else if (usernum > num)
                MessageBox.Show("перебор");
            else if (usernum < num)
                MessageBox.Show("недобор");
        }
    }
}
