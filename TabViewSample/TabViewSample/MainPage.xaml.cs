using Syncfusion.XForms.TabView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace TabViewSample
{
    public partial class MainPage : ContentPage
    {
        ViewModel model = new ViewModel();
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = model;
            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);
        }

    }
    
}
