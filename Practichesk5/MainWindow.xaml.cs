using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Practichesk5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent(); pair1 = new Pair(); pair2 = new Pair(); pair3 = new Pair();
        }
        Pair pair1; // Создание класса Pair для первой пары чисел
        Pair pair2; // Создание класса Pair для второй пары чисел
        Pair pair3; // Создание класса Pair для третьей пары чисел

        private void Pair1_Increment_Click(object sender, RoutedEventArgs e)// кнопка "Увеличить" для первой пары
        {
            int.TryParse(Pair1_1.Text, out int a);
            int.TryParse(Pair1_2.Text, out int b);
            pair1.SetParams(a,b);
            pair1.SetParams();
            Pair1_1.Text = pair1.first.ToString();
            Pair1_2.Text = pair1.second.ToString();
        }
        private void Pair1_decrement_Click(object sender, RoutedEventArgs e)// кнопка "Уменьшить" для первой пары
        {
            int.TryParse(Pair1_1.Text, out int a);
            int.TryParse(Pair1_2.Text, out int b);
            pair1.pairDecrement(a, b);
            pair1.pairDecrement();
            Pair1_1.Text = pair1.first.ToString();
            Pair1_2.Text = pair1.second.ToString();
        }

        private void Pair2_Increment_Click(object sender, RoutedEventArgs e)// кнопка "Увеличить" для второй пары
        {
            int.TryParse(Pair2_1.Text, out int a);
            int.TryParse(Pair2_2.Text, out int b);
            pair2.SetParams(a, b);
            pair2.SetParams();
            Pair2_1.Text = pair2.first.ToString();
            Pair2_2.Text = pair2.second.ToString();
        }
        private void Pair2_decrement_Click(object sender, RoutedEventArgs e)// кнопка "Уменьшить" для второй пары
        {
            int.TryParse(Pair2_1.Text, out int a);
            int.TryParse(Pair2_2.Text, out int b);
            pair1.pairDecrement(a, b);
            pair1.pairDecrement();
            Pair2_1.Text = pair1.first.ToString();
            Pair2_2.Text = pair1.second.ToString();
        }

        private void Pair1_SumRes_Click(object sender, RoutedEventArgs e)// Кнопка подсчета суммы первой пары
        {   
            int.TryParse(Pair1_1.Text,out int a);
            int.TryParse(Pair1_2.Text,out int b);
            pair1.SetParams(a,b);
            Pair1_Sum.Text = (pair1.first + pair1.second).ToString();


        }


        private void Sum_Click(object sender, RoutedEventArgs e)//Кнопка суммирования двух пар
        {   
            int.TryParse(Pair1_1.Text, out int a);
            int.TryParse(Pair1_2.Text, out int b);
            pair1.SetParams(a, b);
            int.TryParse(Pair2_1.Text, out int c);
            int.TryParse(Pair2_2.Text, out int d);
            pair2.SetParams(c,d);
            pair1.plus(pair2,out int res_part1, out int res_part2);
            Sum_pairs.Text = ( res_part1, res_part2).ToString();
        }
        private void Pair2_SumRes_Click_1(object sender, RoutedEventArgs e)// Кнопка подсчета суммы второй пары
        {
            int.TryParse(Pair2_1.Text, out int a);
            int.TryParse(Pair2_2.Text, out int b);
            pair2.SetParams(a, b);
            Pair2_Sum.Text = (pair2.first + pair2.second).ToString();
        }

        private void sum3Pairs_res_Click(object sender, RoutedEventArgs e)//Кнопка суммирования трех пар
        {
            int.TryParse(Pair1_1.Text, out int a);
            int.TryParse(Pair1_2.Text, out int b);
            pair1.SetParams(a, b);
            int.TryParse(Pair2_1.Text, out int c);
            int.TryParse(Pair2_2.Text, out int d);
            pair2.SetParams(c, d);
            int.TryParse(Pair3_1.Text, out int x);
            int.TryParse(Pair3_2.Text, out int z);
            pair3.SetParams(x, z);
            pair1.plus(pair2, pair3, out int res_part1, out int res_part2);
            Sum3_pairs.Text = (res_part1, res_part2).ToString();

        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void about_programm_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Выполнил Баукин Алексей Алексеевич , в 1:06 , \n Задание: Доработать класс разработанный в практической работе №5 по заданию. Оформить\r\nмодули комментариями.\n Использовать класс Pair (пара чисел). Разработать операцию сложения пар (а, b) +\r\n(с, d) = (а + c, b + d). Разработать операцию для уменьшения полей на 1.");
        }
    }
 }
