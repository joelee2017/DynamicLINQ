using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Dynamic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamicLINQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// LINQ 中直接使用SQL語法，需安裝組件 System.Linq.Dynamic
        /// 
        /// CustOrderHist 預存程序呼叫使用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            NorthwindEntities dc = new NorthwindEntities();
            dataGridView1.DataSource = dc.Customers.Where("Region !=null").OrderBy("Country").ToArray();
        }

        private void btnSqlQuery_Click(object sender, EventArgs e)
        {
            NorthwindEntities dc = new NorthwindEntities();
            dataGridView1.DataSource = dc.Customers.SqlQuery("select * from Customers where Country={0}", "UK").ToArray();
        }

        private void btnExecuteSQLCommand_Click(object sender, EventArgs e)
        {
            NorthwindEntities dc = new NorthwindEntities();

                dc.Database.ExecuteSqlCommand("Update Customers set City={0} where CustomerID={1}", "Taipeifuck", "ALFKI");
            dataGridView2.DataSource = dc.Customers.OrderBy("Country").ToArray();
        }

        private void btnCustOrderHist_Click(object sender, EventArgs e)//預存程序 方法化從資料庫類型加入
        {
            NorthwindEntities dc = new NorthwindEntities();
            dataGridView1.DataSource = dc.CustOrderHist("ALFKI").ToArray();
        }
    }
}
