using System;

namespace Taner.Data.Entities
{
    public class Kullanici : EntityBase<long>
    {
        public virtual string KullaniciAdi { get; set; }

        public virtual string Sifre { get; set; }

        public virtual string Ad { get; set; }

        public virtual string Soyad { get; set; }

        public virtual string TamAd { get { return $"{Ad} {Soyad}"; } }

    }
}
