using ApiDemo.Domain.Entities;

namespace ApiDemo.Infrastructure.Data;

public static class InMemoryDb
{
    public static List<User> Users = new()
    {
        new User {Id = Guid.NewGuid(), Name = "Jose", Email = "jose@example.com" },
        new User {Id = Guid.NewGuid(), Name = "Juan", Email = "juan@example.com" },
        new User {Id = Guid.NewGuid(), Name = "Pepe", Email = "pepe@example.com" }
    };
}