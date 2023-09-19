using AutoMapper;
using ProductDotNet.Models;
using ProductDotNet.Service.Entity;
using ProductDotNet.Service.ProductDotNetService;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace ProductDotNet
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            container.RegisterType<IProductService, ProductService>();
            Mapper.Initialize(cfg => { cfg.CreateMap<ProductModel, ProductEntity>(); });
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}