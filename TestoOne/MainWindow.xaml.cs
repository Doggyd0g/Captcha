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

namespace TestoOne
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random rand = new Random();

        PolinaEntities DB = new PolinaEntities();   

        public MainWindow()
        {
            InitializeComponent();
            

        }

        private void Proverka_Click(object sender, RoutedEventArgs e)
        {
            if(TapeKap.Text == Kap.Text)
            {
                MessageBox.Show("You are cool", "Nice");
            }
            else
            {
                MessageBox.Show("You are nigger", "So bad");
            }
        }

        private void Generation_Click(object sender, RoutedEventArgs e)
        {
            
            Kap.Text = CreateCaptha(rand.Next(7, 10));
        }
        private string CreateCaptha(int length) {


            string alphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";


            string result = "";
            for (int i = 0; i < length; i++)
            {
                result = result + alphabet[rand.Next(0, alphabet.Length)];
            }
            return result;
        }
    }
}
