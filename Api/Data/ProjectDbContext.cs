using Microsoft.EntityFrameworkCore;

public class ProjectDbContext: DbContext
{
    // The DbSet collection represents the db table itself
    // which will have all the columns defined in the entity
    // We also set the intial value to an empty DbSet using the Set Method
    public DbSet<ProjectEntity> Projects => Set<ProjectEntity>();

    // TODO: Configure which database to use
    // Created an override in ProjectDbContext for OnConfiguring

    // This function is called when the context is being created.
    // It is used to configure the db (et al) to be used for this context
    // DbContextOptionsBuilder will be used to configure the DbContext.
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Variables determine good place for db file
        // These get the path to the local application data folder.
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);

        // Configuring the DbContext to use a SQLite database.
        optionsBuilder.UseSqlite($"Data Source={Path.Join(path, "projects.db")}");
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        SeedData.Seed(builder);
    }
}