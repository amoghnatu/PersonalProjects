using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using KnowMyCar.Models;
using KnowMyCar_POC.Business_Services;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace KnowMyCar_POC.Pages.SearchResults
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainSearchResults : Page
    {
        ICarBusinessServices carBusiness = null;
        List<Car> carsList = null;
        public MainSearchResults()
        {
            this.InitializeComponent();
            carBusiness = new CarBusinessServices();
            this.LoadCars();
        }

        private void LoadCars()
        {
            carsList = carBusiness.GetCarsList();
            lstViewSearchResults.ItemsSource = carsList;
        }
    }
}
