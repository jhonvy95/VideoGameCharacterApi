using Microsoft.EntityFrameworkCore;
using VideoGameCharactersApi.Models;

namespace VideoGameCharactersApi.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options): DbContext(options)
{
    public DbSet<Character> Characters => Set<Character>();
}