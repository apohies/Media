using Microsoft.EntityFrameworkCore;
using SocialMediaCore.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialMediaInfrastructure.Data
{
    public partial class SocialMediaContext :DbContext
    {

        //public virtual DbSet<Simply> Simply { get; set; }


        partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {

         
            modelBuilder.Entity<Simply>(entity =>
            {
                entity.HasNoKey();
                entity.Property(e => e.UserId).HasColumnName("IdUsuario");
                entity.Property(e => e.FirstName).HasColumnName("Nombres");
                entity.Property(e => e.Lastname).HasColumnName("Apellidos");
                });


        
        }

        
    }


}
