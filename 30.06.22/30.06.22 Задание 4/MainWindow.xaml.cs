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

namespace _30._06._22_Задание_4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            players.Add(new Player("Arabic-Dev95", 100, 100));
            players.Add(new Player("lvlHindu", 45, 30));
            players.Add(new Player("MrVolt", 47, 40));
            players.Add(new Player("Sosiska_337", 67, 48));
            players.Add(new Player("BaraBere", 90, 88));
            players.Add(new Player("Kot&RKrot", 1, 10));
            players.Add(new Player("HeroOfCyberWorld", 5, 15));
            players.Add(new Player("NonoColl", 22, 34));
            players.Add(new Player("Nnislinaliss", 39, 50));
            players.Add(new Player("Naloosephy", 80, 100));
            foreach (Player player in players)
            {
                LB.Content += player.Name + " Сила: " + player.Strong + " Уровень: " + player.Lvl + "\n";
            }
        }
        List<Player> players = new List<Player>();

        private void BStrong_Click(object sender, RoutedEventArgs e)
        {
            LB.Content = "";
            var Quary =
                from plaer in players
                orderby plaer.Strong descending
                select plaer;
            int counter = 0;
            foreach (Player player in Quary)
            {
                LB.Content += player.Name + " Сила: " + player.Strong + " Уровень: " + player.Lvl + "\n";
                counter++;
                if (counter == 3)
                    break;
            }
        }

        private void B1_Click(object sender, RoutedEventArgs e)
        {
            LB.Content = "";
            foreach (Player player in players)
            {
                LB.Content += player.Name + " Сила: " + player.Strong + " Уровень: " + player.Lvl + "\n";
            }
        }

        private void BLvl_Click(object sender, RoutedEventArgs e)
        {
            LB.Content = "";
            var Quary =
                from plaer in players
                orderby plaer.Lvl descending
                select plaer;
            int counter = 0;
            foreach (Player player in Quary)
            {
                LB.Content += player.Name + " Сила: " + player.Strong + " Уровень: " + player.Lvl + "\n";
                counter++;
                if (counter == 3)
                    break;
            }
        }
    }
}
