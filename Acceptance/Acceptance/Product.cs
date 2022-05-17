using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acceptance
{
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }

        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.testDataSet1);

        }

        private void Product_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet1.product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.testDataSet1.product);
            gridView1.Columns[0].Visible = false;

            gridView1.Columns[1].Caption = "Код товара";
            gridView1.Columns[2].Caption = "Наименование товара";
            gridView1.Columns[3].Caption = "Код поставщика";

            gridView1.Columns[4].Caption = "Стоимость за кг";

        }

        private void save_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.testDataSet1);
            MessageBox.Show("Сохранено");

        }
    }
}
