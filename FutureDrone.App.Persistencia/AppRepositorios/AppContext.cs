using System;
using Microsoft.EntityFrameworkCore;
using FutureDrone.App.Dominio;
namespace FutureDrone.App.Persistencia
{
  public class AppContext : DbContext //hereda de de Dbcontext
  {
    //se define un dbset por cada entidad del dominio
    public DbSet<Cliente> Clientes {get;set;}
    public DbSet<Encargado> Encargados {get;set;}
    public DbSet<Pedido> Pedidos {get;set;}

    
  }
}
