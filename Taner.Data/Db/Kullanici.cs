using System.Collections.Generic;
using System.Linq;

namespace Taner.Data.Db
{
    public class Kullanici
    {
        public static List<Entities.Kullanici> List()
        {
            using (var c = new TanerDbContext())
            {
                return c.DbKullanicilar.ToList();
            }
        }

        public static void Add(Entities.Kullanici kullanici)
        {
            using (var c = new TanerDbContext())
            {
                c.DbKullanicilar.Add(kullanici);
                c.SaveChanges();
            }
        }

        public static void Update(Entities.Kullanici kullanici)
        {
            using (var c = new TanerDbContext())
            {
                c.DbKullanicilar.Attach(kullanici);
                c.Entry(kullanici).State = System.Data.Entity.EntityState.Modified;
                c.SaveChanges();
            }
        }

        public static void Delete(long id)
        {
            using (var c = new TanerDbContext())
            {
                var kullanici = c.DbKullanicilar.Find(id);
                c.Entry(kullanici).State = System.Data.Entity.EntityState.Deleted;
                c.SaveChanges();
            }
        }
    }
}
