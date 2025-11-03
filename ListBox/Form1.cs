using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FruitslistBox.Items.Add(textBox1.Text);

            textBox1.Clear();

            //FruitslistBox.Focus();
            textBox1.Focus();

            /*ChatGPT powiedział:
            W C# metoda Focus() służy do ustawienia fokusu (aktywnego elementu interfejsu)
            na danym kontrolce — czyli sprawia, że to właśnie ten element będzie aktualnie
            „aktywny” i gotowy do interakcji z użytkownikiem 
            (np. do wpisywania tekstu z klawiatury).*/

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int liczba = FruitslistBox.Items.Count;
            //MessageBox.Show("Liczba wynosi :" + liczba);
            MessageBox.Show("Liczba wynosi : " + liczba.ToString());
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FruitslistBox.Sorted = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FruitslistBox.Items.Remove(FruitslistBox.SelectedItem);
        }
    }
}
