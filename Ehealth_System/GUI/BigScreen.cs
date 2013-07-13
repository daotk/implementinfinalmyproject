using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DA.Entity;

namespace GUI
{
    public partial class BigScreen : Form
    {
        public BigScreen()
        {
            InitializeComponent();
        }

        private void BigScreen_Load(object sender, EventArgs e)
        {
            grd_Thongtin.DataSource = BL.BigScreen_BL.Get();
        }
    }
}