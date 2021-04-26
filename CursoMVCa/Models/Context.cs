using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CursoMVCa.Models
{
    public class Context : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; } 

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Instacia SQL 2008:
            optionsBuilder.UseSqlServer(@"Server=.\SQL2008;initial catalog=CursoMVCa;user Id=sa;password=123");

            //Instacia SQL 2017:
            //optionsBuilder.UseSqlServer(@"Server=.\SQLexpress;initial catalog=CursoMVCa;user Id=sa;password=123");




            //-----------------------------------------------------------------------------------------------------------------------------
            // TESTE COMO Local DB com erro de conexao --- 
            //-----------------------------------------------------------------------------------------------------------------------------
            // optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=CursoMVCa;Trusted_Connection=True");
            // optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;Server=(LocalDB)\MSSQLLocalDB;Integrated Security=true;User Instance=true;User=sa;Password=123;AttachDbFileName=C:\Temp\LocalDB.mdf");
            //optionsBuilder.UseSqlServer(@"Server=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=H:\\Noot_DELL\\Dev_Software\\WorkSpaceC#\\BootCampNET\\CursoMVCa\\CursoMVCa.mdf; Trusted_Connection=True; MultipleActiveResultSets=true");
        }
    }
}
