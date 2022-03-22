using Microsoft.EntityFrameworkCore;
using SocialMediaCore.DTOs;
using SocialMediaCore.Interfaces;
using SocialMediaInfrastructure.Data;
using SocialMediaInfrastructure.Extension;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaInfrastructure.Repositories
{
    public class SimplyRepository : ISimply
    {

        private readonly SocialMediaContext _context;
        protected DbSet<Simply> Simply;

        public SimplyRepository(SocialMediaContext context) {

            this._context = context;
            Simply = context.Set<Simply>();
       

        }

        public async Task<List<Simply>> Bripeca() {

            var sql = "simply";
             var result = await Simply.ExecuteStoreProdecure(sql).ToListAsync();

            return result;
        }
    }
}
