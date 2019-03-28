using System;
using System.Data.Entity;

namespace Taner.Data
{
    public class TanerDbContext : DbContext
    {
        public TanerDbContext() : base("name=TanerDBConnectionString")
        {
            Database.SetInitializer<TanerDbContext>(new TanerDbInitializer());
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<Entities.Kullanici> DbKullanicilar { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new Map.KullaniciConfiguration());
        }

    }

    public class TanerDbInitializer : CreateDatabaseIfNotExists<TanerDbContext>
    {
        protected override void Seed(TanerDbContext context)
        {
            context.DbKullanicilar.Add(new Entities.Kullanici { KullaniciAdi = "Ali", Sifre = "123", Ad = "Ali", Soyad = "Can" });
            context.DbKullanicilar.Add(new Entities.Kullanici { KullaniciAdi = "Veli", Sifre = "456", Ad = "Veli", Soyad = "Can" });
            context.SaveChanges();
            base.Seed(context);
        }
    }
}
