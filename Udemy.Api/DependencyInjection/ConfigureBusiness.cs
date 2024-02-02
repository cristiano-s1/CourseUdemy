﻿using Udemy.Api.Business;
using Udemy.Api.Business.Implementations;

namespace Udemy.Api.DependencyInjection
{
    public class ConfigureBusiness
    {
        public static void ConfigureDependenciesBusiness(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IPersonBusiness, PersonBusinessImplementation>();
        }
    }
}
