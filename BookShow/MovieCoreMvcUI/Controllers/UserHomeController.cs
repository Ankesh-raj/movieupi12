using BookShowEntity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace MovieCoreMvcUI.Controllers
{
    public class UserHomeController : Controller
    {

        private IConfiguration _configuration;

        public UserHomeController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Movie> movieresult = null;
            using (HttpClient client = new HttpClient())
            {
                //StringContent content = new StringContent(JsonConvert.SerializeObject(movie), Encoding.UTF8, "application/json");
                string endPoint = _configuration["WebApiBaseUrl"] + "Movie/GetMovies";
                using (var response = await client.GetAsync(endPoint))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var result = await response.Content.ReadAsStringAsync();
                        movieresult = JsonConvert.DeserializeObject<IEnumerable<Movie>>(result);
                    }
                }
            }
            return View(movieresult);
        }
    }
}
