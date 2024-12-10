using System;
using System.Windows.Forms;
using CSTC301.BusinessLayer.Abstract;
using CSTC301.BusinessLayer.Concrete;
using CSTC301.DataAccessLayer.EntityFramework;

namespace CSTC301.PresentationLayer
{
    public partial class FrmProduct : Form
    {
        private readonly IProductService _productService;
        public FrmProduct()
        {
            InitializeComponent();
            _productService = new ProductManager(new EfProductDal());
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var values = _productService.TGetProductWithCategory();
            dataGridView1.DataSource = values;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
        }
    }
}
