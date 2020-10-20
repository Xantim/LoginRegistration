using Microsoft.EntityFrameworkCore;

namespace AS_LoginRegistration.Models
{
    //the MyContext class representing a session with our MySQL
    //DB allowing us to query for or save data

    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options) { }

        //Make sure to add models here
        public DbSet<User> Users {get;set;}
    }
}