using Microsoft.EntityFrameworkCore;
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

namespace PROG2500_A2_Chinook.Pages
{
    /// <summary>
    /// Interaction logic for Albums.xaml
    /// </summary>
    public partial class Albums : Page
    {
        Data.ChinookContext dbContext = new Data.ChinookContext();
        CollectionViewSource albumsViewSource = new CollectionViewSource();
        public Albums()
        {
            InitializeComponent();

            //tie viewsorce markup object to C# code object
            albumsViewSource = (CollectionViewSource)FindResource(nameof(albumsViewSource));

            //load data using dbcontext
            dbContext.Albums.Load();

            //set viewsource to use data
            albumsViewSource.Source = dbContext.Albums.Local.ToObservableCollection();
        }
    }
}
