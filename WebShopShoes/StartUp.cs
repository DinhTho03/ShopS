
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.OpenApi.Models;
using ShopShoes.Controllers;
using ShopShoes.Data;
using ShopShoes.IService.DetailPage_Description;
using ShopShoes.IService.IBlog;
using ShopShoes.IService.IHomePage;
using ShopShoes.Service.Blog;
using ShopShoes.Service.DetailPage_Description;
using ShopShoes.Service.HomePage;

namespace ShopShoes
{
    class StartUp
    {
        private readonly IConfiguration _configuration;

        public StartUp(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();
            services.AddScoped<IProduct, ProductResposity>();
            services.AddScoped<IHomePage, HomePageResposity>();
            services.AddScoped<IBlog, BlogResposity>();
            services.AddDbContext<ShopDbContext>(options =>
            {
                options.UseSqlServer(_configuration.GetConnectionString("ShopShoes"));
            });
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "MyWebApiApp", Version = "v1" });
            });
            services.AddCors(options =>
            {
                options.AddPolicy(name: "AllowOrigin",
                    builder =>
                    {
                        builder.AllowAnyOrigin()
                               .AllowAnyHeader()
                               .AllowAnyMethod();
                    });
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ShopShoes v1"));
            }
            app.UseCors("AllowOrigin");
            app.UseHttpsRedirection();
            app.UseAuthentication();
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

        }
    }
}