using Microsoft.EntityFrameworkCore;
using BackEnd.Models;

namespace BackEnd.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
        : base(options)
        {

        }
        public DbSet<Caminhao> Caminhoes { get; set; }
        public DbSet<Carga> Cargas { get; set; }
        public DbSet<Motorista> Motoristas { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
    }
}