using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlazorApp1forGit.Models;

namespace BlazorApp1forGit.Data
{
    public class BlazorApp1forGitContext : DbContext
    {
        public BlazorApp1forGitContext (DbContextOptions<BlazorApp1forGitContext> options)
            : base(options)
        {
        }

        public DbSet<BlazorApp1forGit.Models.Book> Book { get; set; } = default!;
    }
}
