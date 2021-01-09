﻿using MB.Domain.ArticleAgg;
using MB.Domain.ArticleCategoryAgg;
using MB.Domain.CommentAgg;
using MB.Infrastructure.EFCore.Mappings;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MB.Infrastructure.EFCore
{
    public class MasterBloggerContext: DbContext 
    {
        public DbSet<ArticleCategory>ArticleCategories { get; set; }
        public DbSet<Article>Articles { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public MasterBloggerContext(DbContextOptions<MasterBloggerContext> options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var assembly = typeof(ArticleMapping).Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly(assembly);

            //modelBuilder.ApplyConfiguration(new ArticleCategoryMapping());
            //modelBuilder.ApplyConfiguration(new ArticleMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}
