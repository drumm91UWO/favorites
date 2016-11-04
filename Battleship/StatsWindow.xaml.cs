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
    /// Interaction logic for StatsWindow.xaml
    /// </summary>
    public partial class StatsWindow : Window
    {
        public StatsWindow()
        {
            InitializeComponent();
        }

        public int GetShipsSank()
        {
            return 0;
        }

        public int GetGamesWon()
        {
            return 0;
        }

        public int GetGamesLost()
        {
            return 0;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            //hai
        }
    }
}
