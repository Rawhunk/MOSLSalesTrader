using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Telerik.Windows.Controls;

namespace MOSLSalesTraderApplication.ViewModel
{
    public class LoginViewModel
    {
        private DelegateCommand cancelCommand;

        public DelegateCommand CancelCommand
        {
            get
            {
                return this.cancelCommand;
            }
            set
            {
                this.cancelCommand = value;
            }
        }

        public LoginViewModel()
        {
            this.cancelCommand = new DelegateCommand(this.CancelCommandExecuted);
        }

        private void CancelCommandExecuted(object parameter)
        {
            try
            {
                MarketWatch te = new MarketWatch();
                te.Show();

                UIElement elelemnt = parameter as UIElement;
                RadWindow window = elelemnt.GetVisualParent<RadWindow>();
                window.Close();
            }
            catch (Exception ex)
            {
            }

            //window.Show();
        }
    }
}
