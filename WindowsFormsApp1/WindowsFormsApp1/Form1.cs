using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        ComboBox comboBox1; // comboBox1 sınıf seviyesinde tanımlandı

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // comboBox1 tanımlandı ve özellikleri ayarlandı
            comboBox1 = new ComboBox();
            comboBox1.Location = new Point(100, 40);
            comboBox1.Items.Add("weekdays");
            comboBox1.Items.Add("year");
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged; // Event ekleniyor
            Controls.Add(comboBox1);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // comboBox2 oluşturuluyor ve seçenekler ayarlanıyor
            ComboBox comboBox2 = new ComboBox();
            comboBox2.Location = new Point(300, 40);
            comboBox2.Items.Clear();
            if (comboBox1.SelectedItem.Equals("weekdays"))
            {
                comboBox2.Items.Add("Sunday");
                comboBox2.Items.Add("Monday");
                comboBox2.Items.Add("Tuesday");
            }
            else if (comboBox1.SelectedItem.Equals("year"))
            {
                comboBox2.Items.Add("2012");
                comboBox2.Items.Add("2013");
                comboBox2.Items.Add("2014");
            }

            Controls.Add(comboBox2); // comboBox2 formda gösteriliyor
        }
    }
}
