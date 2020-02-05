using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7
{
    public partial class Form1 : Form
    {
        public Form1() { InitializeComponent(); }

        int array_size,list_index;
        Random random_value = new Random();

        int random_array(int size) 
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            array_size = Int32.Parse(textBox1.Text);
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            //listBox1.Items.Add(Convert.ToString(array_size));
            Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            list_index = listBox1.SelectedIndex;
            if (listBox1.SelectedIndex == 0) 
            {
                

            }
            //Написать функцию для случайного массива и для ввода массива вручную
        }


    }

}
