using Xamarin.Forms;
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
        }
    }
}
