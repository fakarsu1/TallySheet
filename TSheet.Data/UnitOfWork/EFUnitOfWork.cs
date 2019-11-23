using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSheet.Core.Domain;
using TSheet.Data.Repository;

namespace TSheet.Data.UnitOfWork
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private DbContext _context;
        public EFUnitOfWork(DbContext context)
        {
            _context = context;

        }
        public int SaveChanges()
        {
            return _context.SaveChanges();
        }
        public void Dispose()
        {
            _context.Dispose();
        }

        public IRepository<T> GetRepository<T>() where T : BaseEntity
        {
            return new Repository<T>(_context);
        }

        public string SaveChangesTransactional()
        {
            using (DbContextTransaction transaction = _context.Database.BeginTransaction())
            {
                try
                {

                    _context.SaveChanges();

                    transaction.Commit();
                    return "İşlem başarılı.";
                }
                catch (System.Data.Entity.Infrastructure.DbUpdateException)
                {
                    transaction.Rollback();
                    return "Daha önceden girilmiş bir veya daha fazla veri tespit edildi. Seçili işlemlerin hiçbiri eklenmedi. Lütfen kontrol edip tekrar deneyiniz.";
                }
                catch (Exception ex)
                {
                    transaction.Rollback();


                    return ex.InnerException.InnerException.Message;
                }
            }

        }
    }
}
