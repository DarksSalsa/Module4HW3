using System;
using System.IO;
using ITCompany;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

public class Program
{
    private static void Main(string[] args)
    {
        var builder = new ConfigurationBuilder();
        builder.SetBasePath(Directory.GetCurrentDirectory());
        builder.AddJsonFile("config.json");
        var config = builder.Build();
        var connectionString = config.GetSection("ConnectionString")["DefaultConnection"];
        var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
        var options = optionsBuilder.UseSqlServer(connectionString).Options;

        using (var db = new ApplicationContext(options))
        {
        }

        Console.Read();
    }
}