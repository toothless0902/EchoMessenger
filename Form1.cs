namespace EchoMessenger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(txtInput.Text))
            {

                lstMessages.Items.Add(txtInput.Text);


                txtInput.Clear();
            }


            txtInput.Focus();
        }

        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               btnSend.PerformClick();
            }
        }
    }
}
