
using FootsallTeamManagment.Contracts;
using FootsallTeamManagment.Persistence.EF;
using FootsallTeamManagment.Persistence.EF.Teams;
using FootsallTeamManagment.Services.Teams;
using FootsallTeamManagment.Services.Teams.Contracts;

namespace FootsallTeamManagment.Api
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

            builder.Services.AddDbContext<EFDataContext>();

            builder.Services.AddScoped<TeamService, TeamAppService>();
            builder.Services.AddScoped<TeamRepository, EfTeamRepository>();


            builder.Services.AddScoped<UnitOfWork, EFUnitOfWork>();

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
}
