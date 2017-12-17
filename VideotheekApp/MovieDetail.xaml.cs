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
using System.Windows.Shapes;
using VideotheekApp.LIB.Entities;
using VideotheekApp.LIB.BL;

namespace VideotheekApp
{
    /// <summary>
    /// Interaction logic for MovieDetail.xaml
    /// </summary>
    public partial class MovieDetail : Window
    {
       
        public Movies Model { get; set; }

        public MovieDetail() : this(new Movies())
        {

        }

        public MovieDetail(Movies model)
        {
            InitializeComponent();
            this.Model = model;
            ShowDetails();
        }

        private void ShowDetails()
        {
            txtMovieTitle.Text = Model.Movie_Title;
            txtMovieDescription.Text = Model.Description;
            txtPEGI.Text = Model.PEGI.ToString();
            txtMovieDuration.Text = Model.Description;
            txtMovieReleaeDate.Text = Model.ReleaseDate.ToString();

        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
