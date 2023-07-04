using WebApplication7.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        using var db = new BloggingContext();
        {
            // CreateExam
            //Console.WriteLine("Inserting Exam Done");
            //db.Add(new Exam { examName = "Exam2", From_hour = 10, To_hour = 12 });
            //db.SaveChanges();

            // CreateMaterial
            //Console.WriteLine("Inserting Material Done");
            //db.Add(new Material { MaterialName = "Material3", MaterialDescription="Descasdasdasfcvsdjfvhsvdghj", Views_number = 84651 });
            //db.SaveChanges();
        }
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
}