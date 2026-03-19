namespace EchoMessenger
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            lstMessages = new ListBox();
            txtInput = new TextBox();
            btnSend = new Button();
            lblCount = new Label();
            btnDelete = new Button();
            btnClear = new Button();
            bindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(309, 50);
            label1.TabIndex = 0;
            label1.Text = "Echo Messenger";
            // 
            // lstMessages
            // 
            lstMessages.FormattingEnabled = true;
            lstMessages.Location = new Point(22, 62);
            lstMessages.Name = "lstMessages";
            lstMessages.Size = new Size(772, 196);
            lstMessages.TabIndex = 1;
            // 
            // txtInput
            // 
            txtInput.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txtInput.Location = new Point(22, 388);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(593, 50);
            txtInput.TabIndex = 2;
            txtInput.KeyDown += txtInput_KeyDown;
            // 
            // btnSend
            // 
            btnSend.BackColor = SystemColors.Info;
            btnSend.Location = new Point(665, 372);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(129, 66);
            btnSend.TabIndex = 3;
            btnSend.Text = "전송";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Location = new Point(22, 339);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(170, 32);
            lblCount.TabIndex = 4;
            lblCount.Text = "현재 대화: 0개";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.ActiveCaption;
            btnDelete.Location = new Point(444, 280);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(188, 63);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "선택 항목 삭제\r\n";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.IndianRed;
            btnClear.Location = new Point(638, 280);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(150, 63);
            btnClear.TabIndex = 6;
            btnClear.Text = "전체 초기화";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(lblCount);
            Controls.Add(btnSend);
            Controls.Add(txtInput);
            Controls.Add(lstMessages);
            Controls.Add(label1);
            Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstMessages;
        private TextBox txtInput;
        private Button btnSend;
        private Label lblCount;
        private Button btnDelete;
        private Button btnClear;
        private BindingSource bindingSource1;
    }
}
