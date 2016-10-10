using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace latihan_2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DateTime mulai = new DateTime(2016, 1, 1);
            DateTime akhir = new DateTime(2016, 12, 31);
            while (mulai <= akhir)
            {
                if (mulai.DayOfWeek == DayOfWeek.Saturday)
                {
                    monthCalendar1.AddBoldedDate(mulai);
                    mulai = mulai.AddDays(1);
                    if (mulai != akhir)
                        monthCalendar1.AddBoldedDate(mulai);

                    mulai = mulai.AddDays(5);
                }
                mulai = mulai.AddDays(1);
            }
            blan = new string[] { "januari", "februari", "maret", "april", "mei", "juni", "juli", "agustus", "september", "oktober", "november", "december" };
            tanggalak = new int[] { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

           
             for (int a = 1; a < tanggalak[0]; a++)
            {
                domainUpDown1.Items.Add(a);
            }
            for (int a = 0; a < 12; a++)
                domainUpDown2.Items.Add(blan[a]);
            domainUpDown1.SelectedItem = "1";
            domainUpDown2.SelectedItem = "januari";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int buln = domainUpDown2.SelectedIndex + 1;
            int tgl = domainUpDown1.SelectedIndex + 1;
            monthCalendar1.AddAnnuallyBoldedDate(new DateTime(2016, buln, tgl));
            monthCalendar1.UpdateBoldedDates();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int buln = domainUpDown2.SelectedIndex + 1;
            int tgl = domainUpDown1.SelectedIndex + 1;

            monthCalendar1.RemoveAnnuallyBoldedDate(new DateTime(2016, buln, tgl));
            monthCalendar1.UpdateBoldedDates();


        }
        private int[] tanggalak;
        private string[] blan;
        private void Form1_Load(object sender, EventArgs e)
        {
            

            System.DateTime hitam = new DateTime(2016, 11, 26);
            monthCalendar1.AddAnnuallyBoldedDate(hitam);
            monthCalendar1.UpdateBoldedDates();
           
            monthCalendar1.AddAnnuallyBoldedDate(new DateTime(2016, domainUpDown2.SelectedIndex+1, domainUpDown1.SelectedIndex+1));
            monthCalendar1.UpdateBoldedDates();
        }
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {


        }
        
        private void domainUpDown2_SelectedItemChanged(object sender, EventArgs e)
        {
           
            
        }
    }
}
