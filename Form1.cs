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
            if (txtInput.Text.Length > 50)
            {
                MessageBox.Show("메시지는 50자 이내로 입력해야 합니다.", "입력 제한");
                return; 
            }

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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstMessages.SelectedIndex != -1)
            {
                lstMessages.Items.RemoveAt(lstMessages.SelectedIndex);

                lblCount.Text = $"현재 대화: {lstMessages.Items.Count}개";
            }
            else
            {
                MessageBox.Show("삭제할 항목을 먼저 선택해주세요!", "알림");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("모든 대화 기록을 지우시겠습니까?", "초기화", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                lstMessages.Items.Clear();
                lblCount.Text = "현재 대화: 0개";
                txtInput.Focus();
            }
        }
    }
}
