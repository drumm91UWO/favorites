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

namespace Battleship
{
    /// <summary>
    /// Interaction logic for UserWindow.xaml
    /// </summary>
    public partial class UserWindow : Window
    {
        public UserWindow()
        {
            InitializeComponent();
        }

        private void AddFriend_Click(object sender, RoutedEventArgs e)
        {
            //TODO find friend in database and if they exist make a button for friend
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            //TODO get username from textbox
        }
    }
}
