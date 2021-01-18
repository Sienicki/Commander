using Commander.Models;
using Microsoft.EntityFrameworkCore;

namespace Combiner.Data
{
    public class CommanderContext : DbContext 
    {
        public CommanderContext(DbContextOptions<CommanderContext> opt) : base(opt)
        {

        }

        public DbSet<Command> Commands { get; set; }
    }
}