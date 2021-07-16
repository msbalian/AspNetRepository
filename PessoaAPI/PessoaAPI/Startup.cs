using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PessoaAPI.Model.Context;
using PessoaAPI.Business;
using PessoaAPI.Business.Implementations;
using PessoaAPI.Repository;
using PessoaAPI.Repository.Implementations;

namespace PessoaAPI
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public IWebHostEnvironment Environment { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            
            services.AddControllers();

            //var connection = Configuration["PostgreSQLConnection:PostgreSQLConnectionString"];

            var connection = Configuration.GetConnectionString("PessoasDB");

            services.AddEntityFrameworkNpgsql().AddDbContext<PostgreSQLContext>(options => options.UseNpgsql(connection));

            services.AddApiVersioning();
            
            services.AddScoped<IPessoaBusiness, PessoaBusinessImplementation>();

            services.AddScoped<IPessoaRepository, PessoaRepositoryImplementation>();

        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }


    }



}
