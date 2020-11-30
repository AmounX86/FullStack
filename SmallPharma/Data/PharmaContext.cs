using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SmallPharma.Models;

namespace SmallPharma.Data
{
    public class PharmaContext:DbContext
    {
        public PharmaContext(DbContextOptions<PharmaContext> options):base(options)
        {
        }
        public DbSet<Claim> Claims { get; set; }
        public DbSet<ClaimDetail> ClaimDetails { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<ClientLedger> ClientLedgers { get; set; }
        public DbSet<Concentration> Concentrations { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Form> Forms { get; set; }
        public DbSet<Generic> Generics { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceDetail> InvoiceDetails { get; set; }
        public DbSet<Price> Prices { get; set; }
        public DbSet<Producer> Producers { get; set; }
        public DbSet<Salary> Salaries { get; set; }
        public DbSet<StoreItem> StoreItems { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<SupplierLedger> SupplierLedgers { get; set; }
        public DbSet<TradeName> TradeNames { get; set; }
        public DbSet<TradeNameSupp> TradeNameSupps { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<Worker> Workers { get; set; }

    }
}
