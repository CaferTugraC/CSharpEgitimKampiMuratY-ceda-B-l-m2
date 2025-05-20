using CSharpEgtim_301_OOP.BuisnessLayer.Abstract;
using CSharpEgtim_301_OOP.BuisnessLayer.Concrete;
using CSharpEgtim_301_OOP.DataAccsessLayer.EntityFramework;
using CSharpEgtim_301_OOP.EntityLayer.Concrete;
using CSharpEgtim_301_OOP.DataAccsessLayer.Abstarct;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgtim_301_OOP.Presentation
{
    public partial class FrmProduct : Form
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        public FrmProduct()
        {
            _productService = new ProductManager(new EfProductDal());
            _categoryService = new CategoryManager(new EfCategoryDal());
            InitializeComponent();
        }
        private void FrmProduct_Load(object sender, EventArgs e)
        {
            var values = _categoryService.TGetAll().Select(x => new
            {
                x.CategoryName,
                x.CatagoryId
            }).ToList();
            cmbProductCategoryId.DisplayMember = "CategoryName";
            cmbProductCategoryId.ValueMember = "CatagoryId";
            cmbProductCategoryId.DataSource = values;
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var values = _productService.TGetProductWithCategory();
            dataGridView1.DataSource = values;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtbId.Text);
            var deletedValues = _productService.TGetById(id);
            _productService.TDelete(deletedValues);
            MessageBox.Show("Ürün Başarıyla Silindi.");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product addedProduct = new Product();
            addedProduct.ProductName = txtbName.Text;
            addedProduct.ProductPrice = decimal.Parse(txtbPrice.Text);
            addedProduct.ProductStock = int.Parse(txtbStock.Text);
            addedProduct.ProductDescription = txtbDescription.Text;
            addedProduct.CategoryId = int.Parse(cmbProductCategoryId.SelectedValue.ToString());
            addedProduct.Category = _categoryService.TGetById(addedProduct.CategoryId);
            _productService.TInsert(addedProduct);
            MessageBox.Show("Ürün Başarıyla Eklendi.");
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtbId.Text);
            
            dataGridView1.DataSource = _productService.TGetById(id);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtbId.Text);
            var updatedValues = _productService.TGetById(id);
            updatedValues.ProductName = txtbName.Text;
            updatedValues.ProductPrice = int.Parse(txtbPrice.Text);
            updatedValues.ProductStock = int.Parse(txtbStock.Text);
            updatedValues.ProductDescription = txtbDescription.Text;
            updatedValues.CategoryId = int.Parse(cmbProductCategoryId.SelectedValue.ToString());
            updatedValues.Category.CatagoryId = int.Parse(cmbProductCategoryId.SelectedValue.ToString());
            _productService.TUpdate(updatedValues);
            MessageBox.Show("Ürün Başarıyla Güncellendi.");
        }

        private void btnListProductOnSelectedCategory_Click(object sender, EventArgs e)
        {
            var values = _productService.TGetAll().Where(x => x.CategoryId == int.Parse(cmbProductCategoryId.SelectedValue.ToString())).ToList();
            dataGridView1.DataSource = values;
        }
    }
}
