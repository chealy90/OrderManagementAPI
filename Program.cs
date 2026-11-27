using OrderManagementAPI.Models;
using System.Diagnostics;

namespace OrderManagementAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            Customer cust1 = new Customer("cust1", "password1", "123 Main St");
            StoreAssistant sa1 = new StoreAssistant("sa1", "password2", "Electronics");
            DeliveryDriver dd1 = new DeliveryDriver("dd1", "password3", "ABC123");

            Debug.WriteLine(cust1.username);
            Debug.WriteLine(sa1.department);
            Debug.WriteLine(dd1.licensePlate);


            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
