﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Third_sem_new_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("text message");
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // string data = username.Text;
            //if (data == "test")
            {
              //  MessageBox.Show(data);
            }
            //else
            {
              //  MessageBox.Show("failed");
            }

        }
       
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            username.Text = "Test";
        }
    }

}
