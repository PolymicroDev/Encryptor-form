using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //"/k " + current.Substring(1,2) + "&cd" + current + "move *.py " + path + "&cd "+ path+"&python encryptor1.py"
            string path;
            string current;
            current = textBox2.Text;
            path = textBox1.Text;
            Process p = new Process();
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "CMD.EXE";
            psi.Arguments = "/c " + current.Substring(1,2) + "&cd " + current + "&move *.py " + path + "&cd "+ path+"&python encryptor.py";
            p.StartInfo = psi;
            p.Start();
            p.WaitForExit();

        }

        private void lbl_msg_Click(object sender, EventArgs e)
        {

            
            
        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string path;
            path = textBox1.Text;
            Process p = new Process();
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "CMD.EXE";
            psi.Arguments = "/c " + path.Substring(1, 2) + "&cd " + path  + "&python decryptor.py";
            p.StartInfo = psi;
            p.Start();
            p.WaitForExit();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
