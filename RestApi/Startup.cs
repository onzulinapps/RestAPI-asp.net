﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RestApi.Startup))]
namespace RestApi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
