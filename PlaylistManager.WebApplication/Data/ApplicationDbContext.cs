﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PlaylistManager.WebApplication.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlaylistManager.WebApplication.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Playlist> Playlists { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<PlaylistSong> PlaylistsSongs { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<PlaylistSong>(ps =>
            {
                ps.HasKey(key => new { key.PlaylistId, key.SongId });
            });

            base.OnModelCreating(builder);
        }
    }
}
