using ClassesApp;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Radio r;
        public MainWindow()
        {
            InitializeComponent();
            r = new Radio();
        }

        private void offButton(object sender, RoutedEventArgs e)
        {

            r.TurnOff();
            RadioOff.Text = "Radio off";

        }

        private void onButton(object sender, RoutedEventArgs e)
        {
            r.TurnOn();
            RadioOff.Text = $"{r.Play()}";
        }



        private void channel_1(object sender, RoutedEventArgs e)
        {
            r.Channel = 1;
            RadioOff.Text = $"{r.Play()}";
        }

        private void channel_2(object sender, RoutedEventArgs e)
        {
            r.Channel = 2;
            RadioOff.Text = $"{r.Play()}";


        }

        private void channel_3(object sender, RoutedEventArgs e)
        {
            r.Channel = 3;
            RadioOff.Text = $"{r.Play()}";
        }

        private void channel_4(object sender, RoutedEventArgs e)
        {
            r.Channel = 4;
            RadioOff.Text = $"{r.Play()}";
        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            r.Write();
             
        }

        

       

        private void Volume_Up(object sender, RoutedEventArgs e)
        {

            r.Volume += 1; 
            Volume.Text = $"{r.Volume}";

            




        }

        private void Volume_down(object sender, RoutedEventArgs e)
        {
          
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            r.Read();
        }

        private void Volume_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
