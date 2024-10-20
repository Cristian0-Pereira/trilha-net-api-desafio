using Microsoft.EntityFrameworkCore;
using TrilhaApiDesafio.Models;

namespace TrilhaApiDesafio.Context
{
    public class OrganizadorContext(DbContextOptions<OrganizadorContext> options) : DbContext(options)
    {
        public DbSet<Tarefa> Tarefas { get; set; }
    }
}