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
            using (var db = new DriveEntities())
            {
                
                    client.ClientName = txtClName.Text.Trim();
                    client.ClientNumber = Convert.ToInt32(txtClNumber.Text.Trim());
                    client.ClientAdress = txtClCity.Text.Trim() + ", " + txtClAdress.Text.Trim();
                    client.ClientSumma = Convert.ToInt32(txtClSumma.Text.Trim());
                
                    if (ClId > 0)
                        db.Entry(client).State = System.Data.Entity.EntityState.Modified;
                    else
                    {
                        db.Client.Add(client);
                    }
                    db.SaveChanges();
                    ClearData();
                    SetDataInGridView();
                
                MessageBox.Show("Все ОКЕЙ!!!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Вы действительно хотите удалить?"," Удалить???",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                db.Client.Remove(client);
                db.SaveChanges();
                ClearData();
                SetDataInGridView();
                MessageBox.Show("Все Удалено!!!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            ClearData();
            SetDataInGridView();
            int x = 15, y = 130;
            DriveEntities model = new DriveEntities();
            foreach (var item in model.Client)
            {

                this.Controls.Add(new UserCon(item.ClientId, item.ClientName, item.ClientAdress) { Location = new Point(x, y) });

                x += 250;
                if (x / 250 >= 3)
                {
                    y += 150;
                    x = 15;
                }

            }

        }

        private void SetDataInGridView()
        {
            dataGridView.AutoGenerateColumns = false;
            dataGridView.DataSource = db.Client.ToList<Client>();
            //BindingList<Client> clients = new BindingList<Client>();
        }

        private void ClearData()
        {
            txtClAdress.Text = txtClAdress.Text = txtClName.Text = txtClNumber.Text = txtClSumma.Text = string.Empty;
            btnDelete.Enabled = false;
            btnSave.Text = "Сохранить";
            ClId = 0;
        }

        private void dataGridView_DoubleClick(object sender, EventArgs e)
        {
            if(dataGridView.CurrentCell.RowIndex!=-1)
            {
                ClId = Convert.ToInt32(dataGridView.CurrentRow.Cells["ClientId"].Value);
                client = db.Client.Where(x => x.ClientId == ClId).FirstOrDefault();
                txtClName.Text = client.ClientName;
                txtClAdress.Text = client.ClientAdress;
                txtClNumber.Text = client.ClientNumber.ToString();
                txtClSumma.Text = client.ClientSumma.ToString();
            }
            btnSave.Text = "Update";
            btnDelete.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
