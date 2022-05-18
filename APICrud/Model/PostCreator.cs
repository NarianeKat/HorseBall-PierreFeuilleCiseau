using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace APICrud.Model 
{
    public class Post
    {
        public int userId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public string body { get; set; }

    }
    public class PostCreator :  IPostCreator
    {
        static HttpClient client= new HttpClient();

        static async Task<Uri> CreatePostAsync(Post post)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync(
                "api/posts", post);
            response.EnsureSuccessStatusCode();

            // return URI of the created resource.
            return response.Headers.Location;
        }

        static async Task<Post> GetPostAsync(string path)
        {
            Post post = null;
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                post = await response.Content.ReadAsAsync<Post>();
            }
            return post;
        }

        static async Task<Post> UpdatePostAsync(Post post)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync(
                $"api/posts/{post.id}", post);
            response.EnsureSuccessStatusCode();

            // Deserialize the updated product from the response body.
            post = await response.Content.ReadAsAsync<Post>();
            return post;
        }

        static async Task<HttpStatusCode> DeletePosttAsync(string id)
        {
            HttpResponseMessage response = await client.DeleteAsync(
                $"api/posts/{id}");
            return response.StatusCode;
        }
    }
}
