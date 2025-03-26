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
using System.Windows.Shapes;

namespace WpfApp5.presentation.views
{
    /// <summary>
    /// Interaction logic for ChangeDataUser.xaml
    /// </summary>
    public partial class ChangeDataUser : Window
    {
        public ChangeDataUser()
        {
            InitializeComponent();
        }
        private void Save_Click(object sender, RoutedEventArgs e)
        {
            string Tên = Name.Text;
            int userID = int.Parse(ID.Text);
            string Giới_tính = Gender.Text;
            int SĐT = int.Parse(Telephone.Text);
            string Vai_trò = Role.Text;

            // TODO: Xử lý lưu thông tin người dùng vào cơ sở dữ liệu hoặc hệ thống
            MessageBox.Show("Thông tin người dùng đã được cập nhật thành công!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);

        }
    }
}
