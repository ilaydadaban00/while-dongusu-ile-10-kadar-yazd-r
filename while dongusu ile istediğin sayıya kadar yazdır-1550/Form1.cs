using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace while_dongusu_ile_istediğin_sayıya_kadar_yazdır_1550
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int say = 1;
            while(say < 10)
            {
                listBox1.Items.Add(say);
                say++;
            }
        }
    }
}
