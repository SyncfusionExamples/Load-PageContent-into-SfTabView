using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Syncfusion.XForms.TabView;
using Xamarin.Forms;

namespace TabViewSample
{
    public class ViewModel : INotifyPropertyChanged
    {
        private TabItemCollection items;
        public event PropertyChangedEventHandler PropertyChanged;
        public TabItemCollection Items
        {
            get { return items; }
            set
            {
                items = value;
                OnPropertyChanged("Items");
            }
        }
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public ViewModel()
        {
            SetItems();

        }
        internal void SetItems()
        {
            Items = new TabItemCollection();
            TabViewItemPage1 page1 = new TabViewItemPage1();
            TabViewItemPage2 page2 = new TabViewItemPage2();
            TabViewItemPage3 page3 = new TabViewItemPage3();
            TabViewItemPage4 page4 = new TabViewItemPage4();
            Items.Add(new SfTabItem { Content = page1.Content, Title = "Page1" });
            Items.Add(new SfTabItem { Content = page2.Content, Title = "Page2" });
            Items.Add(new SfTabItem { Content = page3.Content, Title = "Page3" });
            Items.Add(new SfTabItem { Content = page4.Content, Title = "Page4" });

        }

    }

}

