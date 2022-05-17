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
    public partial class Invoice : Form
    {
        string ay1,pr;
        public Invoice()
        {
            InitializeComponent();
            
        }


        private void Invoice_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.provider". При необходимости она может быть перемещена или удалена.
            this.providerTableAdapter.Fill(this.testDataSet.provider);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet1.product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.testDataSet1.product);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet1.product". При необходимости она может быть перемещена или удалена.



        }

       
        private void dgv_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            

            if ((e.Exception) is ConstraintException)
            {
                DataGridView view = (DataGridView)sender;
                view.Rows[e.RowIndex].ErrorText = "an error";
                view.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = "an error";

                e.ThrowException = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)

        {
            ay1 = dateTimePicker1.Text;
            pr = provider.Text;

        
            for (int i = 0; i < dgv.Rows.Count-1; i++)
            {

          
                SqlConnection connection1 = new SqlConnection("Data Source = " + Properties.Settings.Default.ip + "; Database = test; user id ="+ Properties.Settings.Default.user + "; PASSWORD = " + Properties.Settings.Default.password + "");
                SqlDataAdapter cmd = new SqlDataAdapter();

                cmd.InsertCommand = new SqlCommand("INSERT INTO [dbo].[invoice] (product,provider,data,count) VALUES (  '" + dgv.Rows[i].Cells[0].Value + "','" + pr + "', '" + ay1 + "','" + dgv.Rows[i].Cells[1].Value + "')", connection1);

                connection1.Open();
                cmd.InsertCommand.ExecuteNonQuery();
                connection1.Close();
                System.Windows.Forms.MessageBox.Show("Сохранено");

               


            }






        }

     



                
        
    }
}
