using System;
using Microsoft.EntityFrameworkCore;

namespace data.entities{
    public class MessagingContext : DbContext{
        public DbSet<User> Users { get; set;}
        public DbSet<Message> Messages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) 
        => options.UseNpgsql(GlobalConfig.GetPostgresConnectionString());
    }
    public class User{
        public int UserId { get; set; }
        public string Username { get; set; }
        private string Password { get; set;}
    }

    public class Message{
        public int MessageId { get; set;}
        public string Content { get; set; }
        public DateTime Sent{ get; set;}

        public int UserIdFrom { get; set;}
        public User UserFrom { get; set; }
        public int UserIdTo {get; set;}
        public User UserTo {get; set;}
    }
}