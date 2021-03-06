
using SocialMediaCore.Entities;
using System;
using System.Collections.Generic;

using System.Threading.Tasks;

namespace SocialMediaCore.Interfaces
{
    public interface IPostRepository
    {
        Task<IEnumerable<Post>> GetPosts();
         Task<Post> GetPost(int id);
    }
}
