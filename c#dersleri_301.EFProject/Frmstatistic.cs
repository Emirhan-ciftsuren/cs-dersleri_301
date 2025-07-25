using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c_dersleri_301.EFProject
{
    public partial class Frmstatistic : Form
    {
        public Frmstatistic()
        {
            InitializeComponent();
        }
        EgitimKampiEfTravelDbEntities db = new EgitimKampiEfTravelDbEntities();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Frmstatistic_Load(object sender, EventArgs e)
        {

            lblLocationCount.Text = db.Location.Count().ToString();
            lblsumCapacity.Text = db.Location.Sum(x => x.Capacity).ToString();
            lblGuideCount.Text = db.Guide.Count().ToString();
            lblAvgCapacity.Text = db.Location.Average(x => x.Capacity).ToString();
            var dta = db.Location.Average(x => x.Price);
            lblAvgLocationPrice.Text = dta?.ToString("F2");
            
            


        }

        private void Frmstatistic_Shown(object sender, EventArgs e)
        {
       
        }
    }
}
