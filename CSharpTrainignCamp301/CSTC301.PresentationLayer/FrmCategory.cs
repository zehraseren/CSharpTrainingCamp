using System;
using System.Windows.Forms;
using CSTC301.EntityLayer.Concrete;
using CSTC301.BusinessLayer.Abstract;
using CSTC301.BusinessLayer.Concrete;
using CSTC301.DataAccessLayer.EntityFramework;

namespace CSTC301.PresentationLayer
{
    public partial class FrmCategory : Form
    {
        private readonly ICategoryService _categoryService;

        public FrmCategory()
        {
            _categoryService = new CategoryManager(new EfCategoryDal());
            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var categoryValues = _categoryService.TGetAll();
            dataGridView1.DataSource = categoryValues;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.CategoryName = txtCategoryName.Text;
            category.CategoryStatus = true;
            _categoryService.TInsert(category);
            MessageBox.Show("Ekleme başarılı");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCategoryId.Text);
            var daletedValue = _categoryService.TGetById(id);
            _categoryService.TDelete(daletedValue);
            MessageBox.Show("Silme başarılı");
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCategoryId.Text);
            var value = _categoryService.TGetById(id);
            dataGridView1.DataSource = value;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int updatedId = int.Parse(txtCategoryId.Text);
            var updatedValue = _categoryService.TGetById(updatedId);
            updatedValue.CategoryName = txtCategoryName.Text;
            updatedValue.CategoryStatus = true;
            _categoryService.TUpdate(updatedValue);
            MessageBox.Show("Güncelleme başarılı");
        }
    }
}
