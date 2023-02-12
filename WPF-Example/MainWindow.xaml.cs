using ControlzEx.Theming;
using MahApps.Metro.Theming;
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

namespace WPF_Example
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MahApps.Metro.Controls.MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            //ThemeManager.Current.ChangeTheme(this, "Dark.Green");
           
            var theme = ThemeManager.Current.AddLibraryTheme(
            new LibraryTheme(
                new Uri("pack://application:,,,/WPF-Example;component/CustomDarkAccent.xaml"),
                MahAppsLibraryThemeProvider.DefaultInstance
                )
            );

            ThemeManager.Current.ChangeTheme(this, theme);
        }

        private void btnExample_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(DateTime.Now.ToString("yyyy-MM-dd\n\rHH:mm:ss"));
        }
    }
}
