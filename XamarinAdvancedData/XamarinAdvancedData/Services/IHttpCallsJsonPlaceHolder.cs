using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Refit;

namespace XamarinAdvancedData.Services
{

    public interface IHttpCallsJsonPlaceHolder
    {
        [Get("/posts")]
        Task<List<Post>> GetPosts();

        [Get("/posts/{id}")]
        Task<Post> GetPost(int id);

        [Get("/posts")]
        Task<ApiResponse<Post>> GetPostsApiResponse();

        [Post("/posts")]
        Task PostApi();
    }
}
