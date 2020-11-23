﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace pract_11
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void AboutUs_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Филяк, ИСП-31, вариант 1. Дана строка 'ahb acb aeb aeeb adcb axeb'. Напишите регулярное выражение, которое найдет строки ahb, acb, aeb.  Дана строка 'aa a1a a22a a333a a4444a a55555a aba aca'. Напишите регулярное выражение, которое найдет строки, в которых по краям стоят буквы 'a', а между ними любое количество цифр (в том числе и ноль цифр, то есть строка 'aa'). ");
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GetAnswer_Click(object sender, EventArgs e)
        {
            Regex regex1 = new Regex("a[hce]b");
            MatchCollection matches = regex1.Matches(textBox1.Text);
            for(int i = 0; i < matches.Count; i++)
            {
                answerBox1.Text += matches[i].Value + " ";
            }
        }
    }
}
