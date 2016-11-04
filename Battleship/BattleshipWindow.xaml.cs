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
    /// Interaction logic for BattleshipWindow.xaml
    /// </summary>
    public partial class BattleshipWindow : Window
    {
        public BattleshipWindow()
        {
            InitializeComponent();
        }

        private void stats_Click(object sender, RoutedEventArgs e)
        {
            Window stats = new StatsWindow();
            stats.Show();
        }

        private void settings_Click(object sender, RoutedEventArgs e)
        {
            Window settings = new SettingsWindow();
            settings.Show();
        }

        private void users_Click(object sender, RoutedEventArgs e)
        {
            Window users = new UserWindow();
            users.Show();
        }

        private void loadGame_Click(object sender, RoutedEventArgs e)
        {
            Window game = new GameWindow();
            game.Show();
        }

        private void play_Click(object sender, RoutedEventArgs e)
        {
            Window loadout = new SelectLoadoutWindow();
            loadout.Show();
        }
    }
}
