using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork3
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Открывает форму
        /// </summary>
        /// <param name="ToName">ОтИмя</param>
        /// <param name="ToLastName">ОтФамилия</param>
        /// <param name="FromName">КомуИмя</param>
        /// <param name="FromLastName">КомуФамилия</param>
        /// <param name="dtFrom">СКакого</param>
        /// <param name="dtTo">ПоКакое</param>
        /// <param name="dtTime">Дата</param>
        /// <param name="Sign">Роспись</param>
        public static void fmShow(string ToName, string ToLastName,
            string FromName, string FromLastName, string dtFrom, string dtTo,
            string dtTime, string Sign)
        {
            Form2 fm2 = new Form2();            
            fm2.fmFull(ToName, ToLastName, FromName, FromLastName,
                dtFrom, dtTo, dtTime, Sign);
            fm2.ShowDialog();
            
        }
        /// <summary>
        /// заполняет значения в форме
        /// </summary>
        /// <param name="ToName">ОтИмя</param>
        /// <param name="ToLastName">ОтФамилия</param>
        /// <param name="FromName">КомуИмя</param>
        /// <param name="FromLastName">КомуФамилия</param>
        /// <param name="dtFrom">СКакого</param>
        /// <param name="dtTo">ПоКакое</param>
        /// <param name="dtTime">Дата</param>
        /// <param name="Sign">Роспись</param>
        private void fmFull(string ToName, string ToLastName,
            string FromName, string FromLastName, string dtFrom, string dtTo,
            string dtTime, string Sign)
        {
            lblToName.Text = ToName;
            lblToLastName.Text = ToLastName;
            lblFromName.Text = FromName;
            lblFromLastName.Text = FromLastName;

            lblSign.Text = Sign;
            lblNowData.Text = dtTime;

            lblFromData.Text = dtFrom;
            lblToData.Text = dtTo;
                   
        }

    }
}
