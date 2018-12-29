using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kişiler_Listesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Kaydet_Click(object sender, EventArgs e)
        {
            Program2 p = new Program2();

            if (textName.Text != "")
            {
                p.Name = textName.Text;
                p.Surname = textSurname.Text;
                p.Tel = maskedTextTel.Text.ToString();
                p.Email = textEmail.Text;
                p.Adress = textAdress.Text;
                p.City = textCity.Text;
                  
                if ( p.ekle()< 0)
                {

                    MessageBox.Show("Correcly inserted.");

                }
            }
            else
            {

                MessageBox.Show("!Name can not be empty!");
            }

        }

        private void Temizle_Click(object sender, EventArgs e)
        {
            Program2 p = new Program2();

            textName.Text=p.Name;
            textSurname.Text=p.Surname;
            maskedTextTel.Text=p.Tel.ToString();
            textEmail.Text=p.Email;
            textAdress.Text=p.Adress;
            textCity.Text=p.City;

        }
        private void EkranaBas_Click(object sender, EventArgs e)
        {
            List<Program2> liste = new List<Program2>();
            Program2 p = new Program2();
            liste = p.ekranaBas();
            dataGridkisi.DataSource = liste;
            
        }
    }
}
