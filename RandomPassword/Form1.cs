using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace RandomPassword
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            NumberSymbols.Text = "0";
        }

        private void NumberSymbols_TextChanged(object sender, EventArgs e)
        {

            if (NumberSymbols.Text.Length == 0)
                Generation.Enabled = false;
            else Generation.Enabled = true;

        }
        
        // команды выполняемые при нажатии кнопки  "Сгенерировать"
        private Random r = new Random();
        private String symbols = "!\"#$%&'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\\]^_`abcdefghijklmnopqrstuvwxyz{|}~";
        private void Generation_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(NumberSymbols.Text);
            if (n < 0 || n > symbols.Length)
            {
                Field.Text = "Ошибка! Нарушен диапазон (минимальное значение 0 максимальное " + symbols.ToString() + ")";
            }
            else
            {
                Field.Clear();
                Field.Text = new string(
                    symbols
                    .ToCharArray()
                    .OrderBy(a => r.Next())
                    .Take(n)
                    .ToArray()
                );
            }
        }

         private void NumberSymbols_KeyPress(object sender, KeyPressEventArgs e)
         {
            {
                char number = e.KeyChar;
                if (!Char.IsDigit(number))
                {
                    e.Handled = true;
                }
            }
        }
    }
}
