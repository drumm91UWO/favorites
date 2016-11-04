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
    /// Interaction logic for ChatWindow.xaml
    /// </summary>
    public partial class ChatWindow : Window
    {

        private int senderId, receiverId, chatId;
        public ChatWindow()
        {
            InitializeComponent();
        }

        private void Message_TextChanged(object sender, TextChangedEventArgs e)
        {
            //get text that user typed in 
        }

        private void Send_Click(object sender, RoutedEventArgs e)
        {
            //Add text from Message text onto a new line in the MessageWindow textblock with username in front of it
        }
    }
}
