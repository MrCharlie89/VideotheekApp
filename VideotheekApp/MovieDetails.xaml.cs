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
using VideotheekApp.LIB.Entities;

namespace VideotheekApp
{
    /// <summary>
    /// Interaction logic for MovieDetails.xaml
    /// </summary>
    public partial class MovieDetails : UserControl
    {
        private Movies model;

        public MovieDetails()
        {
            InitializeComponent();
        }

        public MovieDetails(Movies model)
        {
            this.model = model;
        }

        internal void Show()
        {
            throw new NotImplementedException();
        }
    }
}
