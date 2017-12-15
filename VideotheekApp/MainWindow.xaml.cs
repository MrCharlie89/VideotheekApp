using System;
using System.Windows;
using System.Windows.Controls.Ribbon;
using System.ComponentModel;
using System.Xaml;


namespace VideotheekApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : RibbonWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            SetTitle();
        }

        private void SetTitle(string label = null)
        {
            try
            {
                string _title = "";

                if (!string.IsNullOrWhiteSpace(label))
                {
                    _title += label + " - ";

                    this.Title = _title;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void SetTitleByRibbonButton(object sender)
        {
            try
            {
                SetTitle(((RibbonButton)sender).Label);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void MainScreen_Closing(object sender, CancelEventArgs e)
        {
            e.Cancel = MessageBox.Show("Are you sure you want to exit the application?", "Exit application", MessageBoxButton.YesNo) == MessageBoxResult.No;

        }

        private void ramiExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnMovieOverview_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SetTitleByRibbonButton(sender);

                mainContent.Content = new MovieOverview();
            }
            catch (Exception)
            {

                throw;

            }
        }

        private void btnMovieAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SetTitleByRibbonButton(sender);
                mainContent.Content = new MovieForm();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}


