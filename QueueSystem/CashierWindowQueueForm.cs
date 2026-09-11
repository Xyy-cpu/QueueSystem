using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueueSystem
{
    public partial class CashierWindowQueueForm : Form
    {
        public CashierWindowQueueForm()
        {
            InitializeComponent();
            ServingForm = new ServingForm();
            ServingForm.Show();
        }

        private ServingForm ServingForm;

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }
       
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (CashierClass.CashierQueue.Count > 0)
            {
                CashierClass.Serving = CashierClass.CashierQueue.Dequeue();
                DisplayCashierQueue(CashierClass.CashierQueue);
                ServingForm.ServingUpdate();
            }
        }
         public void DisplayCashierQueue(IEnumerable<string> CashierList)
        {
            listCashierQueue.Items.Clear();

            foreach (Object obj in CashierList)
            {
                listCashierQueue.Items.Add(obj.ToString());
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            QueuingForm Queue = new QueuingForm();
            Queue.Show();
        }

        
    }
}
