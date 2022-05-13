﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using PasteBook.Data.Models;

#nullable disable

namespace PasteBook.Data
{
    public partial class PasteBookDbContext : DbContext
    {
        private readonly string dbConnectionString;
        public PasteBookDbContext(string dbConnectionString)
        {
            this.dbConnectionString = dbConnectionString;
        }

        public PasteBookDbContext(DbContextOptions<PasteBookDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Album> Albums { get; set; }
        public virtual DbSet<BlockedAccount> BlockedAccounts { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Friend> Friends { get; set; }
        public virtual DbSet<FriendRequest> FriendRequests { get; set; }
        public virtual DbSet<Image> Images { get; set; }
        public virtual DbSet<Like> Likes { get; set; }
        public virtual DbSet<Notification> Notifications { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<UserAccount> UserAccounts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=CLMBQG3;Database=PasteBookDb;User Id=sa;Password=Idunnowest2308");
            }
        }
    }
}
