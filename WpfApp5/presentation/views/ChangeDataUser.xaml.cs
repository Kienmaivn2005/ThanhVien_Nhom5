using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;
using WpfApp5.domain.models;

namespace WpfApp5.presentation.views
{
    /// <summary>
    /// Interaction logic for ChangeDataUser.xaml
    /// </summary>
    public partial class ChangeDataUser : Page
    {
        private UserModel _currentUser;
        private UserPage _userPage;
        public ChangeDataUser(UserModel user, UserPage userPage)
        {
            InitializeComponent();
            _currentUser = user;
            _userPage = userPage;
            LoadUserData();
        }
        private void LoadUserData()
        {
            txtID.Text = _currentUser.ID.ToString();
            txtName.Text = _currentUser.Name;
            foreach (ComboBoxItem item in cmbGender.Items)
            {
                if (item.Content.ToString() == _currentUser.Gender)
                {
                    cmbGender.SelectedItem = item;
                    break;
                }
            }
            txtTelephone.Text = _currentUser.Telephone;
            txtRole.Text = _currentUser.Role;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            if (cmbGender.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn giới tính!");
                return;
            }

            // Cập nhật thông tin người dùng
            _currentUser.Name = txtName.Text;
            _currentUser.Gender = (cmbGender.SelectedItem as ComboBoxItem).Content.ToString();
            _currentUser.Telephone = txtTelephone.Text;
            _currentUser.Role = txtRole.Text;

            // Cập nhật lại danh sách trên UserPage
            _userPage.UpdateUser(_currentUser);
            MessageBox.Show("Thay đổi người dùng thành công!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);

            // Quay lại UserPage
            this.NavigationService.Navigate(_userPage);
        }
    }
}
