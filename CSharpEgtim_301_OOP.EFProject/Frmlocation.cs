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
    public partial class Frmlocation : Form
    {
        public Frmlocation()
        {
            InitializeComponent();
        }
        Entities2 db = new Entities2();
        private void btnList_Click(object sender, EventArgs e)
        {
            var value = db.Location.ToList();
            dttblLocation.DataSource = value; 
        }

        private void btnSearchById_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtbLocationId.Text);
            var values = db.Location.Where(x => x.LocationId == id).ToList();
            dttblLocation.DataSource = values;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Location location = new Location();
            location.City = txtbCity.Text;
            location.Country = txtbCountry.Text;
            location.Capacity = byte.Parse(nmrCapacity.Value.ToString());
            location.Price = decimal.Parse(txtbPrice.Text);
            location.GuideId = int.Parse(cmbGuide.SelectedValue.ToString());
            db.Location.Add(location);
            db.SaveChanges();
            MessageBox.Show ("Ekleme Tamamlandı.");
            
        }

        private void cmbGuide_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Frmlocation_Load(object sender, EventArgs e)
        {
            var values = db.Guide.Select(x => new
            {
                FullName = x.GuideName + " " + x.GuideSurname,
                x.GuideId
            }).ToList();
            cmbGuide.DisplayMember = "FullName";
            cmbGuide.ValueMember = "GuideId";
            cmbGuide.DataSource = values;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtbLocationId.Text);
            var deletedValue = db.Location.Find(id);
            db.Location.Remove(deletedValue);
            db.SaveChanges();
            MessageBox.Show("Silme İşlemi Başarılı");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtbLocationId.Text);
            var updatedValue = db.Location.Find(id);
            updatedValue.City = txtbCity.Text;
            updatedValue.Country = txtbCountry.Text;
            updatedValue.DayNight = txtbDayNight.Text;
            updatedValue.Price = decimal.Parse(txtbPrice.Text);
            updatedValue.Capacity = byte.Parse(nmrCapacity.Value.ToString());
            updatedValue.GuideId = int.Parse(cmbGuide.SelectedValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Güncelleme İşlemi Başarılı.");
        }
    }
}
