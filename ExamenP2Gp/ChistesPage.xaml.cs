namespace ExamenP2Gp;

public partial class ChistesPage : ContentPage
{
    HttpClient _client = new();

    public ChistesPage()
    {
        InitializeComponent();
        CargarChiste();
    }

    private void InitializeComponent()
    {
        throw new NotImplementedException();
    }

    private async void CargarChiste()
    {
        try
        {
            var response = await _client.GetStringAsync("https://official-joke-api.appspot.com/random_joke");
            var chiste = System.Text.Json.JsonSerializer.Deserialize<Chiste>(response);
            JokeLabel.Text = $"{chiste.setup}\n{chiste.punchline}";
        }
        catch (Exception)
        {
            JokeLabel.Text = "Error al cargar el chiste.";
        }
    }

    private void OnOtroChisteClicked(object sender, EventArgs e)
    {
        CargarChiste();
    }

    public class Chiste
    {
        public string setup { get; set; }
        public string punchline { get; set; }
    }
}
