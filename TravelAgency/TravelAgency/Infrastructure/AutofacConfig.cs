﻿using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using AutoMapper;
using TravelAgency.BusinessLogic.Infrastructure;

namespace TravelAgency.Infrastructure
{
    public class AutofacConfig
    {
        public static void ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            new BLAutofacConfig(builder);

            var mapperConfig = new MapperConfiguration(cfg =>
                {
                    cfg.AddProfiles(new Profile[] { new GlobalProfile(), new MapProfile() });
                });

            builder.Register(c => new Mapper(mapperConfig)).AsSelf();

            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}