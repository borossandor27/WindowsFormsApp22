using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp22
{
    public partial class Form1 : Form
    {
        string adatfajl = "auto.csv";
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox_Rendszam.Text) || textBox_Rendszam.Text.Length < 6)
            {
                MessageBox.Show("A rendszám nem megfelelő!");
                textBox_Rendszam.Focus();
                return;
            }
            try
            {
                //-- ez a hibamentes működés
                using (StreamWriter sw = new StreamWriter(adatfajl))
                {
                    sw.WriteLine(String.Join(";",
                        textBox_Rendszam.Text,
                        comboBox_Gyartmany.SelectedItem,
                        textBox_Tipus.Text,
                        dateTimePicker_Uzembehelyezés.Value.ToString("yyyy-MM-dd"),
                        comboBox_Szin.SelectedItem, (checkBox_Muszaki.Checked ? "true" : "false")
                        ));
                }
                MessageBox.Show("Az adatok kiírása megtörtént!");
                textBox_Rendszam.Text = "";
                textBox_Tipus.Text = "";
                comboBox_Gyartmany.SelectedIndex = -1;
                comboBox_Szin.SelectedIndex = -1;
            }
            catch (Exception ex)           
            {
                MessageBox.Show(ex.Message);
                //Console.WriteLine("hiba: " + ex.ToString());
            }
 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox_Gyartmany.Items.Add("Ford");
            comboBox_Gyartmany.Items.Add("Toyota");
            comboBox_Gyartmany.Items.Add("VW");
            comboBox_Gyartmany.Items.Add("Suzuki");
            comboBox_Gyartmany.Items.Add("Egyéb");
            comboBox_Szin.Items.Add("Fekete");
            comboBox_Szin.Items.Add("Zöld");
            comboBox_Szin.Items.Add("Fehér");
            comboBox_Szin.Items.Add("Egyéb");
        }

        private void button_Read_Click(object sender, EventArgs e)
        {
            try
            {
                //-- módosítás
                using (StreamReader sr = new StreamReader(adatfajl))
                {
                    string[] adat = sr.ReadLine().Split(';');
                    textBox_Rendszam.Text = adat[0];
                    comboBox_Gyartmany.SelectedValue = adat[1];
                    textBox_Tipus.Text = adat[2];
                    dateTimePicker_Uzembehelyezés.Value = DateTime.Parse(adat[3]);
                    comboBox_Szin.SelectedValue = adat[4];
                    checkBox_Muszaki.Checked = Boolean.Parse(adat[5]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
