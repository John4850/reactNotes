using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Duende.IdentityServer.EntityFramework.Options;
using react_notes.Models;

namespace reactnet_tutorial.Data
{
  public class MyDBContext : DbContext
  {
    public MyDBContext(DbContextOptions<MyDBContext> options) : base(options) { }
    public DbSet<Note> Notes { get; set; }
  }
}