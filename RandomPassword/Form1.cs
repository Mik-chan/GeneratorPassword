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
        private void Generation_Click(object sender, EventArgs e)
        {

            int n = Convert.ToInt32(NumberSymbols.Text);
            if (Convert.ToInt32(NumberSymbols.Text) > 60)
            {
                Field.Text = "Ошибка! Нарушен диапазон (минимальное значение 0 максимальное 60)";
            }
            else
            {
                {

                    char[] myarr = {'`', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '-', '=', 'q', 'w',
                'r', 't', 'y', 'u','i','o','p','[',']','a','s','d','f','g','h','j','k','l',';','z',
               '"' ,'x','c','v','b','n','m',',','.','/',':', '+', '*', '?', '<', '>', '!', '@', '#', '$',
            '%', '^', '&', '(', ')'}; // массив элементов пароля


                    Random rnd = new Random();
                    if (n == 60)
                    {
                        Field.Clear();
                        for (int i = myarr.Length - 1; i >= 0; i--)
                        {
                            int j = rnd.Next(i);

                            char tmp = myarr[j];
                            myarr[j] = myarr[i];
                            myarr[i] = tmp;
                            
                            Field.Text += tmp.ToString();
                        }
                    }
                    if (n == 59)
                    {
                        Field.Clear();
                        for (int i = myarr.Length - 2; i >= 0; i--)
                        {
                            int j = rnd.Next(i);

                            char tmp = myarr[j];
                            myarr[j] = myarr[i];
                            myarr[i] = tmp;

                            Field.Text += tmp.ToString();
                        }
                    }
                    if (n == 58)
                    {
                        Field.Clear();
                        for (int i = myarr.Length - 3; i >= 0; i--)
                        {
                            int j = rnd.Next(i);

                            char tmp = myarr[j];
                            myarr[j] = myarr[i];
                            myarr[i] = tmp;

                            Field.Text += tmp.ToString();
                        }
                    }
                    if (n == 57)
                    {
                        Field.Clear();
                        for (int i = myarr.Length - 4; i >= 0; i--)
                        {
                            int j = rnd.Next(i);

                            char tmp = myarr[j];
                            myarr[j] = myarr[i];
                            myarr[i] = tmp;

                            Field.Text += tmp.ToString();
                        }
                    }
                    if (n == 56)
                    {
                        Field.Clear();
                        for (int i = myarr.Length - 5; i >= 0; i--)
                        {
                            int j = rnd.Next(i);

                            char tmp = myarr[j];
                            myarr[j] = myarr[i];
                            myarr[i] = tmp;

                            Field.Text += tmp.ToString();
                        }
                    }
                    if (n == 55)
                    {
                        Field.Clear();
                        for (int i = myarr.Length - 6; i >= 0; i--)
                        {
                            int j = rnd.Next(i);

                            char tmp = myarr[j];
                            myarr[j] = myarr[i];
                            myarr[i] = tmp;

                            Field.Text += tmp.ToString();
                        }
                    }
                    if (n == 54)
                    {
                        Field.Clear();
                        for (int i = myarr.Length - 7; i >= 0; i--)
                        {
                            int j = rnd.Next(i);

                            char tmp = myarr[j];
                            myarr[j] = myarr[i];
                            myarr[i] = tmp;

                            Field.Text += tmp.ToString();
                        }
                    }
                    if (n == 53)
                    {
                        Field.Clear();
                        for (int i = myarr.Length - 8; i >= 0; i--)
                        {
                            int j = rnd.Next(i);

                            char tmp = myarr[j];
                            myarr[j] = myarr[i];
                            myarr[i] = tmp;

                            Field.Text += tmp.ToString();
                        }
                    }
                    if (n == 52)
                    {
                        Field.Clear();
                        for (int i = myarr.Length - 9; i >= 0; i--)
                        {
                            int j = rnd.Next(i);

                            char tmp = myarr[j];
                            myarr[j] = myarr[i];
                            myarr[i] = tmp;

                            Field.Text += tmp.ToString();
                        }
                    }
                    if (n == 51)
                    {
                        Field.Clear();
                        for (int i = myarr.Length - 10; i >= 0; i--)
                        {
                            int j = rnd.Next(i);

                            char tmp = myarr[j];
                            myarr[j] = myarr[i];
                            myarr[i] = tmp;

                            Field.Text += tmp.ToString();
                        }
                    }
                    if (n == 50)
                    {
                        Field.Clear();
                        for (int i = myarr.Length - 11; i >= 0; i--)
                        {
                            int j = rnd.Next(i);

                            char tmp = myarr[j];
                            myarr[j] = myarr[i];
                            myarr[i] = tmp;

                            Field.Text += tmp.ToString();
                        }
                    }
                    if (n == 49)
                    {
                        Field.Clear();
                        for (int i = myarr.Length - 12; i >= 0; i--)
                        {
                            int j = rnd.Next(i);

                            char tmp = myarr[j];
                            myarr[j] = myarr[i];
                            myarr[i] = tmp;

                            Field.Text += tmp.ToString();
                        }
                    }
                    if (n == 48)
                    {
                        Field.Clear();
                        for (int i = myarr.Length - 13; i >= 0; i--)
                        {
                            int j = rnd.Next(i);

                            char tmp = myarr[j];
                            myarr[j] = myarr[i];
                            myarr[i] = tmp;

                            Field.Text += tmp.ToString();
                        }
                    }
                    if (n == 47)
                    {
                        Field.Clear();
                        for (int i = myarr.Length - 14; i >= 0; i--)
                        {
                            int j = rnd.Next(i);

                            char tmp = myarr[j];
                            myarr[j] = myarr[i];
                            myarr[i] = tmp;

                            Field.Text += tmp.ToString();
                        }
                    }
                    if (n == 46)
                    {
                        Field.Clear();
                        for (int i = myarr.Length - 15; i >= 0; i--)
                        {
                            int j = rnd.Next(i);

                            char tmp = myarr[j];
                            myarr[j] = myarr[i];
                            myarr[i] = tmp;

                            Field.Text += tmp.ToString();
                        }
                    }
                    if (n == 45)
                    {
                        Field.Clear();
                        for (int i = myarr.Length - 16; i >= 0; i--)
                        {
                            int j = rnd.Next(i);

                            char tmp = myarr[j];
                            myarr[j] = myarr[i];
                            myarr[i] = tmp;

                            Field.Text += tmp.ToString();
                        }
                    }
                    if (n == 44)
                    {
                        Field.Clear();
                        for (int i = myarr.Length - 17; i >= 0; i--)
                        {
                            int j = rnd.Next(i);

                            char tmp = myarr[j];
                            myarr[j] = myarr[i];
                            myarr[i] = tmp;

                            Field.Text += tmp.ToString();
                        }
                    }
                    if (n == 43)
                    {
                        Field.Clear();
                        for (int i = myarr.Length - 18; i >= 0; i--)
                        {
                            int j = rnd.Next(i);

                            char tmp = myarr[j];
                            myarr[j] = myarr[i];
                            myarr[i] = tmp;

                            Field.Text += tmp.ToString();
                        }
                    }
                    if (n == 42)
                    {
                        Field.Clear();
                        for (int i = myarr.Length - 19; i >= 0; i--)
                        {
                            int j = rnd.Next(i);

                            char tmp = myarr[j];
                            myarr[j] = myarr[i];
                            myarr[i] = tmp;

                            Field.Text += tmp.ToString();
                        }
                    }
                    if (n == 41)
                    {
                        Field.Clear();
                        for (int i = myarr.Length - 20; i >= 0; i--)
                        {
                            int j = rnd.Next(i);

                            char tmp = myarr[j];
                            myarr[j] = myarr[i];
                            myarr[i] = tmp;

                            Field.Text += tmp.ToString();
                        }
                    }
                    if (n == 40)
                    {
                        Field.Clear();
                        for (int i = myarr.Length - 21; i >= 0; i--)
                        {
                            int j = rnd.Next(i);

                            char tmp = myarr[j];
                            myarr[j] = myarr[i];
                            myarr[i] = tmp;

                            Field.Text += tmp.ToString();
                        }
                    }
                    if (n == 39)
                    {
                        Field.Clear();
                        for (int i = myarr.Length - 22; i >= 0; i--)
                        {
                            int j = rnd.Next(i);

                            char tmp = myarr[j];
                            myarr[j] = myarr[i];
                            myarr[i] = tmp;

                            Field.Text += tmp.ToString();
                        }
                    }
                    if (n == 38)
                    {
                        Field.Clear();
                        for (int i = myarr.Length - 23; i >= 0; i--)
                        {
                            int j = rnd.Next(i);

                            char tmp = myarr[j];
                            myarr[j] = myarr[i];
                            myarr[i] = tmp;

                            Field.Text += tmp.ToString();
                        }
                    }
                    if (n == 37)
                    {
                        Field.Clear();
                        for (int i = myarr.Length - 24; i >= 0; i--)
                        {
                            int j = rnd.Next(i);

                            char tmp = myarr[j];
                            myarr[j] = myarr[i];
                            myarr[i] = tmp;

                            Field.Text += tmp.ToString();
                        }
                    }
                    if (n == 36)
                    {
                        Field.Clear();
                        for (int i = myarr.Length - 25; i >= 0; i--)
                        {
                            int j = rnd.Next(i);

                            char tmp = myarr[j];
                            myarr[j] = myarr[i];
                            myarr[i] = tmp;

                            Field.Text += tmp.ToString();
                        }
                    }
                    if (n == 35)
                    {
                        Field.Clear();
                        for (int i = myarr.Length - 26; i >= 0; i--)
                        {
                            int j = rnd.Next(i);

                            char tmp = myarr[j];
                            myarr[j] = myarr[i];
                            myarr[i] = tmp;

                            Field.Text += tmp.ToString();
                        }
                    }
                    if (n == 34)
                    {
                        Field.Clear();
                        for (int i = myarr.Length - 27; i >= 0; i--)
                        {
                            int j = rnd.Next(i);

                            char tmp = myarr[j];
                            myarr[j] = myarr[i];
                            myarr[i] = tmp;

                            Field.Text += tmp.ToString();
                        }
                    }
                    if (n == 33)
                    {
                        Field.Clear();
                        for (int i = myarr.Length - 28; i >= 0; i--)
                        {
                            int j = rnd.Next(i);

                            char tmp = myarr[j];
                            myarr[j] = myarr[i];
                            myarr[i] = tmp;

                            Field.Text += tmp.ToString();
                        }
                    }
                    if (n == 32)
                    {
                        Field.Clear();
                        for (int i = myarr.Length - 29; i >= 0; i--)
                        {
                            int j = rnd.Next(i);

                            char tmp = myarr[j];
                            myarr[j] = myarr[i];
                            myarr[i] = tmp;

                            Field.Text += tmp.ToString();
                        }
                    }
                    if (n == 31)
                    {
                        Field.Clear();
                        for (int i = myarr.Length - 30; i >= 0; i--)
                        {
                            int j = rnd.Next(i);

                            char tmp = myarr[j];
                            myarr[j] = myarr[i];
                            myarr[i] = tmp;

                            Field.Text += tmp.ToString();
                        }
                    }
                    if (n == 30)
                    {
                        Field.Clear();
                        for (int i = myarr.Length - 31; i >= 0; i--)
                        {
                            int j = rnd.Next(i);

                            char tmp = myarr[j];
                            myarr[j] = myarr[i];
                            myarr[i] = tmp;

                            Field.Text += tmp.ToString();
                        }
                    }
                    if (n == 29)
                    {
                        Field.Clear();
                        for (int i = myarr.Length - 32; i >= 0; i--)
                        {
                            int j = rnd.Next(i);

                            char tmp = myarr[j];
                            myarr[j] = myarr[i];
                            myarr[i] = tmp;

                            Field.Text += tmp.ToString();
                        }
                    }
                    if (n == 28)
                    {
                        Field.Clear();
                        for (int i = myarr.Length - 33; i >= 0; i--)
                        {
                            int j = rnd.Next(i);

                            char tmp = myarr[j];
                            myarr[j] = myarr[i];
                            myarr[i] = tmp;

                            Field.Text += tmp.ToString();
                        }
                    }
                    if (n == 27)
                    {
                        Field.Clear();
                        for (int i = myarr.Length - 34; i >= 0; i--)
                        {
                            int j = rnd.Next(i);

                            char tmp = myarr[j];
                            myarr[j] = myarr[i];
                            myarr[i] = tmp;

                            Field.Text += tmp.ToString();
                        }
                    }
                    if (n == 26)
                    {
                        Field.Clear();
                        for (int i = myarr.Length - 35; i >= 0; i--)
                        {
                            int j = rnd.Next(i);

                            char tmp = myarr[j];
                            myarr[j] = myarr[i];
                            myarr[i] = tmp;

                            Field.Text += tmp.ToString();
                        }
                    }
                    if (n == 25)
                    {
                        Field.Clear();
                        for (int i = myarr.Length - 36; i >= 0; i--)
                        {
                            int j = rnd.Next(i);

                            char tmp = myarr[j];
                            myarr[j] = myarr[i];
                            myarr[i] = tmp;

                            Field.Text += tmp.ToString();
                        }
                    }
                    if (n == 24)
                    {
                        Field.Clear();
                        for (int i = myarr.Length - 37; i >= 0; i--)
                        {
                            int j = rnd.Next(i);

                            char tmp = myarr[j];
                            myarr[j] = myarr[i];
                            myarr[i] = tmp;

                            Field.Text += tmp.ToString();
                        }
                    }
                    if (n == 23)
                    {
                        Field.Clear();
                        for (int i = myarr.Length - 38; i >= 0; i--)
                        {
                            int j = rnd.Next(i);

                            char tmp = myarr[j];
                            myarr[j] = myarr[i];
                            myarr[i] = tmp;

                            Field.Text += tmp.ToString();
                        }
                    }
                    if (n == 22)
                    {
                        Field.Clear();
                        for (int i = myarr.Length - 39; i >= 0; i--)
                        {
                            int j = rnd.Next(i);

                            char tmp = myarr[j];
                            myarr[j] = myarr[i];
                            myarr[i] = tmp;

                            Field.Text += tmp.ToString();
                        }
                    }
                    if (n == 21)
                    {
                        Field.Clear();
                        for (int i = myarr.Length - 40; i >= 0; i--)
                        {
                            int j = rnd.Next(i);

                            char tmp = myarr[j];
                            myarr[j] = myarr[i];
                            myarr[i] = tmp;

                            Field.Text += tmp.ToString();
                        }
                    }
                    if (n == 20)
                    {
                        Field.Clear();
                        for (int i = myarr.Length - 41; i >= 0; i--)
                        {
                            int j = rnd.Next(i);

                            char tmp = myarr[j];
                            myarr[j] = myarr[i];
                            myarr[i] = tmp;

                            Field.Text += tmp.ToString();
                        }
                    }
                    if (n == 19)
                    {
                        Field.Clear();
                        for (int i = myarr.Length - 42; i >= 0; i--)
                        {
                            int j = rnd.Next(i);

                            char tmp = myarr[j];
                            myarr[j] = myarr[i];
                            myarr[i] = tmp;

                            Field.Text += tmp.ToString();
                        }
                    }
                    if (n == 18)
                    {
                        Field.Clear();
                        for (int i = myarr.Length - 43; i >= 0; i--)
                        {
                            int j = rnd.Next(i);

                            char tmp = myarr[j];
                            myarr[j] = myarr[i];
                            myarr[i] = tmp;

                            Field.Text += tmp.ToString();
                        }
                    }
                    if (n == 17)
                    {
                        Field.Clear();
                        for (int i = myarr.Length - 44; i >= 0; i--)
                        {
                            int j = rnd.Next(i);

                            char tmp = myarr[j];
                            myarr[j] = myarr[i];
                            myarr[i] = tmp;

                            Field.Text += tmp.ToString();
                        }
                    }
                    if (n == 16)
                    {
                        Field.Clear();
                        for (int i = myarr.Length - 45; i >= 0; i--)
                        {
                            int j = rnd.Next(i);

                            char tmp = myarr[j];
                            myarr[j] = myarr[i];
                            myarr[i] = tmp;

                            Field.Text += tmp.ToString();
                        }
                    }
                    if (n == 15)
                    {
                        Field.Clear();
                        for (int i = myarr.Length - 46; i >= 0; i--)
                        {
                            int j = rnd.Next(i);

                            char tmp = myarr[j];
                            myarr[j] = myarr[i];
                            myarr[i] = tmp;

                            Field.Text += tmp.ToString();
                        }
                    }
                    if (n == 14)
                    {
                        Field.Clear();
                        for (int i = myarr.Length - 47; i >= 0; i--)
                        {
                            int j = rnd.Next(i);

                            char tmp = myarr[j];
                            myarr[j] = myarr[i];
                            myarr[i] = tmp;

                            Field.Text += tmp.ToString();
                        }
                    }
                    if (n == 13)
                    {
                        Field.Clear();
                        for (int i = myarr.Length - 48; i >= 0; i--)
                        {
                            int j = rnd.Next(i);

                            char tmp = myarr[j];
                            myarr[j] = myarr[i];
                            myarr[i] = tmp;

                            Field.Text += tmp.ToString();
                        }
                    }
                    if (n == 12)
                    {
                        Field.Clear();
                        for (int i = myarr.Length - 49; i >= 0; i--)
                        {
                            int j = rnd.Next(i);

                            char tmp = myarr[j];
                            myarr[j] = myarr[i];
                            myarr[i] = tmp;

                            Field.Text += tmp.ToString();
                        }
                    }
                    if (n == 11)
                    {
                        Field.Clear();
                        for (int i = myarr.Length - 50; i >= 0; i--)
                        {
                            int j = rnd.Next(i);

                            char tmp = myarr[j];
                            myarr[j] = myarr[i];
                            myarr[i] = tmp;

                            Field.Text += tmp.ToString();
                        }
                    }
                    if (n == 10)
                    {
                        Field.Clear();
                        for (int i = myarr.Length - 51; i >= 0; i--)
                        {
                            int j = rnd.Next(i);

                            char tmp = myarr[j];
                            myarr[j] = myarr[i];
                            myarr[i] = tmp;

                            Field.Text += tmp.ToString();
                        }
                    }
                    if (n == 9)
                    {
                        Field.Clear();
                        for (int i = myarr.Length - 52; i >= 0; i--)
                        {
                            int j = rnd.Next(i);

                            char tmp = myarr[j];
                            myarr[j] = myarr[i];
                            myarr[i] = tmp;

                            Field.Text += tmp.ToString();
                        }
                    }
                    if (n == 8)
                    {
                        Field.Clear();
                        for (int i = myarr.Length - 53; i >= 0; i--)
                        {
                            int j = rnd.Next(i);

                            char tmp = myarr[j];
                            myarr[j] = myarr[i];
                            myarr[i] = tmp;

                            Field.Text += tmp.ToString();
                        }
                    }
                    if (n == 7)
                    {
                        Field.Clear();
                        for (int i = myarr.Length - 54; i >= 0; i--)
                        {
                            int j = rnd.Next(i);

                            char tmp = myarr[j];
                            myarr[j] = myarr[i];
                            myarr[i] = tmp;

                            Field.Text += tmp.ToString();
                        }
                    }
                    if (n == 6)
                    {
                        Field.Clear();
                        for (int i = myarr.Length - 55; i >= 0; i--)
                        {
                            int j = rnd.Next(i);

                            char tmp = myarr[j];
                            myarr[j] = myarr[i];
                            myarr[i] = tmp;

                            Field.Text += tmp.ToString();
                        }
                    }
                    if (n == 5)
                    {
                        Field.Clear();
                        for (int i = myarr.Length - 56; i >= 0; i--)
                        {
                            int j = rnd.Next(i);

                            char tmp = myarr[j];
                            myarr[j] = myarr[i];
                            myarr[i] = tmp;

                            Field.Text += tmp.ToString();
                        }
                    }
                    if (n == 4)
                    {
                        Field.Clear();
                        for (int i = myarr.Length - 57; i >= 0; i--)
                        {
                            int j = rnd.Next(i);

                            char tmp = myarr[j];
                            myarr[j] = myarr[i];
                            myarr[i] = tmp;

                            Field.Text += tmp.ToString();
                        }
                    }
                    if (n == 3)
                    {
                        Field.Clear();
                        for (int i = myarr.Length - 58; i >= 0; i--)
                        {
                            int j = rnd.Next(i);

                            char tmp = myarr[j];
                            myarr[j] = myarr[i];
                            myarr[i] = tmp;

                            Field.Text += tmp.ToString();
                        }
                    }
                    if (n == 2)
                    {
                        Field.Clear();
                        for (int i = myarr.Length - 59; i >= 0; i--)
                        {
                            int j = rnd.Next(i);

                            char tmp = myarr[j];
                            myarr[j] = myarr[i];
                            myarr[i] = tmp;

                            Field.Text += tmp.ToString();
                        }
                    }
                    if (n == 1)
                    {
                        Field.Clear();
                        for (int i = myarr.Length - 60; i >= 0; i--)
                        {
                            int j = rnd.Next(i);

                            char tmp = myarr[j];
                            myarr[j] = myarr[i];
                            myarr[i] = tmp;

                            Field.Text += tmp.ToString();
                        }
                    }
                    if (n == 0)
                    {
                        Field.Clear();
                        for (int i = myarr.Length - 61; i >= 0; i--)
                        {
                            int j = rnd.Next(i);

                            char tmp = myarr[j];
                            myarr[j] = myarr[i];
                            myarr[i] = tmp;

                            Field.Text += tmp.ToString();
                        }
                    }
                }
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
        
    

        
    

