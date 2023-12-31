﻿using System.Reflection;
using CEH.Domain.Models.Location;
using CEH.Domain.Models.Locations;
using Domain.Commons;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Infrastructure.Persistence.EntityFramework;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(
        DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    //https://learn.microsoft.com/en-us/ef/core/miscellaneous/collations-and-case-sensitivity

    public DbSet<Device> Devices => Set<Device>();
    public DbSet<Province> Provinces => Set<Province>();
    public DbSet<District> Districts => Set<District>();
    public DbSet<City> Cities => Set<City>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        base.OnModelCreating(modelBuilder);
    }

    public override int SaveChanges(bool acceptAllChangesOnSuccess)
    {
        OnBeforeSaving();
        return base.SaveChanges(acceptAllChangesOnSuccess);
    }

    public override async Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
    {
        OnBeforeSaving();
        return await base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
    }

    private void OnBeforeSaving()
    {
        UpdateSoftDelete();
        UpdateTimestamps();
    }

    private void UpdateSoftDelete()
    {
        foreach (var entry in ChangeTracker.Entries<Entity>())
        {
            switch (entry.State)
            {
                case EntityState.Added:
                    entry.Entity.IsDeleted = false;
                    break;
                case EntityState.Deleted:
                    entry.State = EntityState.Modified;
                    entry.Entity.IsDeleted = true;
                    break;
            }
        }
    }

    private void UpdateTimestamps()
    {
        // TODO: Get real current user id
        var currentUserId = Guid.NewGuid();

        foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
        {
            if (entry.State == EntityState.Added)
            {
                entry.Entity.CreatedDate = DateTime.Now;
                //entry.Entity.CreatedBy = currentUserId;
            }

            entry.Entity.LastModifiedDate = DateTime.Now;
            //entry.Entity.LastModifiedBy = currentUserId;
        }
    }
}
