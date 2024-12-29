using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        ListBox listBox1; // listBox1 sınıf seviyesinde tanımlandı
        Button button1;   // button1 sınıf seviyesinde tanımlandı

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // listBox1 tanımlandı ve özellikleri ayarlandı
            listBox1 = new ListBox();
            listBox1.Location = new Point(200, 40);
            listBox1.Font = new Font("Bradley Hand ITC", 12);
            listBox1.BorderStyle = BorderStyle.Fixed3D;
            listBox1.Sorted = true;
            listBox1.SelectionMode = SelectionMode.MultiSimple;

            // Günler listBox'a eklendi
            listBox1.Items.Add("Sunday");
            listBox1.Items.Add("Monday");
            listBox1.Items.Add("Tuesday");
            listBox1.Items.Add("Wednesday");
            listBox1.Items.Add("Thursday");
            listBox1.Items.Add("Friday");
            listBox1.Items.Add("Saturday");

            this.Controls.Add(listBox1);

            // button1 tanımlandı ve özellikleri ayarlandı
            button1 = new Button();
            button1.Text = "Seçili Günleri Göster";
            button1.Location = new Point(200, 200);
            button1.Click += button1_Click; // button1_Click olayına bağlandı

            this.Controls.Add(button1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Seçilen öğeler tek bir mesaj olarak gösteriliyor
            string selectedItems = "";
            foreach (Object obj in listBox1.SelectedItems)
            {
                selectedItems += obj.ToString() + ", ";
            }

            // Seçili öğeleri içeren mesaj kutusu gösteriliyor
            if (!string.IsNullOrEmpty(selectedItems))
            {
                MessageBox.Show("Seçili Günler: " + selectedItems.TrimEnd(',', ' '));
            }
            else
            {
                MessageBox.Show("Seçili bir gün yok.");
            }
        }
    }
}
