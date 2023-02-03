using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

namespace WebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            //All Services of Business Layer is Here.
            services.AddSingleton<IUserService, UserManager>();
            services.AddSingleton<ICarService, CarManager>();
            services.AddSingleton<IColorService, ColorManager>();
            services.AddSingleton<IBrandService, BrandManager>();
            services.AddSingleton<IRentalService, RentalManager>();
            services.AddSingleton<ICustomerService, CustomerManager>();

            //All DAL of Data Access Layer is Here.
            services.AddSingleton<IUserDal, EfUserDal>();
            services.AddSingleton<ICarDal, EfCarDal>();
            services.AddSingleton<IColorDal, EfColorDal>();
            services.AddSingleton<ICustomerDal, EfCustomerDal>();
            services.AddSingleton<IBrandDal, EfBrandDal>();
            services.AddSingleton<IRentalDal, EfRentalDal>();
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