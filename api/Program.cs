
using API_Biblioteca.Contracts.Infrestructure;
using API_Biblioteca.Contracts.Services;
using API_Biblioteca.Infraestructure;
using API_Biblioteca.Services;

namespace API_Biblioteca
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            //Dependências
            builder.Services.AddSingleton<IConnection, Connection>();
            builder.Services.AddScoped<ICategoriaService, CategoriaService>();
            builder.Services.AddScoped<IAvaliacaoService, AvaliacaoService>();
            builder.Services.AddScoped<ILeitorService, LeitorService>();
            builder.Services.AddScoped<ILivroService, LivroService>();
            builder.Services.AddScoped<IUsuarioService, UsuarioService>();

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
}
