﻿using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace MOSL.SalesTrader.DynamicGrid
{
    public class GenerateDynamicGrid
    {

        Grid DynamicGrid = new Grid();

        public void gridGenerate()
        {
            DynamicGrid.Width = 400;
            DynamicGrid.HorizontalAlignment = HorizontalAlignment.Left;
            DynamicGrid.VerticalAlignment = VerticalAlignment.Top;
            DynamicGrid.ShowGridLines = true;
            DynamicGrid.Background = new SolidColorBrush(Colors.LightSteelBlue);

            // Create Columns
            ColumnDefinition gridCol1 = new ColumnDefinition();
            ColumnDefinition gridCol2 = new ColumnDefinition();
            ColumnDefinition gridCol3 = new ColumnDefinition();
            DynamicGrid.ColumnDefinitions.Add(gridCol1);
            DynamicGrid.ColumnDefinitions.Add(gridCol2);
            DynamicGrid.ColumnDefinitions.Add(gridCol3);

            // Create Rows
            RowDefinition gridRow1 = new RowDefinition();
            gridRow1.Height = new GridLength(45);
            RowDefinition gridRow2 = new RowDefinition();
            gridRow2.Height = new GridLength(45);
            RowDefinition gridRow3 = new RowDefinition();
            gridRow3.Height = new GridLength(45);
            DynamicGrid.RowDefinitions.Add(gridRow1);
            DynamicGrid.RowDefinitions.Add(gridRow2);
            DynamicGrid.RowDefinitions.Add(gridRow3);

            // Add first column header
            TextBlock txtBlock1 = new TextBlock();
            txtBlock1.Text = "Author Name";
            txtBlock1.FontSize = 14;
            txtBlock1.FontWeight = FontWeights.Bold;
            txtBlock1.Foreground = new SolidColorBrush(Colors.Green);
            txtBlock1.VerticalAlignment = VerticalAlignment.Top;
            Grid.SetRow(txtBlock1, 0);
            Grid.SetColumn(txtBlock1, 0);

            // Add second column header
            TextBlock txtBlock2 = new TextBlock();
            txtBlock2.Text = "Age";
            txtBlock2.FontSize = 14;
            txtBlock2.FontWeight = FontWeights.Bold;
            txtBlock2.Foreground = new SolidColorBrush(Colors.Green);
            txtBlock2.VerticalAlignment = VerticalAlignment.Top;
            Grid.SetRow(txtBlock2, 0);
            Grid.SetColumn(txtBlock2, 1);

            // Add third column header
            TextBlock txtBlock3 = new TextBlock();
            txtBlock3.Text = "Book";
            txtBlock3.FontSize = 14;
            txtBlock3.FontWeight = FontWeights.Bold;
            txtBlock3.Foreground = new SolidColorBrush(Colors.Green);
            txtBlock3.VerticalAlignment = VerticalAlignment.Top;
            Grid.SetRow(txtBlock3, 0);
            Grid.SetColumn(txtBlock3, 2);

            //// Add column headers to the Grid
            DynamicGrid.Children.Add(txtBlock1);
            DynamicGrid.Children.Add(txtBlock2);
            DynamicGrid.Children.Add(txtBlock3);

            // Create first Row
            TextBlock authorText = new TextBlock();
            authorText.Text = "Mahesh Chand";
            authorText.FontSize = 12;
            authorText.FontWeight = FontWeights.Bold;
            Grid.SetRow(authorText, 1);
            Grid.SetColumn(authorText, 0);

            TextBlock ageText = new TextBlock();
            ageText.Text = "33";
            ageText.FontSize = 12;
            ageText.FontWeight = FontWeights.Bold;
            Grid.SetRow(ageText, 1);
            Grid.SetColumn(ageText, 1);

            TextBlock bookText = new TextBlock();
            bookText.Text = "GDI+ Programming";
            bookText.FontSize = 12;
            bookText.FontWeight = FontWeights.Bold;
            Grid.SetRow(bookText, 1);
            Grid.SetColumn(bookText, 2);
            // Add first row to Grid
            DynamicGrid.Children.Add(authorText);
            DynamicGrid.Children.Add(ageText);
            DynamicGrid.Children.Add(bookText);

            // Create second row
            authorText = new TextBlock();
            authorText.Text = "Mike Gold";
            authorText.FontSize = 12;
            authorText.FontWeight = FontWeights.Bold;
            Grid.SetRow(authorText, 2);
            Grid.SetColumn(authorText, 0);

            ageText = new TextBlock();
            ageText.Text = "35";
            ageText.FontSize = 12;
            ageText.FontWeight = FontWeights.Bold;
            Grid.SetRow(ageText, 2);
            Grid.SetColumn(ageText, 1);

            bookText = new TextBlock();
            bookText.Text = "Programming C#";
            bookText.FontSize = 12;
            bookText.FontWeight = FontWeights.Bold;
            Grid.SetRow(bookText, 2);
            Grid.SetColumn(bookText, 2);

            // Add second row to Grid
            DynamicGrid.Children.Add(authorText);
            DynamicGrid.Children.Add(ageText);
            DynamicGrid.Children.Add(bookText);

           

        }
    }
}
