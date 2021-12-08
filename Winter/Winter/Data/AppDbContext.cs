using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Winter.Models;

namespace Winter.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions option) : base(option)
        { }
        public DbSet<AboutAligned> AboutAligneds { get; set; }
        public DbSet<AboutButton> AboutButtons { get; set; }
        public DbSet<AboutDefinition> AboutDefinitions { get; set; }
        public DbSet<AboutSection> AboutSections { get; set; }
        public DbSet<AboutSetting> AboutSettings { get; set; }
        public DbSet<AboutTable> AboutTables { get; set; }
        public DbSet<AboutText> AboutTexts { get; set; }
        public DbSet<Accound> Accounds { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogCategory> BlogCategories { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<CommentAbout> CommentAbouts { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Cpecification> Cpecifications { get; set; }
        public DbSet<Description> Descriptions { get; set; }
        public DbSet<Details> Details { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Filter> Filters { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Posts> Postes { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Reviews> Reviewies { get; set; }
        public DbSet<Search> Searchs { get; set; }
        public DbSet<Select> Selects { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Shipping> Shippings { get; set; }
        public DbSet<SideCategory> SideCategories { get; set; }
        public DbSet<Sosial> Sosials { get; set; }
        public DbSet<Subscribe> Subscribes { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Track> Tracks { get; set; }
        public DbSet<Tracking> Trackings { get; set; }
        public DbSet<User> Users { get; set; }
      
    }


}

