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
    public partial class AddItemPage : ContentPage
    {
        public AddItemPage()
        {
            InitializeComponent();
        }

        private void btnInsert_Clicked(object sender, EventArgs e)
        {
            using (var db = new SQLiteConnection(ApplicationStatics.DBLocation))
            {
                db.CreateTable<Product>();
                var product = new Product()
                {
                    Name = txtProductName.Text,
                    Count = Convert.ToInt32(txtProductCount.Text),
                    Price = Convert.ToInt32(txtProductPrice.Text)
                };
                if (db.Insert(product) != 0)
                {
                    DisplayAlert("Done", "Product inserted successfully", "OK");
                }
                else
                {
                    DisplayAlert("Err", "Failed", "OK");
                }
            }
        }
    }
}