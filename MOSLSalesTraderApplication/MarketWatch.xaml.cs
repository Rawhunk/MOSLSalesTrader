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
using Telerik.Windows.Controls;

namespace MOSLSalesTraderApplication
{
    /// <summary>
    /// Interaction logic for MarketWatch.xaml
    /// </summary>
    public partial class MarketWatch : Window
    {
        public MarketWatch()
        {
            //MarketWatch mainWindow = new MarketWatch();
            //CreateDynamicWPFGrid(mainWindow);
            InitializeComponent();
            
        }

        private void MarketWatch_Loaded(object sender, RoutedEventArgs e)
        {
            CreateDynamicWPFGrid();
            // Create the Grid
            //Grid DynamicGrid = new Grid();
            //myGrid.Width = SystemParameters.VirtualScreenWidth;
            //myGrid.Height = SystemParameters.VirtualScreenWidth;
            //myGrid.HorizontalAlignment = HorizontalAlignment.Center;
            //myGrid.VerticalAlignment = VerticalAlignment.Center;
            //myGrid.ShowGridLines = true;
            ////myGrid.Background = new SolidColorBrush(Colors.LightSteelBlue);


            //// Create Columns
            //ColumnDefinition gridCol1 = new ColumnDefinition();
            //gridCol1.Width = new GridLength(100);
            //ColumnDefinition gridCol2 = new ColumnDefinition();
            //gridCol2.Width = new GridLength(100);
            //ColumnDefinition gridCol3 = new ColumnDefinition();
            //gridCol3.Width = new GridLength(200);
            //myGrid.ColumnDefinitions.Add(gridCol1);
            //myGrid.ColumnDefinitions.Add(gridCol2);
            //myGrid.ColumnDefinitions.Add(gridCol3);

            //// Create Rows
            //RowDefinition gridRow1 = new RowDefinition();
            //gridRow1.Height = new GridLength(10);
            //RowDefinition gridRow2 = new RowDefinition();
            //gridRow2.Height = GridLength.Auto;
            ////RowDefinition gridRow3 = new RowDefinition();
            ////gridRow3.Height = new GridLength(200);
            ////RowDefinition gridRow4 = new RowDefinition();
            ////gridRow4.Height = new GridLength(200);
            ////myGrid.RowDefinitions.Add(gridRow1);
            ////myGrid.RowDefinitions.Add(gridRow2);
            ////myGrid.RowDefinitions.Add(gridRow3);
            ////myGrid.RowDefinitions.Add(gridRow4);

            //// Add first column header
            //TextBlock txtBlock1 = new TextBlock();
            //txtBlock1.Text = "Author Name";
            //txtBlock1.FontSize = 12;
            //txtBlock1.FontWeight = FontWeights.Bold;
            //txtBlock1.Foreground = new SolidColorBrush(Colors.White);
            //txtBlock1.VerticalAlignment = VerticalAlignment.Bottom;
            //txtBlock1.HorizontalAlignment = HorizontalAlignment.Left;
            //txtBlock1.Margin = new Thickness(5, 5, 5, 5);
            //txtBlock1.Height = 50;
            //Grid.SetRow(txtBlock1, 1);
            //Grid.SetColumn(txtBlock1, 0);
            //myGrid.Children.Add(txtBlock1);

            //// Add second column header
            ////TextBlock txtBlock2 = new TextBlock();
            ////txtBlock2.Text = "Age";
            ////txtBlock2.FontSize = 14;
            ////txtBlock2.FontWeight = FontWeights.Bold;
            ////txtBlock2.Foreground = new SolidColorBrush(Colors.White);
            ////txtBlock2.VerticalAlignment = VerticalAlignment.Center;
            ////txtBlock2.HorizontalAlignment = HorizontalAlignment.Center;
            ////Grid.SetRow(txtBlock2, 1);
            ////Grid.SetColumn(txtBlock2, 1);

            //// Add third column header
            ////TextBlock txtBlock3 = new TextBlock();
            ////txtBlock3.Text = "Book";
            ////txtBlock3.FontSize = 14;
            ////txtBlock3.FontWeight = FontWeights.Bold;
            ////txtBlock3.Foreground = new SolidColorBrush(Colors.White);
            ////txtBlock3.VerticalAlignment = VerticalAlignment.Center;
            ////txtBlock3.HorizontalAlignment = HorizontalAlignment.Center;
            ////Grid.SetRow(txtBlock3, 1);
            ////Grid.SetColumn(txtBlock3, 2);

            ////// Add column headers to the Grid
            ////myGrid.Children.Add(txtBlock1);
            ////myGrid.Children.Add(txtBlock2);
            ////myGrid.Children.Add(txtBlock3);

            //// Create first Row
            ////TextBlock authorText = new TextBlock();
            ////authorText.Text = "Mahesh Chand";
            ////authorText.FontSize = 12;
            ////authorText.FontWeight = FontWeights.Bold;
            ////Grid.SetRow(authorText, 2);
            ////Grid.SetColumn(authorText, 0);

            ////TextBlock ageText = new TextBlock();
            ////ageText.Text = "33";
            ////ageText.FontSize = 12;
            ////ageText.FontWeight = FontWeights.Bold;
            ////Grid.SetRow(ageText, 2);
            ////Grid.SetColumn(ageText, 1);

            ////TextBlock bookText = new TextBlock();
            ////bookText.Text = "GDI+ Programming";
            ////bookText.FontSize = 12;
            ////bookText.FontWeight = FontWeights.Bold;
            ////Grid.SetRow(bookText, 2);
            ////Grid.SetColumn(bookText, 2);
            ////// Add first row to Grid
            ////myGrid.Children.Add(authorText);
            ////myGrid.Children.Add(ageText);
            ////myGrid.Children.Add(bookText);

            ////// Create second row
            ////authorText = new TextBlock();
            ////authorText.Text = "Mike Gold";
            ////authorText.FontSize = 12;
            ////authorText.FontWeight = FontWeights.Bold;
            ////Grid.SetRow(authorText, 3);
            ////Grid.SetColumn(authorText, 0);

            ////ageText = new TextBlock();
            ////ageText.Text = "35";
            ////ageText.FontSize = 12;
            ////ageText.FontWeight = FontWeights.Bold;
            ////Grid.SetRow(ageText, 3);
            ////Grid.SetColumn(ageText, 1);

            ////bookText = new TextBlock();
            ////bookText.Text = "Programming C#";
            ////bookText.FontSize = 12;
            ////bookText.FontWeight = FontWeights.Bold;
            ////Grid.SetRow(bookText, 3);
            ////Grid.SetColumn(bookText, 2);

            //// Add second row to Grid
            ////myGrid.Children.Add(authorText);
            ////myGrid.Children.Add(ageText);
            ////myGrid.Children.Add(bookText);





        }

        private void CreateDynamicWPFGrid()
        {
            // Create the Grid
            //Grid DynamicGrid = new Grid();
            //myGrid.Width = 400;
            myGrid.Width = SystemParameters.VirtualScreenWidth;
            myGrid.Height = SystemParameters.VirtualScreenWidth;
            myGrid.HorizontalAlignment = HorizontalAlignment.Left;
            myGrid.VerticalAlignment = VerticalAlignment.Top;
            myGrid.ShowGridLines = true;
            myGrid.Background = new SolidColorBrush(Colors.LightSteelBlue);

            // Create Columns
            ColumnDefinition gridCol1 = new ColumnDefinition();
            ColumnDefinition gridCol2 = new ColumnDefinition();
            ColumnDefinition gridCol3 = new ColumnDefinition();
            myGrid.ColumnDefinitions.Add(gridCol1);
            myGrid.ColumnDefinitions.Add(gridCol2);
            myGrid.ColumnDefinitions.Add(gridCol3);

            // Create Rows
            RowDefinition gridRow1 = new RowDefinition();
            gridRow1.Height = new GridLength(45);
            RowDefinition gridRow2 = new RowDefinition();
            gridRow2.Height = new GridLength(45);
            RowDefinition gridRow3 = new RowDefinition();
            gridRow3.Height = new GridLength(45);
            RowDefinition gridRow4 = new RowDefinition();
            gridRow4.Height = new GridLength(45);
            RowDefinition gridRow5 = new RowDefinition();
            gridRow5.Height = new GridLength(45);
            myGrid.RowDefinitions.Add(gridRow1);
            myGrid.RowDefinitions.Add(gridRow2);
            myGrid.RowDefinitions.Add(gridRow3);
            myGrid.RowDefinitions.Add(gridRow4);
            myGrid.RowDefinitions.Add(gridRow5);

            // Add first column header
            TextBlock txtBlock1 = new TextBlock();
            txtBlock1.Text = "Author Name";
            txtBlock1.FontSize = 14;
            txtBlock1.FontWeight = FontWeights.Bold;
            txtBlock1.Foreground = new SolidColorBrush(Colors.White);
            txtBlock1.VerticalAlignment = VerticalAlignment.Top;
            Grid.SetRow(txtBlock1, 0);
            Grid.SetColumn(txtBlock1, 0);

            // Add second column header
            TextBlock txtBlock2 = new TextBlock();
            txtBlock2.Text = "Age";
            txtBlock2.FontSize = 14;
            txtBlock2.FontWeight = FontWeights.Bold;
            txtBlock2.Foreground = new SolidColorBrush(Colors.White);
            txtBlock2.VerticalAlignment = VerticalAlignment.Top;
            Grid.SetRow(txtBlock2, 0);
            Grid.SetColumn(txtBlock2, 1);

            // Add third column header
            TextBlock txtBlock3 = new TextBlock();
            txtBlock3.Text = "Book";
            txtBlock3.FontSize = 14;
            txtBlock3.FontWeight = FontWeights.Bold;
            txtBlock3.Foreground = new SolidColorBrush(Colors.White);
            txtBlock3.VerticalAlignment = VerticalAlignment.Top;
            Grid.SetRow(txtBlock3, 0);
            Grid.SetColumn(txtBlock3, 2);

            //// Add column headers to the Grid
            myGrid.Children.Add(txtBlock1);
            myGrid.Children.Add(txtBlock2);
            myGrid.Children.Add(txtBlock3);

            // Create first Row
            TextBlock authorText = new TextBlock();
            authorText.Text = "Mahesh Chand";
            authorText.FontSize = 12;
            authorText.FontWeight = FontWeights.Bold;
            authorText.Foreground = new SolidColorBrush(Colors.White);
            Grid.SetRow(authorText, 1);
            Grid.SetColumn(authorText, 0);

            TextBlock ageText = new TextBlock();
            ageText.Text = "33";
            ageText.FontSize = 12;
            ageText.FontWeight = FontWeights.Bold;
            ageText.Foreground = new SolidColorBrush(Colors.White);
            Grid.SetRow(ageText, 1);
            Grid.SetColumn(ageText, 1);

            TextBlock bookText = new TextBlock();
            bookText.Text = "GDI+ Programming";
            bookText.FontSize = 12;
            bookText.FontWeight = FontWeights.Bold;
            bookText.Foreground = new SolidColorBrush(Colors.White);
            Grid.SetRow(bookText, 1);
            Grid.SetColumn(bookText, 2);
            // Add first row to Grid
            myGrid.Children.Add(authorText);
            myGrid.Children.Add(ageText);
            myGrid.Children.Add(bookText);   
  
        }
    }
}
