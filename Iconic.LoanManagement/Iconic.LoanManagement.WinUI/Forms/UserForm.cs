using Iconic.LoanManagement.Business.Interfaces;
using Iconic.LoanManagement.Domain.Entities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Iconic.LoanManagement.WinUI.Forms
{
    public partial class UserForm : Form
    {
        private readonly IUserService _userService;

        public UserForm(IUserService userService)
        {
            _userService = userService;

            InitializeComponent();
        }

        #region Method
        private void ClearFormData()
        {
            TxtUsername.Clear();
            TxtPassword.Clear();
        }
        private void RegisterUser()
        {
            try
            {
                var user = new Users()
                {
                    UserName = TxtUsername.Text,
                    PasswordHash = TxtPassword.Text,
                    UserRole = CmbRole.SelectedItem.ToString(),
                };
                _userService.InsertUser(user);
                MessageBox.Show("User registered successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving user.: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void GetAllUsers()
        {
            var users = _userService.SelectAllUser();
            DgvUserList.DataSource = users;

            // Hide UserID column
            DgvUserList.Columns[0].Visible = false;
        }
        private void UpdateUser()
        {
            try
            {
                var user = new Users()
                {
                    UserID = Convert.ToInt32(DgvUserList.CurrentRow.Cells[0].Value),
                    UserName = TxtUsername.Text,
                    PasswordHash = TxtPassword.Text,
                    UserRole = CmbRole.SelectedText,
                };
                _userService.InsertUser(user);
                MessageBox.Show("User updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating user.: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Events
        #region Load
        private void UserForm_Load(object sender, EventArgs e)
        {
            GetAllUsers();
        }
        #endregion
        #region Click
        private void BtnRegister_Click(object sender, EventArgs e)
        {
            RegisterUser();
            ClearFormData();
            GetAllUsers();
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
        #region KeyDown
        private void TxtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxtPassword.Focus();
            }
        }
        private void TxtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CmbRole.Focus();
            }
        }
        private void CmbRole_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnRegister.Focus();
            }
        }
        #endregion
        #region CellDoubleClick
        private void DgvUserList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BtnRegister.Text = "Update";
            BtnRegister.BackColor = Color.FromArgb(45, 156, 219);

            if (DgvUserList.CurrentRow != null)
            {
                TxtUsername.Text = DgvUserList.CurrentRow.Cells["UserName"].Value.ToString();
                TxtPassword.Text = DgvUserList.CurrentRow.Cells["Password"].Value.ToString();
                CmbRole.SelectedItem = DgvUserList.CurrentRow.Cells["Role"].Value.ToString();
            }
        }
        #endregion
        #endregion
    }
}
