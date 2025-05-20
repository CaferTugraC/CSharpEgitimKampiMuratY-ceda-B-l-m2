using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgtim_301_OOP.EFProject
{
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        Entities2 db = new Entities2();
        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            lblLocationCount.Text = db.Location.Count().ToString();
            lblSumCapacity.Text = db.Location.Sum(x => x.Capacity).ToString();
            lblSumGuideCount.Text = db.Guide.Count().ToString();
            lblAvrCapacity.Text = db.Location.Average(x => (decimal)x.Capacity).ToString("0");
            lblAvrPrice.Text = db.Location.Average(x => (decimal)x.Price).ToString("0.00");// (decimal?)x.Price)?.ToString("0.00")+"₺"
            int lastLocationId = db.Location.Max(x => x.LocationId);
            lblLastAddedCountry.Text = db.Location.Where(x => x.LocationId == lastLocationId).Select(y => y.Country).FirstOrDefault();
            label10.Text = db.Location.Where(x => x.City == "Kapadokya").Select(y => y.Capacity).FirstOrDefault().ToString();
            label8.Text = db.Location.Where(x => x.Country == "Türkiye").Average(y => y.Capacity).ToString();
            var romeGuideId = db.Location.Where(x => x.City == "Roma").Select(y => y.GuideId).FirstOrDefault();
            label22.Text = db.Guide.Where(x => x.GuideId == romeGuideId).Select(y => y.GuideName + " " + y.GuideSurname).FirstOrDefault();
            var maxCapacityTour = db.Location.Max(x => x.Capacity);
            label20.Text = db.Location.Where(x => x.Capacity == maxCapacityTour).Select(y => y.City + "-" + y.Country + "-" + y.Capacity).FirstOrDefault();
            var maxPriceTour = db.Location.Max(x => x.Price);
            label18.Text = db.Location.Where(x => x.Price == maxPriceTour).Select(y => y.City + "-" + y.Price).FirstOrDefault();
            label16.Text = db.Location.Count(x => x.GuideId == 1).ToString();
        
        }

        private void lblLastAddedCountry_Click(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void lblAvrPrice_Click(object sender, EventArgs e)
        {

        }
    }
}
