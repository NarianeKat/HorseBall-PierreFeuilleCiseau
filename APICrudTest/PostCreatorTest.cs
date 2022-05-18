using APICrud.Model;
using System.Threading.Tasks;
using Xunit;
using System;
using System.Linq;

namespace APICrudTest
{
    public class PostCreatorTest
    {
        [Fact]
        public async Task GetPostAsync_ShouldReturnAllPostAsync()
        {
            // Arrange
            var postCreatorService = new PostCreator();
            // Arrange
            Post fakePost = new Post()
            {
                userId = 1,
                title = "nesciunt quas odio",
                body = "repudiandae veniam quaerat sunt sed\nalias aut fugiat sit autem sed est\nvoluptatem omnis possimus esse voluptatibus quis\nest aut tenetur dolor neque"
            };

            string path = "https://jsonplaceholder.typicode.com/posts/5";

            // Act
            Post results = await postCreatorService.GetPostAsync(path);


            // Assert
            Assert.Equal(results.title, fakePost.title);
        }


        //[Fact]
        //public async Task CreatePostAsync_WithNoSearch_ShouldReturnNewPostAsync()
        //{
        //    var postCreatorService = new PostCreator();
        //    // Arrange
        //    Post fakePost = new Post()
        //    {
        //        userId = 5,
        //        title = "Ma jolie patate",
        //        body ="Oh toi jolie patate. Je te croquerais bien. "
        //    };

        //    // Act
        //     Uri results = await postCreatorService.CreatePostAsync(fakePost);
            
        //    // Assert
        //    //Assert.NotEmpty(results.AbsolutePath);
        //}


    }
}