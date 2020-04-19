using DevIO.Business.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevIO.Data.Context
{
    public class MeuDbContext : DbContext
    {
        public MeuDbContext(DbContextOptions options) : base(options) { }

        DbSet<Produto> Produtos { get; set; }
        DbSet<Endereco> Enderecos { get; set; }
        DbSet<Fornecedor> Fornecedores { get; set; }
    }
}
