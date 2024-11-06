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
    /// Interaction logic for Tracks.xaml
    /// </summary>
    public partial class Tracks : Page
    {
        Data.ChinookContext dbContext = new Data.ChinookContext();
        CollectionViewSource tracksViewSource = new CollectionViewSource();

        public Tracks()
        {
            InitializeComponent();

            //tie viewsorce markup object to C# code object
            tracksViewSource = (CollectionViewSource)FindResource(nameof(tracksViewSource));

            //load data using dbcontext
            dbContext.Tracks.Load();

            //set viewsource to use data
            tracksViewSource.Source = dbContext.Tracks.Local.ToObservableCollection();
        }
    }
}
