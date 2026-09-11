using System.Drawing.Text;

namespace QueueSystem
{
    public partial class QueuingForm : Form
    {
        private CashierClass cashier;

        public QueuingForm()
        {

            InitializeComponent();

            cashier = new CashierClass();
        }
            private void btnCashier_Click(object sender, EventArgs e)
        {
            lblQueue.Text = cashier.CashierGeneratedNumber("P - ");

            CashierClass.getNumberInQueue = lblQueue.Text;

            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);
        }
        private void btnList_Click(object sender, EventArgs e) 
        {
            this.Hide();
            CashierWindowQueueForm cashierWindow = new CashierWindowQueueForm();
            cashierWindow.Show();

            
        }

    }
}
