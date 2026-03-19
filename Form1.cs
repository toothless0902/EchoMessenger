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
            string message = txtInput.Text.Trim();
            
            if (!string.IsNullOrWhiteSpace(txtInput.Text))
            {
                string timeStamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                
                string result = $"[{timeStamp}] {message}";

                
                lstMessages.Items.Add(result);

                
                lblCount.Text = $"현재 대화: {lstMessages.Items.Count}개";


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
