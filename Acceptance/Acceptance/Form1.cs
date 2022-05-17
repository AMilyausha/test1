using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acceptance
{
    public partial class Form1 : Form
    {
        string ay1,ay2;
        public Form1()
        {
            InitializeComponent();
        }

        private void provider_Click(object sender, EventArgs e)
        {
           Provider Card = new Provider();
            Card.Show();
        }

        private void product_Click(object sender, EventArgs e)
        {
            Product Card = new Product();
            Card.Show();
        }

        private void invoice_Click(object sender, EventArgs e)
        {
            Invoice Card = new Invoice();
            Card.Show();

            //ArrayList empty = new ArrayList();
            //Card.invoiceGridControl.DataSource = empty;

        }

        private void report_Click(object sender, EventArgs e)
        {
            ay1 = dateTimePicker1.Text;
            ay2 = dateTimePicker2.Text;


            

            SqlConnection con1 = new SqlConnection("Data Source = " + Properties.Settings.Default.ip + "; Database = test; user id =" + Properties.Settings.Default.user + "; PASSWORD = " + Properties.Settings.Default.password + "");
            con1.Open();
            SqlCommand sql = new SqlCommand("select provider as 'Поставщик',product as 'Продукт',sum(convert(float,count)) as 'Количество', sum(convert(float,b.price)*convert(float,count)) as 'Общий вес' from [dbo].[invoice] as a left outer join [dbo].[product] as b on a.product=b.name_product  where data between '"+ay1+ "' and '" + ay2 + "' group by  provider,product", con1);
            SqlDataAdapter dr = new SqlDataAdapter(sql);
            DataSet ds = new DataSet();
            dr.Fill(ds);

            Report Card = new Report();
            Card.Show();

            Card.gridControl1.DataSource = ds.Tables[0];
        }
    }
}
