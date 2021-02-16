using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
            services.AddSingleton<ICarService, CarManager>();
            services.AddSingleton<ICarDal, EfCarDal>();
            services.AddSingleton<IColorService, ColorManager>();
            services.AddSingleton<IColorDal, EfColorDal>();
            services.AddSingleton<IBrandService, BrandManager>();
            services.AddSingleton<IBrandDal, EfBrandDal>();
            services.AddSingleton<IRentalService, RentalManager>();
            services.AddSingleton<IRentalDal, EfRentalDal>();
            services.AddSingleton<IUserService, UserManager>();
            services.AddSingleton<IUserDal, EfUserDal>();
            services.AddSingleton<ICustomerService, CustomerManager>();
            services.AddSingleton<ICustomerDal, EfCustomerDal>();

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


//System.InvalidOperationException
//  HResult = 0x80131509
//  Message=The following errors occurred with attribute routing information:

//Error 1:
//For action: 'WebAPI.Controllers.BrandsController.GetAll (WebAPI)'
//Error: The route template 'api/[controller/getall2' has invalid syntax. A replacement token is not closed.

//Error 2:
//For action: 'WebAPI.Controllers.BrandsController.GetById (WebAPI)'
//Error: The route template 'api/[controller/getbyýd2' has invalid syntax. A replacement token is not closed.

//Error 3:
//For action: 'WebAPI.Controllers.BrandsController.Add (WebAPI)'
//Error: The route template 'api/[controller/add2' has invalid syntax. A replacement token is not closed.

//Error 4:
//For action: 'WebAPI.Controllers.BrandsController.Update (WebAPI)'
//Error: The route template 'api/[controller/update2' has invalid syntax. A replacement token is not closed.

//Error 5:
//For action: 'WebAPI.Controllers.BrandsController.Delete (WebAPI)'
//Error: The route template 'api/[controller/delete2' has invalid syntax. A replacement token is not closed.

//Error 6:
//For action: 'WebAPI.Controllers.CustomersController.GetAll (WebAPI)'
//Error: The route template 'api/[controller/getall4' has invalid syntax. A replacement token is not closed.

//Error 7:
//For action: 'WebAPI.Controllers.CustomersController.GetById (WebAPI)'
//Error: The route template 'api/[controller/getbyýd4' has invalid syntax. A replacement token is not closed.

//Error 8:
//For action: 'WebAPI.Controllers.CustomersController.Add (WebAPI)'
//Error: The route template 'api/[controller/add4' has invalid syntax. A replacement token is not closed.

//Error 9:
//For action: 'WebAPI.Controllers.CustomersController.Update (WebAPI)'
//Error: The route template 'api/[controller/update4' has invalid syntax. A replacement token is not closed.

//Error 10:
//For action: 'WebAPI.Controllers.CustomersController.Delete (WebAPI)'
//Error: The route template 'api/[controller/delete4' has invalid syntax. A replacement token is not closed.

//Error 11:
//For action: 'WebAPI.Controllers.RentalsController.GetAll (WebAPI)'
//Error: The route template 'api/[controller/getall' has invalid syntax. A replacement token is not closed.

//Error 12:
//For action: 'WebAPI.Controllers.RentalsController.GetById (WebAPI)'
//Error: The route template 'api/[controller/getbyýd5' has invalid syntax. A replacement token is not closed.

//Error 13:
//For action: 'WebAPI.Controllers.RentalsController.Add (WebAPI)'
//Error: The route template 'api/[controller/add5' has invalid syntax. A replacement token is not closed.

//Error 14:
//For action: 'WebAPI.Controllers.RentalsController.Update (WebAPI)'
//Error: The route template 'api/[controller/update5' has invalid syntax. A replacement token is not closed.

//Error 15:
//For action: 'WebAPI.Controllers.RentalsController.Delete (WebAPI)'
//Error: The route template 'api/[controller/delete5' has invalid syntax. A replacement token is not closed.

//Error 16:
//For action: 'WebAPI.Controllers.UsersController.GetAll (WebAPI)'
//Error: The route template 'api/[controller/getall6' has invalid syntax. A replacement token is not closed.

//Error 17:
//For action: 'WebAPI.Controllers.UsersController.GetById (WebAPI)'
//Error: The route template 'api/[controller/getbyýd6' has invalid syntax. A replacement token is not closed.

//Error 18:
//For action: 'WebAPI.Controllers.UsersController.Add (WebAPI)'
//Error: The route template 'api/[controller/add6' has invalid syntax. A replacement token is not closed.

//Error 19:
//For action: 'WebAPI.Controllers.UsersController.Update (WebAPI)'
//Error: The route template 'api/[controller/update6' has invalid syntax. A replacement token is not closed.

//Error 20:
//For action: 'WebAPI.Controllers.UsersController.Delete (WebAPI)'
//Error: The route template 'api/[controller/delete6' has invalid syntax. A replacement token is not closed.
//  Source=Microsoft.AspNetCore.Mvc.Core
//  StackTrace:
//   at Microsoft.AspNetCore.Mvc.ApplicationModels.ApplicationModelFactory.Flatten[TResult] (ApplicationModel application, Func`5 flattener)
//   at Microsoft.AspNetCore.Mvc.ApplicationModels.ControllerActionDescriptorBuilder.Build(ApplicationModel application)
//   at Microsoft.AspNetCore.Mvc.ApplicationModels.ControllerActionDescriptorProvider.GetDescriptors()
//   at Microsoft.AspNetCore.Mvc.ApplicationModels.ControllerActionDescriptorProvider.OnProvidersExecuting(ActionDescriptorProviderContext context)
//   at Microsoft.AspNetCore.Mvc.Infrastructure.DefaultActionDescriptorCollectionProvider.UpdateCollection()
//   at Microsoft.AspNetCore.Mvc.Infrastructure.DefaultActionDescriptorCollectionProvider.Initialize()
//   at Microsoft.AspNetCore.Mvc.Infrastructure.DefaultActionDescriptorCollectionProvider.GetChangeToken()
//   at Microsoft.AspNetCore.Mvc.Routing.ActionEndpointDataSourceBase.<>c__DisplayClass11_0.<Subscribe>b__0()
//   at Microsoft.Extensions.Primitives.ChangeToken.ChangeTokenRegistration`1..ctor(Func`1 changeTokenProducer, Action`1 changeTokenConsumer, TState state)
//   at Microsoft.Extensions.Primitives.ChangeToken.OnChange(Func`1 changeTokenProducer, Action changeTokenConsumer)
//   at Microsoft.AspNetCore.Mvc.Routing.ActionEndpointDataSourceBase.Subscribe()
//   at Microsoft.AspNetCore.Mvc.Routing.ControllerActionEndpointDataSource..ctor(IActionDescriptorCollectionProvider actions, ActionEndpointFactory endpointFactory)
//   at System.RuntimeMethodHandle.InvokeMethod(Object target, Object[] arguments, Signature sig, Boolean constructor, Boolean wrapExceptions)
//   at System.Reflection.RuntimeConstructorInfo.Invoke(BindingFlags invokeAttr, Binder binder, Object[] parameters, CultureInfo culture)
//   at Microsoft.Extensions.DependencyInjection.ServiceLookup.CallSiteRuntimeResolver.VisitConstructor(ConstructorCallSite constructorCallSite, RuntimeResolverContext context)
//   at Microsoft.Extensions.DependencyInjection.ServiceLookup.CallSiteVisitor`2.VisitCallSiteMain(ServiceCallSite callSite, TArgument argument)
//   at Microsoft.Extensions.DependencyInjection.ServiceLookup.CallSiteRuntimeResolver.VisitCache(ServiceCallSite callSite, RuntimeResolverContext context, ServiceProviderEngineScope serviceProviderEngine, RuntimeResolverLock lockType)
//   at Microsoft.Extensions.DependencyInjection.ServiceLookup.CallSiteRuntimeResolver.VisitRootCache(ServiceCallSite singletonCallSite, RuntimeResolverContext context)
//   at Microsoft.Extensions.DependencyInjection.ServiceLookup.CallSiteVisitor`2.VisitCallSite(ServiceCallSite callSite, TArgument argument)
//   at Microsoft.Extensions.DependencyInjection.ServiceLookup.CallSiteRuntimeResolver.Resolve(ServiceCallSite callSite, ServiceProviderEngineScope scope)
//   at Microsoft.Extensions.DependencyInjection.ServiceLookup.DynamicServiceProviderEngine.<>c__DisplayClass1_0.<RealizeService>b__0(ServiceProviderEngineScope scope)
//   at Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceProviderEngine.GetService(Type serviceType, ServiceProviderEngineScope serviceProviderEngineScope)
//   at Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceProviderEngineScope.GetService(Type serviceType)
//   at Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService(IServiceProvider provider, Type serviceType)
//   at Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService[T](IServiceProvider provider)
//   at Microsoft.AspNetCore.Builder.ControllerEndpointRouteBuilderExtensions.GetOrCreateDataSource(IEndpointRouteBuilder endpoints)
//   at Microsoft.AspNetCore.Builder.ControllerEndpointRouteBuilderExtensions.MapControllers(IEndpointRouteBuilder endpoints)
//   at WebAPI.Startup.<>c.<Configure>b__5_0(IEndpointRouteBuilder endpoints) in C:\Users\PC\source\repos\MyReCarProject\WebAPI\Startup.cs:line 64
//   at Microsoft.AspNetCore.Builder.EndpointRoutingApplicationBuilderExtensions.UseEndpoints(IApplicationBuilder builder, Action`1 configure)
//   at WebAPI.Startup.Configure(IApplicationBuilder app, IWebHostEnvironment env) in C: \Users\PC\source\repos\MyReCarProject\WebAPI\Startup.cs:line 62
//   at System.RuntimeMethodHandle.InvokeMethod(Object target, Object[] arguments, Signature sig, Boolean constructor, Boolean wrapExceptions)
//   at System.Reflection.RuntimeMethodInfo.Invoke(Object obj, BindingFlags invokeAttr, Binder binder, Object[] parameters, CultureInfo culture)
//   at Microsoft.AspNetCore.Hosting.ConfigureBuilder.Invoke(Object instance, IApplicationBuilder builder)
//   at Microsoft.AspNetCore.Hosting.ConfigureBuilder.<>c__DisplayClass4_0.<Build>b__0(IApplicationBuilder builder)
//   at Microsoft.AspNetCore.Hosting.GenericWebHostBuilder.<>c__DisplayClass13_0.<UseStartup>b__2(IApplicationBuilder app)
//   at Microsoft.AspNetCore.Mvc.Filters.MiddlewareFilterBuilderStartupFilter.<>c__DisplayClass0_0.<Configure>g__MiddlewareFilterBuilder|0(IApplicationBuilder builder)
//   at Microsoft.AspNetCore.Server.IIS.Core.IISServerSetupFilter.<>c__DisplayClass2_0.<Configure>b__0(IApplicationBuilder app)
//   at Microsoft.AspNetCore.HostFilteringStartupFilter.<>c__DisplayClass0_0.<Configure>b__0(IApplicationBuilder app)
//   at Microsoft.AspNetCore.Hosting.GenericWebHostService.<StartAsync>d__31.MoveNext()
