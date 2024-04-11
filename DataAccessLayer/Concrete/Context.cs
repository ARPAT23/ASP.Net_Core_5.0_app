using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace DataAccessLayer.Concrete
{
    public class Context : IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("server=LAPTOP-OA65NA35\\SQLEXPRESS;database=CoreBlogDB;integrated security=true;Encrypt=false");
            //optionsBuilder.UseSqlServer("server=185.27.134.103\\sql110.infinityfree.com;database=if0_36344981_core_blog_db;user=if0_36344981;password=qfLxLXueUh");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Message2>()
                .HasOne(x => x.SenderUser)
                .WithMany(y => y.WriterSender)
                .HasForeignKey(z => z.SenderID)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Message2>()
               .HasOne(x => x.ReceiverUser)
               .WithMany(y => y.WriterReceiver)
               .HasForeignKey(z => z.ReceiverID)
               .OnDelete(DeleteBehavior.ClientSetNull);

            base.OnModelCreating(modelBuilder);

        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<EntityLayer.Concrete.Command> Coments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Writer> Writers { get; set; }
        public DbSet<NewsLetter>NewsLetters { get; set; }
        public DbSet<BlogRayting>BlogRaytings { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Message2> Messages2 { get; set; }
        public DbSet<Admin> Admins { get; set; }
 
      }
    }
