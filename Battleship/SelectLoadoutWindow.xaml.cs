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
    /// Interaction logic for SelectLoadoutWindow.xaml
    /// </summary>
    public partial class SelectLoadoutWindow : Window
    {
        private String loadoutOne;
        private String loadoutTwo;
        private Users user;

        public SelectLoadoutWindow()
        {
            InitializeComponent();
        }

        public bool SetLoadoutOne(String ayyy)
        {
            return true;
        }

        public String getLoadoutOne()
        {
            return "ayyy";
        }

        public bool SetLoadoutTwo(String ayyy)
        {
            return true;
        }

        public String getLoadoutTwo()
        {
            return "ayyy";
        }

        private void radioButton_Checked(object sender, RoutedEventArgs e)
        {

        }
    }


}
