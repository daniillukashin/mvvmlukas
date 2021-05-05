using Xamarin.Forms;
using mvvmlukas.ViewModels;

namespace mvvmlukas.Views
{
    public partial class FriendsListPage : ContentPage
    {
        public FriendsListPage()
        {
            InitializeComponent();
            BindingContext = new FriendsListViewModel() { Navigation = this.Navigation };
        }
    }
}