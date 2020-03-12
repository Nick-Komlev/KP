using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Net;

namespace KR
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        

        private void DataRepr_Click(object sender, EventArgs e)
        {
            Form newfrm = new Form2();
            newfrm.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }
    }

    
}
