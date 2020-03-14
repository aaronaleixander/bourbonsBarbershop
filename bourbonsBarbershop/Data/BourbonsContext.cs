using Microsoft.EntityFrameworkCore;
using bourbonsBarbershop.Models; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bourbonsBarbershop.Data
{
    public class BourbonsContext : DbContext
    {
        public BourbonsContext(DbContextOptions<BourbonsContext> options) 
            : base(options) { }
        // Db Sets
    }
}
