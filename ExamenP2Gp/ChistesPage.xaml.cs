using System.Net.Http;
using System.Text.Json;

namespace ExamenP2Gp
{
    public partial class ChistesPage : ContentPage
    {
        private readonly HttpClient _httpClient = new();

        public ChistesPage()
        {
            InitializeComponent();
            GetNewJoke(null, null);
        }

        private async void GetNewJoke(object sender, EventArgs e)
        {
            try
            {
                var response = await _httpClient.GetStringAsync("https://official-joke-api.appspot.com/random_joke");
                var joke = JsonSerializer.Deserialize<Joke>(response, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                if (joke != null)
                {
                    JokeLabel.Text = $"{joke.Setup}\n\n{joke.Punchline}";
                }
                else
                {
                    JokeLabel.Text = "No se pudo cargar el chiste.";
                }
            }
            catch
            {
                JokeLabel.Text = "Error al conectar con la API.";
            }
        }

        private class Joke
        {
            public string Setup { get; set; }
            public string Punchline { get; set; }
        }
    }
}
