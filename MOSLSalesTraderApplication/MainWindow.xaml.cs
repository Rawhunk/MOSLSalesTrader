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
            //this.Login = new LoginViewModel();
        }

        //public LoginViewModel Login
        //{
        //    get
        //    {
        //        return this.DataContext as LoginViewModel;
        //    }
        //    set
        //    {
        //        this.DataContext = value;
        //    }
        //}
    }
}
