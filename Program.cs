using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
namespace Survey
{
    class Program
    {
        static HttpClient client = new HttpClient();
        static async Task RunAsync()
        {
            client.BaseAddress = new Uri("https://deadwoodapitest.azurewebsites.net/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            try
            {
                Survey survey = new Survey
                {
                    enviroGroup = false,
                    performedSurveyBefore = false,
                    woodlandName = "Sherwood Forrest",
                    latitude = "99",
                    longitude = "99",
                    gridRef = "5",
                    woodlandSize = 5.55,
                    deadwoodStandingOrLying = "Standing",
                    deadwoodDiameter = 6.0,
                    deadwoodLenght = 15.5,
                    deadwoodSpecies = "Birch",
                    holesInDeadwood = "yes",
                    floraOnDeadwood = "More Moss",
                    faunaOnDeadwood = "Bugs",
                    pencilDepth = 5.0,
                    deadwoodSoftness = "Hard",
                    faunaInDeadwood = "More Bugs",
                    deadwoodColour = "Derp Red",
                    stateOfDecay = 3
                };

                var url = await CreateSurveyAsync(survey);
                Console.WriteLine($"Create at {url}");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.InnerException);
                Console.WriteLine(e.StackTrace);
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }

        static async Task<Uri> CreateSurveyAsync(Survey survey)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync(
                "api/Surveys", survey);
            response.EnsureSuccessStatusCode();
            //Console.WriteLine(response.RequestMessage);
            var content = await response.Content.ReadAsStringAsync();
            Console.WriteLine(content.ToString());
            // return URI of the created resource.
            return response.Headers.Location;
        }

        static void Main(string[] args)
        {
            RunAsync().GetAwaiter().GetResult();
        }
    }
}
