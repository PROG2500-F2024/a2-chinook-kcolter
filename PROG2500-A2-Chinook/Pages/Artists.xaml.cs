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
    /// Interaction logic for Artists.xaml
    /// </summary>
    public partial class Artists : Page
    {

        ChinookContext dbContext = new ChinookContext();
        CollectionViewSource artistsViewSource = new CollectionViewSource();    



        public Artists()
        {
            InitializeComponent();

            //tie viewsorce markup object to C# code object
            artistsViewSource = (CollectionViewSource)FindResource(nameof(artistsViewSource));

            //load data using dbcontext
            dbContext.Artists.Load();

            //set viewsource to use data
            artistsViewSource.Source = dbContext.Artists.Local.ToObservableCollection();
        }
    }
}
