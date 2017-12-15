using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Xaml;
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
using VideotheekApp.LIB.BL;
using VideotheekApp.LIB.Entities;

namespace VideotheekApp
{
    /// <summary>
    /// Interaction logic for MovieOverview.xaml
    /// </summary>
    public partial class MovieOverview : UserControl
    {
        private ObservableCollection<Movies> dataSource;
        private void BindData()
        {
            dataSource = new ObservableCollection<Movies>(BL_Movies.GetAll());
            dataSource.CollectionChanged += DataSourceChanged;
            dgrdMovies.ItemsSource = dataSource;
            dgrdMovies.DataContext = dataSource;
        }

        private void DataSourceChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    foreach (Movies m in e.NewItems)
                        BL_Movies.Save(m);
                    break;

                case NotifyCollectionChangedAction.Remove:
                    foreach (Movies m in e.OldItems)
                        BL_Movies.Delete(m);
                    break;
            }
        }
        
        public MovieOverview()
        {
            InitializeComponent();

            BindData();
        }

        private void dgrdMovies_RowEditEnding(object sender, DataGridRowEditEndingEventArgs e)
        {
            DataGridRow _row = e.Row;
            var _changed = _row.DataContext as Movies;
            _changed.AvailableAmount = (int)_changed.Amount - _changed.ReservedAmount;

            BL_Movies.Save(_changed);

            BindData();
        }

        private void btnReserve(object sender, RoutedEventArgs e)
        {
            var obj = ((FrameworkElement)sender).DataContext as Movies;
            if (obj.AvailableAmount > 0)
            {
                if (obj.PEGI >= 18)
                {
                    if (MessageBox.Show("This is a PEGI 18 movie. Is the person renting this movie older than 18 year?", "Rent movie PEGI 18", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                    {
                        obj.ReservedAmount += 1;
                        obj.AvailableAmount = (int)obj.AvailableAmount - obj.ReservedAmount;
                    }
                }
                else
                {
                    obj.ReservedAmount += 1;
                    obj.AvailableAmount = (int)obj.AvailableAmount - obj.ReservedAmount;
                }
            }
            BL_Movies.Save(obj);
            BindData();
        }

        private void btnReturn(object sender, RoutedEventArgs e)
        {
            var obj = ((FrameworkElement)sender).DataContext as Movies;

            if (obj.ReservedAmount > 0)
            {
                obj.ReservedAmount -= 1;
                obj.AvailableAmount = (int)obj.Amount - obj.ReservedAmount;
            }

            BL_Movies.Save(obj);
            BindData();
        }

        private void btnDetails(object sender, RoutedEventArgs e)
        {
            var model = ((FrameworkElement)sender).DataContext as Movies;
            MovieDetails md = new MovieDetails(model);
            md.Show();
        }
    }
}
