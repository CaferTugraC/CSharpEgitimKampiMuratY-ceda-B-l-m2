using CSharpEgtim_301_OOP.BuisnessLayer.Abstract;
using CSharpEgtim_301_OOP.BuisnessLayer.Concrete;
using CSharpEgtim_301_OOP.DataAccsessLayer.EntityFramework;
using CSharpEgtim_301_OOP.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgtim_301_OOP.Presentation
{
    public partial class FrmCategory : Form
    {
        private readonly ICategoryService _categoryService;
        public FrmCategory()
        {
            _categoryService = new CategoryManager(new EfCategoryDal());
            InitializeComponent();
        }

        private void FrmCategory_Load(object sender, EventArgs e)
        {
            
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var categoryValues = _categoryService.TGetAll();
            dataGridView1.DataSource = categoryValues;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.CategoryName = txtbName.Text;
            category.CatagoryStatus = true;
            _categoryService.TInsert(category);
            MessageBox.Show("Kategori Başarıyla Eklendi.");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtbId.Text);
            var deletedValues = _categoryService.TGetById(id);
            _categoryService.TDelete(deletedValues);
            MessageBox.Show("Kategori Başarıyla Silindi.");
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtbId.Text);
            var values = _categoryService.TGetById(id);
            dataGridView1.DataSource = values;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int updatedId = int.Parse(txtbId.Text);
            var updatedValue = _categoryService.TGetById(updatedId);
            updatedValue.CategoryName = txtbName.Text;
            updatedValue.CatagoryStatus = true;
            _categoryService.TUpdate(updatedValue);
        }
    }
}
