using EntytiFrame.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntytiFrame
{
    public partial class Form1 : Form
    {
        DriveEntities db = new DriveEntities();
        Client client=new Client();
        int ClId = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           // Client.ClientName = txtClName.Text.Trim();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ClearData();
            SetDataInGridView();
        }

        private void SetDataInGridView()
        {
            dataGridView.AutoGenerateColumns = false;
            dataGridView.DataSource = db.Client.ToList<Client>();
        }

        private void ClearData()
        {
            txtClAdress.Text = txtClAdress.Text = txtClName.Text = txtClNumber.Text = txtClSumma.Text = string.Empty;
            btnDelete.Enabled = false;
            btnSave.Text = "Сохранить";
            ClId = 0;
        }
    }
}
