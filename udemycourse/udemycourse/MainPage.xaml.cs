using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universities.Classes;
using Xamarin.Forms;


namespace udemycourse
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }



        private void saveButton_Clicked(object sender, EventArgs e)
        {
            University university = new University()
            {
                Name = NameEntry.Text,
                A = aEntry.Text,
                B = bEntry.Text,
                C = cEntry.Text,
                D = dEntry.Text
            };

            //using using so that we dont accenently leave it open
            using (SQLiteConnection conn = new SQLiteConnection(App.FilePath))
            {
                conn.CreateTable<University>();
                int RowsAdded = conn.Insert(university);

            }
        }


    }
}
