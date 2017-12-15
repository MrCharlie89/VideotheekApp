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
using VideotheekApp.LIB.BL;
using VideotheekApp.LIB.DAL;
using VideotheekApp.LIB.DATA;
using VideotheekApp.LIB.Entities;

namespace VideotheekApp
{
    /// <summary>
    /// Interaction logic for MovieForm.xaml
    /// </summary>
    public partial class MovieForm : UserControl
    {
        bool validating;
        

        public delegate void ModelSavedEventHandler(Movies model);
        public event ModelSavedEventHandler OnModelSaved;

        /// public MovieForm()
        /// {
        ///   InitializeComponent();
        ///}
        public Movies Model { get; set; }

        public MovieForm() : this(new Movies()) { }

        public MovieForm(Movies model)
        {
            InitializeComponent();

            this.Model = model;

            grdMovieForm.DataContext = this;

            setTitle();
        }

        private void setTitle()
        {
            if (Model.IsNew())
            {
                Title.Content = "New movie";
            }
            else Title.Content = "Edit movie";
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            Verifying();
            if (validating == true)
            {
                if (Model.Amount == null)
                {
                    Model.Amount = 1;
                }
                if (BL_Movies.Save(Model))
                {
                    if (OnModelSaved != null)
                    {
                        OnModelSaved(Model);
                    }
                }
            }
        }
        private void Verifying()
        {
            validating = true;
            int valuePEGI;
            errMovieAmount.Content = errPEGI.Content = errMovieDescription.Content = errMovieTitle.Content = errMovieReleaseDate.Content = errMovieDuration.Content = errMovieGenre.Content = null;
            bool isPEGINumber;

            if (txtMovieTitle.Text == "")
            {
                errMovieTitle.Content = "the movie title can't be empty";
                validating = false;
            }

            if (txtMovieTitle.Text.Length > 255)
            {
                errMovieTitle.Content = "The movie title can't be longer than 255 characters";
                validating = false;
            }

            if (txtMovieDescription.Text == "")
            {
                errMovieDescription.Content = "You must give a description for this movie";
                validating = false;
            }

            if (txtMovieDuration.Text == "")
            {
                errMovieDuration.Content = "you must give the duration of this movie";
                validating = false;
            }

          

            if (txtMovieGenre.Text == "")
            {
                errMovieGenre.Content = "You need to give a genre for this movie";
                validating = false;
            }

            if (txtMovieReleaseDate.Text == "")
            {
                errMovieReleaseDate.Content = "Give the releasedate of this movie";
                validating = false;
            }

           
            if (txtPEGI.Text != "")
            {
                if (int.TryParse(txtPEGI.Text, out valuePEGI))
                {
                    isPEGINumber = true;
                }

                else
                {
                    errPEGI.Content = "You need to fill in a PEGI code";
                    validating = false;
                    isPEGINumber = false;
                }

                if (isPEGINumber == true && valuePEGI < 1 || valuePEGI > 18)
                {
                    errPEGI.Content = "The PEGI code must be between 1 and 18";
                    validating = false;
                }
            }

            if (txtMovieAmount.Text != "")
            {

                errMovieAmount.Content = "Yoe must give the number of copies for this movie";
            }
        }
       
    }

}
