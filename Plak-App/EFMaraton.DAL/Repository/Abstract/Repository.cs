using EFMaraton.DAL.Context;
using EFMaraton.DAL.Entities.Abstract;
using EFMaraton.DAL.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static Azure.Core.HttpHeader;

namespace EFMaraton.DAL.Repository.Abstract
{
    public abstract class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly EFMaratonDbContext _db;
        private DbSet<T> entities;

        public Repository(EFMaratonDbContext db)
        {
            _db = db;
            entities = _db.Set<T>();
        }



        public void Insert(T entity)
        {
            entity.DataStatus = DataStatus.Inserted;
            entity.Created = DateTime.Now;
            entities.Add(entity);
            _db.SaveChanges();
        }
        public void Update(T entity)
        {
            entity.DataStatus = entity.DataStatus != DataStatus.Deleted
                          ? DataStatus.Modified : DataStatus.Deleted;

            entity.Updated = DateTime.Now;
            var createdBefore = entity.Created;
            using (var dbContext = new EFMaratonDbContext())
            {
                var existingEntity = dbContext.Set<T>().Find(entity.Id);
                if (existingEntity != null)
                {
                    entity.Created = createdBefore;
                    dbContext.Entry(existingEntity).CurrentValues.SetValues(entity);

                    dbContext.SaveChanges();
                }
            }

        }


        public void UpdateDeletedValues(T entity)
        {
            entity.DataStatus = entity.DataStatus != DataStatus.Deleted
                          ? DataStatus.Modified : DataStatus.Deleted;


            entity.Updated = DateTime.Now;
            entity.Created = GetDeletedById(entity.Id).Created;
            entities.Update(entity);

            _db.SaveChanges();
        }
        public void Delete(T entity)
        {
            entity.DataStatus = DataStatus.Deleted;
            entity.Deleted = DateTime.Now;
            Update(entity);
        }

        public void Remove(T entity)
        {
            _db.Remove(entity);
            _db.SaveChanges();
        }
        public IQueryable<T> GetAll()
        {
            return entities.Where(e => e.DataStatus != DataStatus.Deleted).AsNoTracking();
        }
        public T GetById(int id)
        {
            return entities.AsNoTracking().FirstOrDefault(e => e.Id == id && e.DataStatus != DataStatus.Deleted);
        }
        public T GetDeletedById(int id)
        {
            return entities.AsNoTracking().FirstOrDefault(e => e.Id == id && e.DataStatus == DataStatus.Deleted);
        }

        public IQueryable<T> Search(Expression<Func<T, bool>> predicate)
        {
            var all = entities.Where(e => e.DataStatus != DataStatus.Deleted);
            return all.Where(predicate);
        }

    }
}
