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
using MOSLSalesTraderApplication.Modules.Login;
using Telerik.Windows.Controls;

namespace MOSLSalesTraderApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : UserControl
    {
        public MainWindow()
        {
            InitializeComponent();           
        }

        //private void btnAuthenticate_Click(object sender, RoutedEventArgs e)
        //{
        //    MarketWatch te = new MarketWatch();
        //    te.Show();

        //    UIElement elelemnt = new UIElement();

        //    RadWindow window = elelemnt.GetVisualParent<RadWindow>();
        //    window.Close();
        //    //window.Show();

        //}
    }
}
