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

namespace MoneyChecker
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //private ToggleB

        public MainWindow()
        {
            InitializeComponent();
            HideAllComboBoxes();
          
        }

        private void HideAllComboBoxes()
        {
            ComboBox_Invoices.Visibility = Visibility.Collapsed;
            ComboBox_Grouping.Visibility = Visibility.Collapsed;
            ComboBox_View.Visibility = Visibility.Collapsed;
            ComboBox_Filtr.Visibility = Visibility.Collapsed;
            ComboBox_Graph.Visibility = Visibility.Collapsed;
            ComboBox_Interval.Visibility = Visibility.Collapsed;
            ComboBox_Legend.Visibility = Visibility.Collapsed; 
        }

        private void ButtonResearch_Click(object sender, RoutedEventArgs e)
        {
            HideAllComboBoxes();
            ComboBox_Grouping.Visibility = Visibility.Visible;
            ComboBox_View.Visibility = Visibility.Visible;

        }

        private void ButtonMoneyTransfer_Click(object sender, RoutedEventArgs e)
        {
            HideAllComboBoxes();
            ComboBox_Grouping.Visibility = Visibility.Visible;
            
        }

        private void ButtonCalendar_Click(object sender, RoutedEventArgs e)
        {
            HideAllComboBoxes();
            ComboBox_Invoices.Visibility = Visibility.Visible;
            ComboBox_Grouping.Visibility = Visibility.Visible;
            ComboBox_View.Visibility = Visibility.Visible;
            ComboBox_Filtr.Visibility = Visibility.Visible;          

        }

        private void ButtonSchedule_Click(object sender, RoutedEventArgs e)
        {
            HideAllComboBoxes();

        }

        private void ButtonEvent_Click(object sender, RoutedEventArgs e)
        {
            HideAllComboBoxes();
        }

        private void ButtonBudget_Click(object sender, RoutedEventArgs e)
        {
            HideAllComboBoxes();
        }

        private void ButtonDebt_Click(object sender, RoutedEventArgs e)
        {
            HideAllComboBoxes();
        }

        private void ButtonReport_Click(object sender, RoutedEventArgs e)
        {
            HideAllComboBoxes();
            ComboBox_Invoices.Visibility = Visibility.Visible;
            ComboBox_Grouping.Visibility = Visibility.Visible;
            ComboBox_View.Visibility = Visibility.Visible;
            ComboBox_Filtr.Visibility = Visibility.Visible;
            ComboBox_Legend.Visibility = Visibility.Visible;

        }

        private void ButtonCurrencies_Click(object sender, RoutedEventArgs e)
        {
            HideAllComboBoxes();
        }

        private void ButtonInvoices_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonCategories_Click(object sender, RoutedEventArgs e)
        {
            HideAllComboBoxes();
        }

        private void ButtonUsers_Click(object sender, RoutedEventArgs e)
        {
            HideAllComboBoxes();
        }

        private void ButtonSettings_Click(object sender, RoutedEventArgs e)
        {
            HideAllComboBoxes();
        }

        private void MainWindow1_Loaded(object sender, RoutedEventArgs e)
        {
            LicenseWindow licenseWindow = new LicenseWindow();
            licenseWindow.ShowDialog(); //запуск в режиме модальное окно
        }
    }
}
