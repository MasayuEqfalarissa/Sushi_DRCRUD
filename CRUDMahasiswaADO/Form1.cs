using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CRUDMahasiswaADO
{
    public partial class Form1: Form
    {
        private readonly SqlConnection conn;
        private readonly string ConnectionString =
            "Data Source=MASAYUU-DN5OL92\\MASAYU;Initial Catalog=DBAkademikADO;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnClick_Connect(object sender, EventArgs e)
        {

        }

        private void btnClick_Load(object sender, EventArgs e)
        {

        }

        private void btnClick_Create(object sender, EventArgs e)
        {

        }

        private void btnClick_Update(object sender, EventArgs e)
        {

        }

        private void btnClick_Delete(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
