using System.Net;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;

namespace VetClinicMS.Logic;

public class LoginService
{
    private HttpClient client;

    public LoginService(string host)
    {
        var handler = new HttpClientHandler();
        handler.ClientCertificateOptions = ClientCertificateOption.Manual;
        handler.ServerCertificateCustomValidationCallback = 
            (httpRequestMessage, cert, cetChain, policyErrors) =>
            {
                return true;
            };
        client = new HttpClient(handler) {BaseAddress = new Uri(host)};

        Init();
    }

    private async void Init()
    {
        try
        {
            var user = new UserLogin("admin", "Admin_password1");
            var response = await client.PostAsJsonAsync("Users/login", user);
            if (!response.IsSuccessStatusCode) return;
            
            var responseBody = await response.Content.ReadFromJsonAsync<UserLoginResponce>();

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", responseBody!.token);

            var usersResponse = await client.GetAsync("Users");
            if (!usersResponse.IsSuccessStatusCode) return;

            var users = await usersResponse.Content.ReadFromJsonAsync<List<UserInfo>>();

            if (users!.Any(item => item.result.userName == "reg") &&
                users!.Any(item => item.result.userName == "vet") &&
                users!.Any(item => item.result.userName == "adminVet")) return;
            
            var newUser = new UserReg("reg", "reg", "reg");
            await client.PostAsJsonAsync("Users/register", newUser);
                
            newUser = new UserReg("vet", "vet", "vet");
            await client.PostAsJsonAsync("Users/register", newUser);
                
            newUser = new UserReg("adminVet", "adminVet", "admin");
            await client.PostAsJsonAsync("Users/register", newUser);

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public async Task<string> Login(string username, string password)
    {
        var user = new UserLogin(username, password);
        var response = await client.PostAsJsonAsync("Users/login", user);
        if (response.IsSuccessStatusCode)
        {
            var responseBody = await response.Content.ReadFromJsonAsync<UserLoginResponce>();

            return responseBody!.role;
        }

        return "";
    }
    
    record UserLogin(string username, string password);
    public record Result(
        string userName,
        string role
    );
    public record UserInfo(
        Result result,
        int id,
        object exception,
        int status,
        bool isCanceled,
        bool isCompleted,
        bool isCompletedSuccessfully,
        int creationOptions,
        object asyncState,
        bool isFaulted
    );
    record UserReg(string username, string password, string role);
    record UserLoginResponce(string token, string role);
}