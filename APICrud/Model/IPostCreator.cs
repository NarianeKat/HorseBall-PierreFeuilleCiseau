using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace APICrud.Model
{
    public interface IPostCreator
    {
        public Task<Uri> CreatePostAsync(Post post);
        public Task<Post> GetPostAsync(string path);
        public Task<Post> UpdatePostAsync(Post post);
        public Task<HttpStatusCode> DeletePosttAsync(string id);
    }
}
