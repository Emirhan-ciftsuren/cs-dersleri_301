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

            var a = db.Location.Average(x => x.Capacity);
            lblAvgCapacity.Text = a?.ToString("F2");
            var dta = db.Location.Average(x => x.Price);
            lblAvgLocationPrice.Text = dta?.ToString("F2");

            int lastCountryId = db.Location.Max(x => x.LocatiınId);
            lblLastCountryName.Text = db.Location.Where(x => x.LocatiınId == lastCountryId).Select(y => y.Country).FirstOrDefault();

            lblCappadociaLocationCapacity.Text = db.Location.Where(x => x.City == "Kapadokya").Select(y => y.Capacity).FirstOrDefault().ToString();

            lblTurkiyeCapacityAvg.Text = db.Location.Where(x => x.Country == "Türkiye").Average(y => y.Capacity).ToString();

            var romeGuideId = db.Location.Where(x => x.City == "Roma").Select(y => y.GuideId).FirstOrDefault();
            lblRomeGuideName.Text = db.Guide.Where(x => x.GuideId == romeGuideId).Select(y => y.GuideName + " " + y.GuideSurname).FirstOrDefault();//...

            var maxCapacity = db.Location.Max(x => x.Capacity);
            lblMaxCapacityLocation.Text = db.Location.Where(x => x.Capacity == maxCapacity).Select(y => y.City).FirstOrDefault().ToString();

            var maxPriceLocation = db.Location.Max(x => x.Price);
            lblMaxPriceLocation.Text=db.Location.Where(x=>x.Price==maxPriceLocation).Select(y=>y.City).FirstOrDefault().ToString();

            int enesyokusId=db.Guide.Where(x=>x.GuideName=="Enesim" && x.GuideSurname=="Yokuş").Select(y => y.GuideId).FirstOrDefault();
            lblEnesYokusLocationCount.Text=db.Location.Where(x=>x.GuideId==enesyokusId).Count().ToString();
           // var enesYokusLocationCount = db.Location.Where(x=>x.GuideId==1002).ToList().Count();
           //   lblEnesYokusLocationCount.Text = enesYokusLocationCount.ToString();
        }

        private void Frmstatistic_Shown(object sender, EventArgs e)
        {

        }


    }
}
