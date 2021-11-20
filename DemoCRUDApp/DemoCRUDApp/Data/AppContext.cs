﻿using Microsoft.EntityFrameworkCore;

namespace DemoCRUDApp.Data
{
    public class AppContext:DbContext
    {
        public AppContext() { }
        public AppContext(DbContextOptions<AppContext> options) :
              base(options)
        { }
    }
}
