﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using financeiro.ApplicationCore.Entity;

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;


namespace financeiro.UI.Web.Data
{
    public class financeiroUIWebContext : IdentityDbContext<Usuario>
    {
        //public financeiroUIWebContext(DbContextOptions<financeiroUIWebContext> options)
        //    : base(options)
        //{
        //}

        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    //base.OnModelCreating(builder);
        //    // Customize the ASP.NET Identity model and override the defaults if needed.
        //    // For example, you can rename the ASP.NET Identity table names and more.
        //    // Add your customizations after calling base.OnModelCreating(builder);
        //}
    }
}