using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universities.Classes;
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

        protected override void OnAppearing()
        {
            base.OnAppearing();

            using(SQLiteConnection conn = new SQLiteConnection (App.FilePath))
            {
                conn.CreateTable<University>();
                var universities = conn.Table<University>().ToList();
                contactsListView.ItemsSource = universities;

            }
        }


    }
}