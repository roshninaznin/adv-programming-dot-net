using Assignment_dot_net.EF;
using Assignment_dot_net.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Assignment_dot_net.EF;

public partial class RegistrationDbContext : DbContext
{
    public DbSet<User> Users { get; set; }

    public RegistrationDbContext()
    {
    }

    public RegistrationDbContext(DbContextOptions<RegistrationDbContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=RegistrationDbContext");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
