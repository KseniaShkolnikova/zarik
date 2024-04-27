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

namespace pract6Kalendar
{
    /// <summary>
    /// Логика взаимодействия для carts.xaml
    /// </summary>
    public partial class carts : UserControl
    {
        DateTime date1 = DateTime.Now;
        public carts(DateTime date)
        {
            InitializeComponent();
            date1 = date;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            open_check();
        }
        private void Clear_Click(object sender, RoutedEventArgs e)
        {

        }
        private void See_Click(object sender, RoutedEventArgs e)
        {
            open_check();
        }
        private void open_check()
        {
            // открыть страницу выбора (вот чекни полная пизда и я эту зуйню главное понимаю) 
            Window window = Window.GetWindow(this);
            Frame frame = (Frame)window.FindName("frame");
            Menu_change menu_Change = new Menu_change();
            frame.Content = menu_Change;
            TextBlock textbloi = (TextBlock)window.FindName("date_txtblc");
            textbloi.Text = date.Text + " " + date1.ToString("Y");
            // анимация

        }
        
    }
}
