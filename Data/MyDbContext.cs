using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Duende.IdentityServer.EntityFramework.Options;
using reactNotes.Models;

namespace reactNotes.Data
{
  public class MyDBContext : DbContext
  {
    public MyDBContext(DbContextOptions<MyDBContext> options) : base(options) { }
    public DbSet<Note>? Notes { get; set; }
    
  }
}