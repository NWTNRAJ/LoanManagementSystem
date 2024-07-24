namespace Company.LoanManagement.WinUI.Forms
{
    partial class CustomerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            txtEmail = new TextBox();
            txtContactNumber = new TextBox();
            txtAddress = new TextBox();
            txtCustomerName = new TextBox();
            BtnClose = new Button();
            BtnSave = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pnlName = new Panel();
            pnlAddress = new Panel();
            pnlContactNumber = new Panel();
            groupBox2 = new GroupBox();
            BtnEdit = new Button();
            BtnDelete = new Button();
            dgvCustomer = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = Color.WhiteSmoke;
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtContactNumber);
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(txtCustomerName);
            groupBox1.Controls.Add(BtnClose);
            groupBox1.Controls.Add(BtnSave);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(pnlName);
            groupBox1.Controls.Add(pnlAddress);
            groupBox1.Controls.Add(pnlContactNumber);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(464, 208);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "New Customer";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(237, 118);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(220, 26);
            txtEmail.TabIndex = 13;
            // 
            // txtContactNumber
            // 
            txtContactNumber.Location = new Point(6, 118);
            txtContactNumber.Name = "txtContactNumber";
            txtContactNumber.Size = new Size(200, 26);
            txtContactNumber.TabIndex = 12;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(237, 55);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(220, 26);
            txtAddress.TabIndex = 11;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(6, 55);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(200, 26);
            txtCustomerName.TabIndex = 10;
            // 
            // BtnClose
            // 
            BtnClose.BackColor = Color.LightGray;
            BtnClose.FlatAppearance.BorderColor = Color.White;
            BtnClose.FlatAppearance.BorderSize = 0;
            BtnClose.FlatStyle = FlatStyle.Flat;
            BtnClose.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            BtnClose.Location = new Point(251, 167);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(100, 35);
            BtnClose.TabIndex = 9;
            BtnClose.Text = "Close";
            BtnClose.UseVisualStyleBackColor = false;
            BtnClose.Click += BtnClose_Click;
            // 
            // BtnSave
            // 
            BtnSave.BackColor = Color.SeaGreen;
            BtnSave.FlatAppearance.BorderSize = 0;
            BtnSave.FlatStyle = FlatStyle.Flat;
            BtnSave.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            BtnSave.ForeColor = SystemColors.ButtonHighlight;
            BtnSave.Location = new Point(357, 167);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(100, 35);
            BtnSave.TabIndex = 5;
            BtnSave.Text = "Save";
            BtnSave.UseVisualStyleBackColor = false;
            BtnSave.Click += BtnSave_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(237, 96);
            label4.Name = "label4";
            label4.Size = new Size(41, 19);
            label4.TabIndex = 3;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 96);
            label3.Name = "label3";
            label3.Size = new Size(111, 19);
            label3.TabIndex = 2;
            label3.Text = "Contact Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(237, 33);
            label2.Name = "label2";
            label2.Size = new Size(58, 19);
            label2.TabIndex = 1;
            label2.Text = "Address";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 33);
            label1.Name = "label1";
            label1.Size = new Size(45, 19);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // pnlName
            // 
            pnlName.BackColor = Color.IndianRed;
            pnlName.Location = new Point(6, 55);
            pnlName.Name = "pnlName";
            pnlName.Size = new Size(200, 27);
            pnlName.TabIndex = 14;
            pnlName.Visible = false;
            // 
            // pnlAddress
            // 
            pnlAddress.BackColor = Color.IndianRed;
            pnlAddress.Location = new Point(237, 55);
            pnlAddress.Name = "pnlAddress";
            pnlAddress.Size = new Size(220, 27);
            pnlAddress.TabIndex = 15;
            pnlAddress.Visible = false;
            // 
            // pnlContactNumber
            // 
            pnlContactNumber.BackColor = Color.IndianRed;
            pnlContactNumber.Location = new Point(6, 118);
            pnlContactNumber.Name = "pnlContactNumber";
            pnlContactNumber.Size = new Size(200, 27);
            pnlContactNumber.TabIndex = 16;
            pnlContactNumber.Visible = false;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.BackColor = Color.WhiteSmoke;
            groupBox2.Controls.Add(BtnEdit);
            groupBox2.Controls.Add(BtnDelete);
            groupBox2.Controls.Add(dgvCustomer);
            groupBox2.FlatStyle = FlatStyle.Flat;
            groupBox2.Location = new Point(12, 226);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(464, 226);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Customer List";
            // 
            // BtnEdit
            // 
            BtnEdit.BackColor = Color.Coral;
            BtnEdit.Enabled = false;
            BtnEdit.FlatAppearance.BorderSize = 0;
            BtnEdit.FlatStyle = FlatStyle.Flat;
            BtnEdit.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            BtnEdit.Location = new Point(251, 25);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(100, 30);
            BtnEdit.TabIndex = 2;
            BtnEdit.Text = "Edit";
            BtnEdit.UseVisualStyleBackColor = false;
            BtnEdit.Click += BtnEdit_Click;
            // 
            // BtnDelete
            // 
            BtnDelete.BackColor = Color.IndianRed;
            BtnDelete.Enabled = false;
            BtnDelete.FlatAppearance.BorderSize = 0;
            BtnDelete.FlatStyle = FlatStyle.Flat;
            BtnDelete.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            BtnDelete.Location = new Point(357, 25);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(100, 30);
            BtnDelete.TabIndex = 1;
            BtnDelete.Text = "Delete";
            BtnDelete.UseVisualStyleBackColor = false;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // dgvCustomer
            // 
            dgvCustomer.AllowUserToAddRows = false;
            dgvCustomer.AllowUserToDeleteRows = false;
            dgvCustomer.AllowUserToResizeColumns = false;
            dgvCustomer.AllowUserToResizeRows = false;
            dgvCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomer.BackgroundColor = SystemColors.Window;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.SeaGreen;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = Color.SeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = SystemColors.InfoText;
            dataGridViewCellStyle2.SelectionBackColor = Color.Honeydew;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.InfoText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvCustomer.DefaultCellStyle = dataGridViewCellStyle2;
            dgvCustomer.EnableHeadersVisualStyles = false;
            dgvCustomer.Location = new Point(6, 61);
            dgvCustomer.Name = "dgvCustomer";
            dgvCustomer.ReadOnly = true;
            dgvCustomer.RowHeadersVisible = false;
            dgvCustomer.RowTemplate.Height = 25;
            dgvCustomer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomer.Size = new Size(451, 159);
            dgvCustomer.TabIndex = 0;
            dgvCustomer.CellClick += dgvCustomer_CellClick;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(488, 464);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CustomerForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customer";
            Load += CustomerForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Button BtnSave;
        private Button BtnClose;
        private DataGridView dgvCustomer;
        private Button BtnDelete;
        private Button BtnEdit;
        private TextBox txtContactNumber;
        private TextBox txtAddress;
        private TextBox txtCustomerName;
        private TextBox txtEmail;
        private Panel pnlName;
        private Panel pnlAddress;
        private Panel pnlContactNumber;
    }
}