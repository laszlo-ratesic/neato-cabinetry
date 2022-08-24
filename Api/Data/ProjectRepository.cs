using Microsoft.EntityFrameworkCore;

// We create an interface here alongside the implementation
// Usually a good idea to separate eventually

// Interface has method
public interface IProjectRepository
{
    Task<List<ProjectDTO>> GetAll();
}

// Class implements interface
public class ProjectRepository: IProjectRepository
{
    private readonly ProjectDbContext context;

    // In the constructor we're accepting a ProjectDbContext object
    public ProjectRepository(ProjectDbContext context)
    {
        this.context = context;
    }

// Create an async method that returns a list of ProjectDTO objects named GetAll
    public async Task<List<ProjectDTO>> GetAll()
    {
        // and the accessing of the Projects DbSet and the projection to DTOs goes here
        // We use ToListAsync to create the generic list which we await
        return await context.Projects.Select(p => new ProjectDTO(p.Id, p.Address, p.Country, p.Budget)).ToListAsync();
    }
}