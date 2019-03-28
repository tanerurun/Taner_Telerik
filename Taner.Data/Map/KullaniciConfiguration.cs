using System.Data.Entity.ModelConfiguration;

namespace Taner.Data.Map
{
    public class KullaniciConfiguration : EntityTypeConfiguration<Entities.Kullanici>
    {
        public KullaniciConfiguration()
        {
            ToTable("Kullanici", "Ort");
            Ignore(i => i.TamAd);
            HasKey(k => k.Id);
            HasIndex(i => i.KullaniciAdi);

            Property(e => e.KullaniciAdi)
                .HasColumnName("KullaniciAdi")
                .IsUnicode(false)
                .HasMaxLength(50)
                .IsRequired();

            Property(e => e.Sifre)
                .HasColumnName("Sifre")
                .IsUnicode(false)
                .HasMaxLength(50)
                .IsRequired();

            Property(e => e.Ad)
                .HasColumnName("Ad")
                .HasMaxLength(150);

            Property(e => e.Soyad)
                .HasColumnName("Soyad")
                .HasMaxLength(150);
        }
    }
}
