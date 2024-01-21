using APSCORE.Entities;
using static APSCORE.Service.MySqlService;
using System.Security.Policy;

internal class Program
{
    private static void Main(string[] args)
    {
        //InsertData();

        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();


    }
    private static void InsertData()
    {
        using (var context = new LibraryContext())
        {
            // Creates the database if not exists
            context.Database.EnsureCreated();

            // Adds a publisher

            // Adds some books
            context.Book.Add(new Book
            {
                ISBN = "978-0544003415",
                Title = "The Lord of the Rings",
                Author = "J.R.R. Tolkien",
                Language = "English",
                Pages = 1216,

            });
            context.Book.Add(new Book
            {
                ISBN = "978-0547247762",
                Title = "The Sealed Letter",
                Author = "Emma Donoghue",
                Language = "English",
                Pages = 416,

            });

            // Saves changes
            context.SaveChanges();
        }
    }
}
