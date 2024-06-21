using Blogzor.Config;
using Blogzor.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace Blogzor.Services;

public class BlogContext : DbContext
{
    private readonly MongoClient _client;
    private readonly string _dbName;

    public BlogContext(IOptions<DatabaseSettings> databaseSettings)
    {
        _client = new MongoClient(
            databaseSettings.Value.ConnectionString);

        _dbName = databaseSettings.Value.DatabaseName;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
        optionsBuilder.UseMongoDB(_client, _dbName);

    public DbSet<Article> Articles => Set<Article>();
}