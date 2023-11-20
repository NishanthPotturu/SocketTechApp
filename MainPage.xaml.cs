

namespace SocketTechApp
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();


            NavigationPage.SetHasNavigationBar(this, false);

        }



        private void OnSubmitClicked(object sender, EventArgs e)
        {
            string username = usernameEntry.Text;
            string password = passwordEntry.Text;

            if (username == "User" && password == "Pass")
            {
                Navigation.PushAsync(new PlugHub());
            }
            else
            {
                DisplayAlert("Error", "Invalid username or password", "OK");
            }
        }
    }
}