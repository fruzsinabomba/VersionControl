using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace r7s3yp_8
{
    public partial class Form1 : Form
    {
        PortfolioEntities1 context = new PortfolioEntities1();
        List<Tick> Ticks;

        public Form1()
        {
            InitializeComponent();
            Ticks = context.Tick.ToList();
            dataGridView1.DataSource = Ticks;
        }
    }
}
