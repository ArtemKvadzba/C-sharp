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
        int[] array;

        void Random_array()
        {
            for (int counter = 0; counter < array_size; counter++)
            {
                 array[counter] = random_value.Next(-100, 100);
                 textBox2.Text += array[counter] + " ";
            }
            
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text == "") array_size = Int32.Parse("0");
            else
            { 
               array_size = Int32.Parse(textBox1.Text);
               array = new int[array_size];
            }
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
                textBox2.Clear();
                Random_array();
                textBox2.ReadOnly = true;
            }
            else
            {     
                textBox2.ReadOnly = false;
                textBox2.Clear();

            }
            
            //Написать функцию для случайного массива и для ввода массива вручную
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 5) //(int)Keys.Space) 
            {
                textBox2.Clear();
            }
                
        }


    }

}
