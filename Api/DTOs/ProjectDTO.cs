// Using a record here not only for speed/convenience of adding properties
// But also because it is immutable
public record ProjectDTO(int Id, string? Address, string? Country, string? Description, int Budget);