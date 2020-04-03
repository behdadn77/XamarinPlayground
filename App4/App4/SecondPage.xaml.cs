using App4.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App4
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SecondPage : ContentPage
    {
        public SecondPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            using (var db = new SQLiteConnection(ApplicationStatics.DBLocation))
            {
                db.CreateTable<Product>();
                lstProduct.ItemsSource = db.Table<Product>().ToList();
            }
        }
    }
}