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
            using (DA.Entity.EHealthSystemEntities dk = new DA.Entity.EHealthSystemEntities())
            {
                grd_Thongtin.DataSource = dk.sp_loadthongtinhoadon().ToList();
            }
        }
    }
}