using Xamarin.Forms;
using XamGridViewForms.Models;
using XamGridViewForms.ViewModels;

namespace XamGridViewForms
{
    public partial class XamGridViewFormsPage : ContentPage
    {
        public XamGridViewFormsPage()
        {
            InitializeComponent();
            BindingContext = new XamGridViewViewModel();

            navAdd.Clicked += (sender, e) => {
                Device.OpenUri(new System.Uri("https://github.com/Xamarin-Harshad/XamGridViewForms"));
            };


			GrdView.ItemSelected += async (object sender, object e) =>
			{
				var currentModel = e as XamGridModel;
				await App.Current.MainPage.DisplayAlert("Clicked", "Current image position is " + currentModel.Position, "OK");
			};
        }
    }
}
