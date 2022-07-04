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

namespace _30._06._22_Задание_2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            scums.Add(new Criminal("Климов Павел Семёнович", "Антиправительственное"));
            scums.Add(new Criminal("Билли Найтли", "Контрабанда"));
            scums.Add(new Criminal("Алексей Макаров", "Антиправительственное"));
            scums.Add(new Criminal("Санчез Монторэ", "Незаконное пересечение границы"));
            scums.Add(new Criminal("Соколов Игорь Всеволодович", "Антиправительственное"));
            foreach (Criminal scum in scums)
            {
                LB.Content += scum.FIO + "\n" + scum.Crime + "\n";
            }
        }
        List<Criminal> scums = new List<Criminal>();

        private void B1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                LB.Content = "";
                scums =
                    (from CriminalScum in scums
                     where CriminalScum.Crime != "Антиправительственное"
                     select CriminalScum).ToList();
                foreach (Criminal scum in scums)
                {
                    LB.Content += scum.FIO + "\n" + scum.Crime + "\n";
                }
                MessageBox.Show("Слава Арстоцке!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
