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
    public partial class UserCon : UserControl
    {
        int ClienId;

        

        public UserCon(int id, string clientName, string clientAdress)
        {
            InitializeComponent();
            ClientName.Text = $"NAME: {clientName}";
           // ClientNumber.Text = $"ClientNumber: {ClientNumber.ToString()}₴";
            ClientSumma.Text = $"Adress: {clientAdress}";
            //ClientSumma.Text = $"Adress: {ClientSumma.ToString()}";
            this.ClienId = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //UserCon model=new UserCon();
            //model.ClientId.Remove(model.client.Find(ClId));
            //model.SaveChanges();
        }
    }
}
