using Microsoft.EntityFrameworkCore;

public class ProjectDbContext: DbContext
{
    // The DbSet collection represents the db table itself
    // which will have all the columns defined in the entity
    // We also set the intial value to an empty DbSet using the Set Method
    public DbSet<ProjectEntity> Projects => Set<ProjectEntity>();

    // TODO: Configure which database to use
}