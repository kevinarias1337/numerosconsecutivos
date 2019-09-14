using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace numerosconsecutivos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Continuar_Click(object sender, EventArgs e)
        {
            int numero2 = int.Parse(limitetxt.Text);
            int i;
            for (i = 1; i <= numero2; i++)
            {                
                numero.Rows.Add(i, numero2);
            }
        }
    }
}
