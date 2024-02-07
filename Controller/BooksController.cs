using Entities.Books;
using Entities.Chapters;
using Entities.GenericClass;
using System.Text.Json;

namespace Controller
{
    public class BooksController
    {
        private HttpClient client;

        public BooksController()
        {
            client = new HttpClient();
        }

        // Metodo que regresa todos los books.
        public async Task<Data<Book>> GetAll()
        {
            try
            {
                Data<Book> data = new Data<Book>();
                HttpResponseMessage response = await client.GetAsync("https://api.potterdb.com/v1/books");
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();

                    data = JsonSerializer.Deserialize<Data<Book>>(content); // Deserializo.
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

        // Metodo que regresa todos los chapters de un book.
        public async Task<Data<Chapter>> GetAllChapters(string id)
        {
            try
            {
                Data<Chapter> data = new Data<Chapter>();
                HttpResponseMessage response = await client.GetAsync("https://api.potterdb.com/v1/books/" + id + "/chapters");
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();

                    data = JsonSerializer.Deserialize<Data<Chapter>>(content); // Deserializo.
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
