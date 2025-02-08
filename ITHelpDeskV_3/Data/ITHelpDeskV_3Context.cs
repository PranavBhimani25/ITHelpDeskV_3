using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ITHelpDeskV_3.Model;

namespace ITHelpDeskV_3.Data
{
    public class ITHelpDeskV_3Context : DbContext
    {
        public ITHelpDeskV_3Context (DbContextOptions<ITHelpDeskV_3Context> options)
            : base(options)
        {
        }

        public DbSet<ITHelpDeskV_3.Model.UserLogin> UserLogin { get; set; } = default!;
    }
}
