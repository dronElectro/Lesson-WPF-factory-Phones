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

namespace WpfApp10
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<Phone> list = new List<Phone>()
            {
                new Smartphone("Nokia", 1000, "3310", 55),
                new Smartphone("SonyErricsson", 1200, "k740i", 24),
                new CameraPhone() 
            };

            try
            {
                PhoneFactory factory = new PhoneFactory(list);
                Phone test = factory.CreatePhone(3);

                //CameraPhone cam = (CameraPhone)test;
                MessageBox.Show(test.Call(15));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
