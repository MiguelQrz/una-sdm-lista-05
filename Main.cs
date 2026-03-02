using static System.Console;
try {
WriteLine("Digite um usuário para consultar no github: ");
string user = ReadLine().Trim()!;
WriteLine($"Consultando o usuário ({user})...");
var client = new HttpClient();
client.DefaultRequestHeaders.UserAgent.TryParseAdd("request");
var response = await client.GetAsync($"https://api.github.com/user/{user}");
response.EnsureSuccessStatusCode();
var content = await response.Content.ReadAsStringAsync();
var userInfo = System.Text.Json.JsonSerializer.Deserialize<ConsumerGithubUser.models.UserModel>(content);
if (userInfo != null)
{
    WriteLine($"Nome: {userInfo.Name}");
    WriteLine($"Empresa: {userInfo.Company}");
    WriteLine($"Localização: {userInfo.Local}");
    WriteLine($"Login: {userInfo.Login}");
    }
}
catch (Exception e)
{
    WriteLine($"Um erro ocorreu. Tente novamente. Detalhes: {e.Message}");
}