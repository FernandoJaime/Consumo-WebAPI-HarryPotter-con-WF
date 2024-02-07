using Entities.Books;
using Entities.GenericClass;
using Entities.Movies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Controller
{
    public class MoviesController
    {
        private HttpClient client;

        public MoviesController()
        {
            client = new HttpClient();
        }

        // Metodo que regresa todos los books.
        public async Task<Data<Movie>> GetAll()
        {
            try
            {
                Data<Movie> data = new Data<Movie>();
                HttpResponseMessage response = await client.GetAsync("https://api.potterdb.com/v1/movies");
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();

                    data = JsonSerializer.Deserialize<Data<Movie>>(content); // Deserializo.
                    return data;
                }
                else
                {
                    Console.WriteLine("Error al obtener los datos. Código de estado: " + response.StatusCode);
                    return null;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error inesperado: " + e.Message);
                return null;
            }
        }

    }
}