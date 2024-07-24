using Company.LoanManagement.Business.Interfaces;
using Company.LoanManagement.Domain.Entities;

namespace Company.LoanManagement.WinUI.Forms
{
    public partial class CustomerForm : Form
    {
        private readonly ICustomerService _customerService;

        public CustomerForm(ICustomerService customerService)
        {
            _customerService = customerService;
            InitializeComponent();
        }

        #region Methods

        // Validate customer data
        private bool ValidateCustomerInput()
        {
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Customer name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAddress.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtCustomerName.Text))
            {
                MessageBox.Show("Address is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCustomerName.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtContactNumber.Text))
            {
                MessageBox.Show("Contact number is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContactNumber.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtEmail.Text) || !IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("A valid email address is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }
            return true;
        }
        private bool IsValidEmail(string email)
        {
            try
            {
                var address = new System.Net.Mail.MailAddress(email);
                return address.Address == email;
            }
            catch
            {
                return false;
            }
        }

        // Clear form data
        private void ClearFormData()
        {
            txtAddress.Clear();
            txtCustomerName.Clear();
            txtContactNumber.Clear();
            txtEmail.Clear();
        }

        // CRUD
        private void InsertCustomer()
        {
            if (ValidateCustomerInput())
            {
                try
                {
                    Customer customer = new Customer()
                    {
                        CustomerName = txtAddress.Text,
                        Address = txtCustomerName.Text,
                        ContactNumber = txtContactNumber.Text,
                        Email = txtEmail.Text,
                    };
                    _customerService.InsertCustomer(customer);
                    MessageBox.Show("Customer save successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while saving the customer: {ex.Message}");
                }
            }
        }
        private void LoadCustomer()
        {
            var customer = _customerService.SelectAll();
            dgvCustomer.DataSource = customer;
            dgvCustomer.Columns[0].Visible = false;
        }
        private void UpdateCustomer()
        {
            try
            {
                Customer customer = new Customer()
                {
                    Id = Convert.ToInt32(dgvCustomer.CurrentRow.Cells[0].Value),
                    CustomerName = txtAddress.Text,
                    Address = txtCustomerName.Text,
                    ContactNumber = txtContactNumber.Text,
                    Email = txtEmail.Text,
                };
                _customerService.UpdateCustomer(customer);
                MessageBox.Show("Customer update successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BtnSave.Text = "Save";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating the customer: {ex.Message}");
            }
        }
        private void DeleteCustomer()
        {
            var confirmResult = MessageBox.Show("Are you sure to delete this customer?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    Customer customer = new Customer()
                    {
                        Id = Convert.ToInt32(dgvCustomer.CurrentRow.Cells[0].Value)
                    };
                    _customerService.DeleteCustomer(customer);
                    MessageBox.Show("Customer deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while deleting the customer: {ex.Message}");
                }
            }
        }
        #endregion

        #region Events
        #region Load
        private void CustomerForm_Load(object sender, EventArgs e)
        {
            txtAddress.Focus();
            LoadCustomer();
        }
        #endregion
        #region Click
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (BtnSave.Text == "Save")
            {
                InsertCustomer();
            }
            else if (BtnSave.Text == "Update")
            {
                UpdateCustomer();
            }
            LoadCustomer();
            ClearFormData();
        }
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            BtnDelete.Enabled = true;
            BtnSave.Text = "Update";

            if (dgvCustomer.CurrentRow != null)
            {
                txtAddress.Text = dgvCustomer.CurrentRow.Cells["Name"].Value.ToString();
                txtCustomerName.Text = dgvCustomer.CurrentRow.Cells["Address"].Value.ToString();
                txtContactNumber.Text = dgvCustomer.CurrentRow.Cells["ContactNumber"].Value.ToString();
                txtEmail.Text = dgvCustomer.CurrentRow.Cells["Email"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Please select a row to edit.");
            }
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DeleteCustomer();
            LoadCustomer();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
        #region CellClick
        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BtnEdit.Enabled = true;
            BtnDelete.Enabled = true;
        }
        #endregion
        #endregion
    }
}
