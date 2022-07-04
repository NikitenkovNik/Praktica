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

namespace _30._06._22_Задание_6
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SV.HorizontalScrollBarVisibility = ScrollBarVisibility.Visible;
            solders.Add(new Soilder("Ларионов Фёдор Иванович", "АК-74М", "Солдат", 5));
            solders.Add(new Soilder("Климов Марк Тимурович", "АК-74М", "Матрос", 3));
            solders.Add(new Soilder("Медведев Илья Билалович", "АК-12", "Сержант", 10));
            solders.Add(new Soilder("Журавлев Иван Михайлович", "СВДМ", "Старший сержант", 12));
            solders.Add(new Soilder("Виноградов Никита Дамирович", "АКС-74У", "Солдат", 6));
            foreach (Soilder solder in solders)
            {
                LB.Content += solder.FIO + " Вооружение: " + solder.Armament + " Звание: " + solder.Title + " Срок службы: " + solder.Srok + "\n";
            }
        }
        List<Soilder> solders = new List<Soilder>();

        private void BSearch_Click(object sender, RoutedEventArgs e)
        {
            LB.Content = "";
            var Quary =
                 from solder in solders
                 select solder.FIO + " " + solder.Title;
            foreach (var solder in Quary)
            {
                LB.Content += solder + "\n";//solder.FIO + " Вооружение: " + solder.Armament + " Звание: " + solder.Title + " Срок службы: " + solder.Srok + "\n";
            }
        }

        private void B1_Click(object sender, RoutedEventArgs e)
        {
            LB.Content = "";
            foreach (Soilder solder in solders)
            {
                LB.Content += solder.FIO + " Вооружение: " + solder.Armament + " Звание: " + solder.Title + " Срок службы: " + solder.Srok + "\n";
            }
        }
    }
}