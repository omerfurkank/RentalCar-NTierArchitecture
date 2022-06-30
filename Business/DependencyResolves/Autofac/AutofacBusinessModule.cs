using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstracts;
using Business.Concretes;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolves.Autofac
{
    public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CarManager>().As<ICarService>();
            builder.RegisterType<RentalManager>().As<IRentalService>();
            builder.RegisterType<ColorManager>().As<IColorService>();
            builder.RegisterType<BrandManager>().As<IBrandService>();
            builder.RegisterType<CustomerManager>().As<ICustomerService>();
            builder.RegisterType<EfCarDal>().As<ICarDal>();
            builder.RegisterType<EfRentalDal>().As<IRentalDal>();
            builder.RegisterType<EfColorDal>().As<IColorDal>();
            builder.RegisterType<EfBrandDal>().As<IBrandDal>();
            builder.RegisterType<EfCustomerDal>().As<ICustomerDal>();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }

    }
}
