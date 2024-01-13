////using Infra.Contexts;
////using Infra.UnitOfWork;
////using Infra.UnitOfWork.Interfaces;
////using Microsoft.AspNetCore.Authentication.Negotiate;
////using Microsoft.EntityFrameworkCore;

////namespace Api
////{
////    /// <summary>
////    /// Contains methods which are called on web application start-up.
////    /// </summary>
////    public class Startup
////    {
////        #region Properties

////        public IConfiguration Configuration { get; }

////        #endregion

////        #region Constructor

////        /// <summary>
////        /// Constructor.
////        /// </summary>
////        /// <param name="configuration">The application configuration interface</param>
////        public Startup(IConfiguration configuration)
////        {
////            Configuration = configuration;
////        }

////        #endregion

////        #region Methods

////        /// <summary>
////        /// This method gets called by the runtime.
////        /// Use this method to add services to the container.
////        /// </summary>
////        /// <param name="services">The collection of container services</param>
////        public void ConfigureServices(IServiceCollection services)
////        {
////            services.AddControllers();

////            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
////            services.AddEndpointsApiExplorer();
////            services.AddSwaggerGen();

////            services.AddAuthentication(NegotiateDefaults.AuthenticationScheme).AddNegotiate(); 
////            services.AddAuthorization(options =>
////            {
////                // By default, all incoming requests will be authorized according to the default policy.
////                options.FallbackPolicy = options.DefaultPolicy;
////            });

////            services.AddDbContext<AppDbContext>(options =>
////                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

////            //// services.AddRazorPages();

////            services.AddScoped<IUnitOfWork, UnitOfWork>();
////        }

////        /// <summary>
////        /// This method gets called by the runtime.
////        /// Use this method to configure the HTTP request pipeline.
////        /// </summary>
////        /// <param name="app">The application builder object used to configure the request pipeline</param>
////        /// <param name="env">The web hosting environment the application is running in</param>
////        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
////        {
////            if (env.IsDevelopment())
////            {
////                app.UseDeveloperExceptionPage();
////            }
////            else
////            {
////                app.UseExceptionHandler("/Error");

////                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
////                app.UseHsts();
////            }

////            app.UseHttpsRedirection();
////            app.UseStaticFiles();

////            app.UseRouting();

////            app.UseAuthorization();

////            app.UseEndpoints(endpoints =>
////            {
////                //// endpoints.MapRazorPages();
////            });

////        }

////        #endregion
////    }
////}
