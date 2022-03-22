using Microsoft.EntityFrameworkCore;
using SocialMediaCore.Entities;
using SocialMediaCore.Interfaces;
using SocialMediaInfrastructure.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SocialMediaInfrastructure.Repositories
{
    public class PostRepository : IPostRepository
    {

        private readonly SocialMediaContext _context;


        public PostRepository(SocialMediaContext context)
        {
            _context = context;
        }


        public async Task<IEnumerable<Post>> GetPosts()
        {
            var post = await _context.Posts.ToListAsync();

            return post;

        }

        public async Task<Post> GetPost(int id) {

            Post posteo = await _context.Posts.Where(s => s.PostId == id).SingleAsync();

            return posteo;
        }



    }
}
