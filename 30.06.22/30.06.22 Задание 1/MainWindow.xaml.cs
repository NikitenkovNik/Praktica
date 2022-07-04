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

namespace _30._06._22_Задание_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            scums.Add(new Criminal("Виктор Константинович Резнов", 180, 65, "Русский", true));
            scums.Add(new Criminal("Джон 'Сынок' Прайс", 174, 60, "Американец", true));
            scums.Add(new Criminal("Чижов Бiлк Мельнik", 171, 51, "Украинец", false));
            scums.Add(new Criminal("Виллем Ван Дер Берг", 181, 70, "Немец", false));
            scums.Add(new Criminal("Саймон 'Гоуст' Райли" , 181, 70, "Американец", true));
            scums.Add(new Criminal("Фомин Платон Саввич", 180, 67, "Поляк", true));
        }
        List<Criminal> scums = new List<Criminal>();

        private void BSearch_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                LB.Content = "";
                var Quary =
                    from Criminal in scums
                    where Criminal.Rost == Convert.ToDouble(TBrost.Text) &&
                    Criminal.Ves == Convert.ToDouble(TBves.Text) &&
                    Criminal.Naz == TBnaz.Text &&
                    !Criminal.Concluded
                    select Criminal;
                foreach (Criminal scum in Quary)
                {
                    LB.Content += scum.FIO + "\n" + scum.Rost + "\n" + scum.Ves + "\n" + scum.Naz + "\n";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
