using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace udemycourse
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UniversityPage : ContentPage
    {
        public UniversityPage()
        {
            InitializeComponent();
        }

        private void newContextToolbarItem_clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());

        }
    }
}