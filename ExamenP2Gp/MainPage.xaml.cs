namespace ExamenP2Gp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void GoToJokes(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//Chistes");
        }

        private async void GoToAbout(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//About");
        }

        private void ChisteButton_Clicked(object sender, EventArgs e)
        {

        }

        private void CounterBtn_Clicked(object sender, EventArgs e)
        {

        }
    }

}
